Imports System.Data.SqlClient
Public Class ElectionInnerScreenAdminNomination
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rowIndex As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows(rowIndex).Cells(0).Value = "1"
        DataGridView1.Rows(rowIndex).Cells(1).Value = "121"
        DataGridView1.Rows(rowIndex).Cells(2).Value = "Neha Sharma"
        DataGridView1.Rows(rowIndex).Cells(3).Value = "Power Minister"
        DataGridView1.Rows(rowIndex).Cells(4).Value = "Implementing renewable energy initiatives to reduce reliance on fossil fuels and promote sustainability. Modernizing and upgrading existing power infrastructure to ensure reliable and efficient electricity supply for all citizens.Text value"
        DataGridView1.Rows(rowIndex).Cells(5).Value = "No"
        DataGridView1.Rows(rowIndex).Cells(6).Value = "Pending"


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class