Imports System.Data.SqlClient
Public Class Ed_Stud_MyCourses
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1_Click(sender, e)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FlowLayoutPanel1.Controls.Clear()
        Button1.BackColor = Color.FromArgb(88, 133, 175)
        Button2.BackColor = Color.FromArgb(40, 68, 114)
        Dim labels As Ed_CourseProgress() = New Ed_CourseProgress(21) {}

        ' Create labels and set properties
        For i As Integer = 0 To 20
            labels(i) = New Ed_CourseProgress()
            labels(i).CourseID = i
            labels(i).ProgressBar1.Value = i * 5
        Next

        ' Add labels to the FlowLayoutPanel
        For Each Ed_CourseProgress As Ed_CourseProgress In labels
            FlowLayoutPanel1.Controls.Add(Ed_CourseProgress)
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FlowLayoutPanel1.Controls.Clear()
        Button2.BackColor = Color.FromArgb(88, 133, 175)
        Button1.BackColor = Color.FromArgb(40, 68, 114)
        Dim labels As Ed_CourseProgress() = New Ed_CourseProgress(21) {}

        ' Create labels and set properties
        For i As Integer = 0 To 20
            labels(i) = New Ed_CourseProgress()
            labels(i).CourseID = i
            labels(i).ProgressBar1.Value = labels(i).ProgressBar1.Maximum
            labels(i).Label2.Text = "Completed"
        Next

        ' Add labels to the FlowLayoutPanel
        For Each Ed_CourseProgress As Ed_CourseProgress In labels
            FlowLayoutPanel1.Controls.Add(Ed_CourseProgress)
        Next
    End Sub
End Class