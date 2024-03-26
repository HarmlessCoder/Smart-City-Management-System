Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class ElectionInnerScreenCitizenRTI

    Public Class ProfileClass
        Private _uid As Integer

        ' Public Property declaration
        Public Property UID() As Integer
            Get
                Return _uid
            End Get
            Set(value As Integer)
                _uid = value
            End Set
        End Property

    End Class

    Dim instance As New ProfileClass()

    Dim ministryToId As New Dictionary(Of String, Integer)

    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ministryToId.Add("Employment", 1)
        ministryToId.Add("Education", 2)
        ministryToId.Add("Health", 3)
        ministryToId.Add("Transport", 4)
        ministryToId.Add("Culture", 5)
        ministryToId.Add("Power", 6)
        ministryToId.Add("Finance", 7)
        ministryToId.Add("Broadcasting", 8)
        ministryToId.Add("IT", 9)

        instance.UID = 10 ' Setting the value
        Dim value As Integer = instance.UID ' Getting the value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenRTIPA)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedValue As Object = ComboBox1.SelectedItem

        If selectedValue IsNot Nothing Then
            Dim selectedText As String = selectedValue.ToString()
        Else
            MessageBox.Show("Select the ministry and try again.")
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            MessageBox.Show("Please write your query.")
            Exit Sub
        End If

        'Get connection from globals
        Dim Con = Globals.GetDBConnection()
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Execute query to count rows in election_time table
        cmd = New MySqlCommand("SELECT COUNT(*) FROM rti_queries_table;", Con)
        Dim electionTimeRowCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Dim queryid = electionTimeRowCount + 1

        Dim insertQuery As String = "INSERT INTO rti_queries_table(query_id, citizen_uid, ministry, 
                                    query, status) VALUES(" & queryid & "," & instance.UID & "," & ministryToId(selectedValue.ToString) & ", """ & TextBox1.Text & """, ""Pending"" )"

        Dim inserted As Boolean = Globals.ExecuteInsertQuery(insertQuery)

        If inserted Then
            MessageBox.Show("Successful")
        Else
            MessageBox.Show("Failed to insert a row")
        End If

    End Sub
End Class