Imports System.Data.SqlClient
Public Class TransportAdminVRReq

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "Column5" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("Column5").Index AndAlso e.RowIndex >= 0 Then
            ' Change this to DB logic later
            MessageBox.Show("Invoice PDF will be fetched." & e.RowIndex.ToString(), "Invoice pdf", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Check if the clicked cell is in the "Column6" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("Column6").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "Column6" column
            MessageBox.Show("Accept button clicked for row " & e.RowIndex.ToString(), "Accept ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Check if the clicked cell is in the "Column7" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("Column7").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "Column7" column
            MessageBox.Show("Reject button clicked for row " & e.RowIndex.ToString(), "Reject ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

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

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dummy Data, Change it to LoadandBindDataGridView() 
        For i As Integer = 1 To 8
            ' Add an empty row to the DataGridView
            Dim row As New DataGridViewRow()
            DataGridView1.Rows.Add(row)

            ' Set values for the first three columns in the current row
            DataGridView1.Rows(i - 1).Cells("Column1").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column2").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column3").Value = "DummyVal"
            DataGridView1.Rows(i - 1).Cells("Column4").Value = "DummyVal"

        Next
    End Sub

End Class