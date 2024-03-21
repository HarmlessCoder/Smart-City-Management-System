Imports System.Data.SqlClient
Public Class ElectionCitizenTimeline
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row1 As New DataGridViewRow()
        DataGridView1.Rows.Add(row1)
        DataGridView1.Rows(0).Cells("Column1").Value = "Nomination Start Date"
        DataGridView1.Rows(0).Cells("Column2").Value = "18.03.2024"

        Dim row2 As New DataGridViewRow()
        DataGridView1.Rows.Add(row2)
        DataGridView1.Rows(1).Cells("Column1").Value = "Nomination End Date"
        DataGridView1.Rows(1).Cells("Column2").Value = "20.03.2024"

        Dim row3 As New DataGridViewRow()
        DataGridView1.Rows.Add(row3)
        DataGridView1.Rows(2).Cells("Column1").Value = "Campaigning Start Date"
        DataGridView1.Rows(2).Cells("Column2").Value = "22.03.2024"

        Dim row4 As New DataGridViewRow()
        DataGridView1.Rows.Add(row4)
        DataGridView1.Rows(3).Cells("Column1").Value = "Campaigning End Date"
        DataGridView1.Rows(3).Cells("Column2").Value = "25.03.2024"

        Dim row5 As New DataGridViewRow()
        DataGridView1.Rows.Add(row5)
        DataGridView1.Rows(4).Cells("Column1").Value = "Election Date"
        DataGridView1.Rows(4).Cells("Column2").Value = "27.03.2024"

        Dim row6 As New DataGridViewRow()
        DataGridView1.Rows.Add(row6)
        DataGridView1.Rows(5).Cells("Column1").Value = "Results Announcement Date"
        DataGridView1.Rows(5).Cells("Column2").Value = "30.03.2024"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreen1)
    End Sub
End Class