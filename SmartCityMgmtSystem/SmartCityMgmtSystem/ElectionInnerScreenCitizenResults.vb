Imports System.Data.SqlClient
Public Class ElectionInnerScreenCitizenResults
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row0 As New DataGridViewRow()
        DataGridView1.Rows.Add(row0)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(0).Cells("Column1").Value = "Employment"
        DataGridView1.Rows(0).Cells("Column2").Value = "Neha Sharma"

        Dim row1 As New DataGridViewRow()
        DataGridView1.Rows.Add(row1)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(1).Cells("Column1").Value = "Education"
        DataGridView1.Rows(1).Cells("Column2").Value = "Rajesh Patel"

        Dim row2 As New DataGridViewRow()
        DataGridView1.Rows.Add(row2)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(2).Cells("Column1").Value = "Health"
        DataGridView1.Rows(2).Cells("Column2").Value = "Priya Singh"

        Dim row3 As New DataGridViewRow()
        DataGridView1.Rows.Add(row3)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(3).Cells("Column1").Value = "Transport"
        DataGridView1.Rows(3).Cells("Column2").Value = "Arjun Kumar"

        Dim row4 As New DataGridViewRow()
        DataGridView1.Rows.Add(row4)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(4).Cells("Column1").Value = "Culture"
        DataGridView1.Rows(4).Cells("Column2").Value = "Pooja Mehta"

        Dim row5 As New DataGridViewRow()
        DataGridView1.Rows.Add(row5)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(5).Cells("Column1").Value = "Power"
        DataGridView1.Rows(5).Cells("Column2").Value = "Sanjay Gupta"

        Dim row6 As New DataGridViewRow()
        DataGridView1.Rows.Add(row6)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(6).Cells("Column1").Value = "Finance"
        DataGridView1.Rows(6).Cells("Column2").Value = "Anjali Dubey"

        Dim row7 As New DataGridViewRow()
        DataGridView1.Rows.Add(row7)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(7).Cells("Column1").Value = "Broadcasting"
        DataGridView1.Rows(7).Cells("Column2").Value = "Vikram Chauhan"

        Dim row8 As New DataGridViewRow()
        DataGridView1.Rows.Add(row8)

        ' Set values for the first three columns in the current row
        DataGridView1.Rows(8).Cells("Column1").Value = "IT"
        DataGridView1.Rows(8).Cells("Column2").Value = "Ritu Verma"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreen1)
    End Sub
End Class