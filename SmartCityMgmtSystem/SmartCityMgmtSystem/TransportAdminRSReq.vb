Imports System.Data.SqlClient
Public Class TransportAdminRSReq



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


    End Sub

    Private Sub AddPost(dname As String,
                          Optional pname As String = "",
                          Optional vehid As String = "",
                           Optional datetime As String = "",
                           Optional fromPlace As String = "",
                           Optional toPlace As String = "",
                           Optional dlid As String = "",
                           Optional capacity As Integer = 0,
                          Optional postNum As Integer = 0,
                          Optional image As Image = Nothing)
        Dim RidePost As TransportRSReqPost
        RidePost = New TransportRSReqPost()
        With RidePost
            .Name = "post_" & postNum
            .Width = 595
            .Height = 210
        End With
        RidePost.SetDetails(dname, pname, vehid, datetime, fromPlace, toPlace, dlid, capacity, image)
        PostsPanel.Controls.Add(RidePost)
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddPost("DummyVal", "DummyVal", "DummyVal", "21st March, 6:30PM", "IIT", "Airport", "DummyVal", 3, Nothing)
        AddPost("DummyVal", "DummyVal", "DummyVal", "21st March, 6:30PM", "IIT", "Airport", "DummyVal", 7, Nothing)
        AddPost("DummyVal", "DummyVal", "DummyVal", "21st March, 6:30PM", "IIT", "Airport", "DummyVal", 2, Nothing)
        AddPost("DummyVal", "DummyVal", "DummyVal", "21st March, 6:30PM", "IIT", "Airport", "DummyVal", 2, Nothing)

    End Sub


End Class