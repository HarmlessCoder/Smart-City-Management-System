Public Class Ed_RoleSelect
    Private Sub Ed_RoleSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub pictureButtonvb1_Click(sender As Object, e As EventArgs) Handles PictureButtonvb1.Click
        ' Handle the Click event of the user control
        Ed_GlobalDashboard.innerpanel = Ed_StudentDashboard.childformPanel
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_StudentDashboard)
    End Sub

    Private Sub pictureButtonvb1_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb1.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb1.BackColor = Color.White
    End Sub

    Private Sub pictureButtonvb1_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb1.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb1.BackColor = Color.FromArgb(196, 224, 229)
    End Sub
    Private Sub pictureButtonvb2_Click(sender As Object, e As EventArgs) Handles PictureButtonvb2.Click
        ' Handle the Click event of the user control
        Ed_GlobalDashboard.innerpanel = Ed_TeacherDashboard.childformPanel
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_TeacherDashboard)
    End Sub

    Private Sub pictureButtonvb2_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb2.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb2.BackColor = Color.White
    End Sub

    Private Sub pictureButtonvb2_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb2.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb2.BackColor = Color.FromArgb(196, 224, 229)
    End Sub
    Private Sub pictureButtonvb3_Click(sender As Object, e As EventArgs) Handles PictureButtonvb3.Click
        ' Handle the Click event of the user control
        Ed_GlobalDashboard.innerpanel = Ed_Institute_AdminDashboard.childformPanel
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_Institute_AdminDashboard)
    End Sub

    Private Sub pictureButtonvb3_Hover(sender As Object, e As EventArgs) Handles PictureButtonvb3.Hover
        ' Handle the Hover event of the user control
        PictureButtonvb3.BackColor = Color.White
    End Sub

    Private Sub pictureButtonvb3_Leave(sender As Object, e As EventArgs) Handles PictureButtonvb3.Leave
        ' Handle the Leave event of the user control
        PictureButtonvb3.BackColor = Color.FromArgb(196, 224, 229)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.Close()
        Me.Close()
        Dim homepage = New HomePageDashboard
        homepage.Show()
    End Sub
End Class
