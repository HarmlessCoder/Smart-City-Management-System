Imports System.Data.SqlClient
Public Class Ed_Inst_FeeDetails
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust other properties as needed
        DataGridView1.Rows.Add("Fee", "Semester 1", 2500, "$1000", "2023-01-15", "Pay")
        DataGridView1.Rows.Add("Fee", "Semester 1", 2501, "$50", "2023-01-18", "View")
        DataGridView1.Rows.Add("Refund", "Semester 2", 2502, "$200", "2023-02-10", "Pay")
        DataGridView1.Rows.Add("Refund", "Semester 2", 2503, "$150", "2023-02-15", "View")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class