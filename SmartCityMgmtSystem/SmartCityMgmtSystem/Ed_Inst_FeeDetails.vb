Imports System.Data.SqlClient
Public Class Ed_Inst_FeeDetails
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust other properties as needed
        DataGridView1.Rows.Add("Fee", "Semester 1", 2500, "$1000", "2023-01-15", "Pay")
        DataGridView1.Rows.Add("Fee", "Semester 1", 2501, "$50", "2023-01-18", "View")
        DataGridView1.Rows.Add("Refund", "Semester 2", 2502, "$200", "2023-02-10", "Pay")
        DataGridView1.Rows.Add("Refund", "Semester 2", 2503, "$150", "2023-02-15", "View")
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is valid and is a button cell
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso TypeOf DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex) Is DataGridViewButtonCell Then
            ' Check if the column index corresponds to the "Action" column
            Dim columnIndex As Integer = DataGridView1.Columns("Column6").Index
            If columnIndex >= 0 AndAlso e.ColumnIndex = columnIndex Then
                ' Get the value of the clicked cell
                Dim action As String = DataGridView1.Rows(e.RowIndex).Cells(columnIndex).Value.ToString()

                ' Open respective forms based on the action value
                If action = "Pay" Then
                    ' Open the form for Pay action
                    Dim payForm As New Ed_FeePopup()
                    payForm.ShowDialog() ' Show as dialog if needed
                ElseIf action = "View" Then
                    ' Open the form for View action
                    Dim viewForm As New Ed_ViewPaymentPopup()
                    viewForm.ShowDialog() ' Show as dialog if needed
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

End Class