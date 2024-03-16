Imports System.Data.SqlClient
Public Class ElectionInnerScreenAdminResults
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
        DataGridView1.Columns(0).DataPropertyName = "Column Name in SQL table"
        DataGridView1.Columns(1).DataPropertyName = "Column Name in SQL table"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 8
            ' Add an empty row to the DataGridView
            Dim row As New DataGridViewRow()
            DataGridView1.Rows.Add(row)

            ' Set values for the first three columns in the current row
            DataGridView1.Rows(i - 1).Cells("Column1").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column2").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column3").Value = "DummyVal"
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdmin)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class