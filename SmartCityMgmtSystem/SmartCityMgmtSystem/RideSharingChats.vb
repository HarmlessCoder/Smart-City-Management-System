Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class RideSharingChats
    'To pass information from the parent form in form of property
    Public Property uid As Integer = 1
    Public Property u_name As String = "Dhanesh"
    Public Property poster_uid As Integer = 1     'UID of the poster of this post
    Public Property req_id As Integer = 1
    Public DriverNote As String = ""
    Public VehicleNumber As String = ""


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' For checkbox column - only for poster - allow editing
        If poster_uid = uid Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("Approve").Index Then
                ' Check if the clicked cell is in the "Approve" column
                Dim cell As DataGridViewCheckBoxCell = TryCast(DataGridView1.Rows(e.RowIndex).Cells("Approve"), DataGridViewCheckBoxCell)

                If cell IsNot Nothing Then
                    ' Manually toggle the checkbox value
                    If cell.Value = "added" Then
                        cell.Value = "not-added"
                    Else
                        cell.Value = "added"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub AddChat(name As String,
                        postNum As Integer,
                           Optional datetime As String = "",
                          Optional comment As String = "",
                          Optional image As Image = Nothing,
                          Optional isRider As Boolean = True)
        Dim ChatBubble As ChatBubbleItem
        ChatBubble = New ChatBubbleItem()
        With ChatBubble
            .Name = "chat_" & postNum
            If Not isRider Then
                .Margin = New Padding(PostsPanel.Width - ChatBubble.Width - 25, 12, 0, 3)
            End If
        End With
        ChatBubble.SetDetails(name, datetime, comment, image, isRider)
        PostsPanel.Controls.Add(ChatBubble)
    End Sub


    Private Sub LoadChats()

        'Clear all chats
        PostsPanel.Controls.Clear()
        Dim query As String = "SELECT rs.post_id, rs.uid, users.name, rs.time_stamp, rs.msg
                        FROM ride_sharing_chats rs
                        JOIN users ON users.user_id = rs.uid
                        WHERE rs.req_id = " & req_id.ToString() & ";"
        Using connection As New MySqlConnection(Globals.getdbConnectionString())
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                ' Execute the command
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Read each row
                    While reader.Read()
                        ' Access columns by name or index
                        Dim postuid As Integer = Convert.ToInt32(reader("uid"))
                        Dim role As Boolean = If(uid = postuid, False, True)
                        Dim userName As String = reader("name").ToString()
                        Dim timeStamp As String = Convert.ToDateTime(reader("time_stamp")).ToString("dd MMM yy, hh:mm tt") 'Like 12 March 24,08:45PM
                        Dim message As String = reader("msg").ToString()
                        Dim postNum As Integer = Convert.ToInt32(reader("post_id"))

                        'Add Chat
                        AddChat(userName, postNum, timeStamp, message, Nothing, role) 'role = 0 for sender, 1 for receiver
                    End While

                End Using
            End Using
        End Using
    End Sub



    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Check if the current cell belongs to the "fee_paid" column and the value is 0
        If e.ColumnIndex = DataGridView1.Columns("Column2").Index AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "True" Then
            ' Set the cell value to "Paid"
            e.Value = "Yes"
        ElseIf e.ColumnIndex = DataGridView1.Columns("Column2").Index AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() <> "True" Then
            ' Set the cell value to "Not Paid"
            e.Value = "No"
        End If
    End Sub
    Private Sub LoadandBindDataGridView()
        'Get connection from globals
        Dim Con = Globals.GetDBConnection()
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim query As String = "SELECT DISTINCT rcu.uid, users.name, rcu.fee_paid, rcu.status, rcu.role " &
                      "FROM ride_sharing_chats rs " &
                      "JOIN ridesharing_chats_users rcu ON rs.req_id = rcu.req_id " &
                      "JOIN users ON users.user_id = rcu.uid " &
                      "WHERE rs.req_id = " & req_id & " AND rcu.role = 1;"
        cmd = New MySqlCommand(query, Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "name"
        DataGridView1.Columns(1).DataPropertyName = "fee_paid"
        DataGridView1.Columns(2).DataPropertyName = "status"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable

        ' Loop through the rows to set Tag to uid from SQL command
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Tag = dataTable.Rows(i)("uid").ToString()
        Next
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'For requester, show the approve button
        If poster_uid <> uid Then
            Button3.Visible = False
            Button1.Visible = True
            ' For the poster of the post
        Else
            Button3.Visible = True
            Button1.Visible = False
        End If

        'Load the more details 
        'TODO: Picture and vehicle type from sql query
        Label2.Text = VehicleNumber
        RichTextBox2.Text = DriverNote

        'Load the Ride List Datagridview
        LoadandBindDataGridView()


        ' Load Chats
        LoadChats()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Set the dialog box to be always on top
        Dim dialogBox As New Transport_EnterFee With {
            .TopMost = True
        }

        ' Show the dialog box
        Dim result As DialogResult = dialogBox.ShowDialog()

        ' Process the result if needed
        If result = DialogResult.OK Then

            Dim query As String = "UPDATE ride_sharing_entries SET fare_per_person =" & dialogBox.NumericUpDown1.Value & " WHERE req_id=" & req_id & ";"
            If Globals.ExecuteUpdateQuery(query) Then
                MsgBox("Fare per person Is updated to ₹" & dialogBox.NumericUpDown1.Value)
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim comment As String = RichTextBox1.Text
        RichTextBox1.Clear()
        Dim role As Boolean = (poster_uid = uid)
        Dim currentTimestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss")
        Dim query As String = "INSERT INTO ride_sharing_chats (req_id,uid,msg,time_stamp,role) VALUES (" & req_id & "," & uid & ",'" & comment & "','" & currentTimestamp & "'," & If(role, 0, 1) & ");"
        If Globals.ExecuteInsertQuery(query) Then
            LoadChats()
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        LoadChats()
        LoadandBindDataGridView()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Pay or withdraw fees
        If Button1.Text = "Pay" Then
            Dim query As String = "UPDATE ride_sharing_chats SET fee_paid = 1 WHERE req_id = " & req_id & " AND uid = " & uid & ";"
            If Globals.ExecuteUpdateQuery(query) Then
                MsgBox("Fee Paid Successfully")
                LoadandBindDataGridView()
                Button1.Text = "Withdraw"
            End If
        Else
            Dim query As String = "UPDATE ride_sharing_chats SET fee_paid = 0 WHERE req_id = " & req_id & " AND uid = " & uid & ";"
            If Globals.ExecuteUpdateQuery(query) Then
                MsgBox("Fee Payment Withdrawn")
                LoadandBindDataGridView()
                Button1.Text = "Pay"
            End If
        End If
    End Sub
End Class