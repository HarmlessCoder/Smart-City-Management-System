Imports System.Data.SqlClient
Public Class ElectionInnerScreenAdminNomination
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.Frozen = False
        Next

        DataGridView1.RowTemplate.Height = 300
        DataGridView1.ScrollBars = ScrollBars.Both

        Dim rowIndex As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows(rowIndex).Cells(0).Value = "1"
        DataGridView1.Rows(rowIndex).Cells(1).Value = "121"
        DataGridView1.Rows(rowIndex).Cells(2).Value = "Neha Sharma"
        DataGridView1.Rows(rowIndex).Cells(3).Value = "Power Minister"
        DataGridView1.Rows(rowIndex).Cells(4).Value = "Implementing renewable energy initiatives to reduce reliance on fossil fuels and promote sustainability. Modernizing and upgrading existing power infrastructure to ensure reliable and efficient electricity supply for all citizens."
        DataGridView1.Rows(rowIndex).Cells(5).Value = "No"
        DataGridView1.Rows(rowIndex).Cells(6).Value = "Pending"

        rowIndex = DataGridView1.Rows.Add()
        DataGridView1.Rows(rowIndex).Cells(0).Value = "2"
        DataGridView1.Rows(rowIndex).Cells(1).Value = "256"
        DataGridView1.Rows(rowIndex).Cells(2).Value = "Rajesh Patel"
        DataGridView1.Rows(rowIndex).Cells(3).Value = "Finance Minister"
        DataGridView1.Rows(rowIndex).Cells(4).Value = "Implementing fiscal policies to stimulate economic growth and job creation while maintaining fiscal discipline. Enhancing financial inclusion and stability through measures to promote investment, manage public debt, and ensure equitable distribution of resources."
        DataGridView1.Rows(rowIndex).Cells(5).Value = "Yes"
        DataGridView1.Rows(rowIndex).Cells(6).Value = "Approved"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdmin)
    End Sub
End Class