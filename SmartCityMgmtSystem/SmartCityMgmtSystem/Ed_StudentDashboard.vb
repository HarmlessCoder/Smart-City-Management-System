Public Class Ed_StudentDashboard
    Private Sub PictureButtonvb1_Click(sender As Object, e As EventArgs) Handles PictureButtonvb1.Click
        ' Replace with your desired functionality
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_Stud_Coursera)
    End Sub

    Private Sub PictureButtonvb1_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb1.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb1.BackColor = Color.White
    End Sub

    Private Sub PictureButtonvb1_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb1.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb1.BackColor = Color.FromArgb(196, 224, 229)
    End Sub

    Private Sub PictureButtonvb2_Click(sender As Object, e As EventArgs) Handles PictureButtonvb2.Click
        ' Replace with your desired functionality
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_Stud_Moodle)
    End Sub

    Private Sub PictureButtonvb2_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb2.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb2.BackColor = Color.White
    End Sub

    Private Sub PictureButtonvb2_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb2.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb2.BackColor = Color.FromArgb(196, 224, 229)
    End Sub

    Private Sub PictureButtonvb3_Click(sender As Object, e As EventArgs) Handles PictureButtonvb3.Click
        ' Replace with your desired functionality
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_Stud_Institute)
    End Sub

    Private Sub PictureButtonvb3_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb3.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb3.BackColor = Color.White
    End Sub

    Private Sub PictureButtonvb3_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb3.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb3.BackColor = Color.FromArgb(196, 224, 229)
    End Sub

    Private Sub PictureButtonvb4_Click(sender As Object, e As EventArgs) Handles PictureButtonvb4.Click
        ' Replace with your desired functionality
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_Stud_EntranceExam)
    End Sub

    Private Sub PictureButtonvb4_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb4.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb4.BackColor = Color.White
    End Sub

    Private Sub PictureButtonvb4_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb4.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb4.BackColor = Color.FromArgb(196, 224, 229)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_RoleSelect)
    End Sub
End Class
