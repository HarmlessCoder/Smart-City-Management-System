Imports System.Data.SqlClient
Public Class RideSharingMain


    Private Sub LoadandBindDataGridView()
        'Get connection String from globals
        Dim conString = Globals.getdbConnectionString()
        Dim Con = New SqlConnection(conString)

        'Query for SQL table
        Dim query = "enter your query"
        Con.Open()

        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)

        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        adapter.Fill(dataTable)

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "Column in SQL table"
        DataGridView1.Columns(1).DataPropertyName = "Column Name in SQL table"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub AddPost(name As String,
                        Optional datetime As String = "",
                        Optional fromPlace As String = "",
                        Optional toPlace As String = "",
                        Optional fare As Integer = 0,
                        Optional capacity As Integer = 0,
                        Optional postNum As Integer = 0,
                        Optional image As Image = Nothing)
        Dim RidePost As RideSharingPost
        RidePost = New RideSharingPost()
        With RidePost
            .Name = "post_" & postNum
            .Width = 595
            .Height = 120
        End With
        RidePost.SetDetails(name, datetime, fromPlace, toPlace, fare, capacity, image)
        PostsPanel.Controls.Add(RidePost)
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddPost("Dhanesh", "21st March, 6:30PM", "IIT", "Airport", 50, 3, 1, Nothing)
        AddPost("Sanjana", "22st March, 6:30PM", "Airport", "Brahmaputra", 50, 3, 2, Nothing)
        AddPost("Shivam Gupta", "1st April, 8:30AM", "Pan Bazaar", "Kamakhya", 25, 7, 3, Nothing)

        ' Dummy Data, Change it to LoadandBindDataGridView() 
        For i As Integer = 1 To 4
            ' Add an empty row to the DataGridView
            Dim row As New DataGridViewRow()
            DataGridView1.Rows.Add(row)

            ' Set values for the first three columns in the current row
            DataGridView1.Rows(i - 1).Cells("Column1").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column2").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column3").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column4").Value = "Approved"
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub
End Class