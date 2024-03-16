Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles eventID.Click

    End Sub

    Private Sub bank_Click(sender As Object, e As EventArgs) Handles bank.Click

    End Sub

    Private Sub tax_Click(sender As Object, e As EventArgs) Handles tax.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As New DataGridViewRow()
        DataGridView1.Rows.Add(row)

        DataGridView1.Rows(0).Cells("TRANSACTIONID").Value = 902749224
        DataGridView1.Rows(0).Cells("RATE").Value = 1024
        DataGridView1.Rows(0).Cells("DAYS").Value = 4
        DataGridView1.Rows(0).Cells("AMOUNT").Value = 4096
    End Sub
End Class
