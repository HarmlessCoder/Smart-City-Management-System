Imports System.Data.SqlClient
Public Class Ed_InstAdmin_AdmitList
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim labels As Ed_Stud_ListItem() = New Ed_Stud_ListItem(21) {}

        ' Create labels and set properties
        For i As Integer = 0 To 20
            labels(i) = New Ed_Stud_ListItem()
        Next

        ' Add labels to the FlowLayoutPanel
        For Each Ed_Stud_ListItem As Ed_Stud_ListItem In labels
            FlowLayoutPanel1.Controls.Add(Ed_Stud_ListItem)
        Next
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class