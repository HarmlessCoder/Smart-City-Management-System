Imports System.ComponentModel.DataAnnotations

Public Class Events_vendorLoginInnerScreen

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dummy Data, Change it to LoadandBindDataGridView() 
        For i As Integer = 1 To 8
            ' Add an empty row to the DataGridView
            Dim row As New DataGridViewRow()
            DataGridView1.Rows.Add(row)

            ' Set values for the first three columns in the current row
            DataGridView1.Rows(i - 1).Cells("SlNo").Value = i
            DataGridView1.Rows(i - 1).Cells("CustomerID").Value = i * 1000
            DataGridView1.Rows(i - 1).Cells("TransactionID").Value = 3 * i + 4 * (i) * (i)

            ' Set timestamp for the "Time" column in the current row
            Dim currentTime As DateTime = DateTime.Now.AddHours(i * 37) ' Add 37 hours for each row
            DataGridView1.Rows(i - 1).Cells("Time").Value = currentTime
        Next

        ' Add a button column for "Invoice"
        Dim invoiceButtonColumn As New DataGridViewButtonColumn()
        invoiceButtonColumn.HeaderText = "Invoice"
        invoiceButtonColumn.Text = "Show"
        invoiceButtonColumn.Name = "Invoice"
        invoiceButtonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(invoiceButtonColumn)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "Invoice" column and the clicked item is a button
        If e.ColumnIndex = DataGridView1.Columns("Invoice").Index AndAlso e.RowIndex >= 0 Then
            ' Handle button click for the "Invoice" column
            ' Here you can write code to handle what happens when the button is clicked
            MessageBox.Show("Invoice button clicked for row " & (e.RowIndex + 1))
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
