Imports System.Configuration
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class RideSharingChats
    'To pass information from the parent form in form of property
    Public Property uid As Integer = 1
    Public Property u_name As String = "Dhanesh"
    Public Property poster_uid As Integer = 1     'UID of the poster of this post
    Public Property req_id As Integer = 1
    Public DriverNote As String = ""
    Public VehicleNumber As String = ""

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Check if the clicked cell is in the "EditBut" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index AndAlso e.RowIndex >= 0 Then
            ' Change this to DB logic later
            MessageBox.Show("Edit button clicked for row " & e.RowIndex.ToString(), "Edit Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Check if the clicked cell is in the "DeleteBut" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "DeleteButton" column
            MessageBox.Show("Delete button clicked for row " & e.RowIndex.ToString(), "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        Dim query As String = "SELECT rs.post_id,rs.role,users.name, rs.time_stamp,rs.msg, FROM ride_sharing_chats rs JOIN users ON users.user_id = rs.uid WHERE rs.req_id= " & req_id.ToString() & ";"
        Using connection As New MySqlConnection(Globals.getdbConnectionString())
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                ' Execute the command
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Read each row
                    While reader.Read()
                        ' Access columns by name or index
                        Dim role As Boolean = Convert.ToBoolean(reader("role"))
                        Dim userName As String = reader("name").ToString()
                        Dim timeStamp As String = Convert.ToDateTime(reader("time_stamp")).ToString("dd MMM yy, hh:mm tt") 'Like 12 March 24,08:45PM
                        Dim message As String = reader("msg").ToString()
                        Dim postNum As Integer = Convert.ToInt32(reader("post_id"))
                        'Add to PostsPanel
                        AddChat(userName, postNum, timeStamp, message, Nothing, role) 'role = 0 for who posted it, 1 for who requests for it
                    End While

                End Using
            End Using
        End Using
    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Check if the current cell belongs to the "fee_paid" column and the value is 0
        If e.ColumnIndex = DataGridView1.Columns("Colum2").Index AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
            ' Set the cell value to "Paid"
            e.Value = "Yes"
        ElseIf e.ColumnIndex = DataGridView1.Columns("Column2").Index AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() <> "0" Then
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
        cmd = New MySqlCommand("SELECT rs.uid,users.name,rs.fee_paid,rs.status FROM ride_sharing_chats rs JOIN users ON users.user_id = rs.uid WHERE rs.role = 1 AND rs.req_id = " & req_id & ";", Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "uid"
        DataGridView1.Columns(1).DataPropertyName = "name"
        DataGridView1.Columns(2).DataPropertyName = "fee_paid"
        'Show this column only for the person who the poster
        If poster_uid = uid Then
            DataGridView1.Columns(4).DataPropertyName = "status"
        End If

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '
        If poster_uid <> uid Then
            DataGridView1.Columns("Approve").Visible = True
        Else
            DataGridView1.Columns("Approve").Visible = False
        End If

        ' Dummy Data, Change it to LoadandBindDataGridView() 
        AddChat(u_name, 1, "13th March, 9:30PM", "Hey guys, pay the fee and then I will approve your requests", Nothing, False)
        AddChat("Shivam", 2, "13th March, 9:35PM", "Okay, But the fare is bit more, can you like reduce it please?", Nothing, True)
        AddChat("Adarsh", 3, "13th March, 9:36PM", "Yes,same concern", Nothing, True)
        AddChat(u_name, 4, "13th March, 9:40PM", "No, I can't do that, I have to pay the petrol fare", Nothing, False)
        AddChat("Shivam", 5, "13th March, 9:45PM", "Okay, I will pay the fare", Nothing, True)
        AddChat("Dhanesh", 6, "13th March, 9:46PM", "Okay, I will approve your request", Nothing, False)
        AddChat("Adarsh", 7, "13th March, 9:50PM", "Fine,But I have no more choice.", Nothing, True)
        AddChat(u_name, 8, "13th March, 9:55PM", "Okay, I will approve your request", Nothing, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class