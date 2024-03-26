Public Class Ed_Stud_EntranceExam
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_StudentDashboard)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Engineering Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Medical Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Arts Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Commerce Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub PictureButtonvb1_Click(sender As Object, e As EventArgs) Handles PictureButtonvb1.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Engineering Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub PictureButtonvb4_Click(sender As Object, e As EventArgs) Handles PictureButtonvb4.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Medical Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub PictureButtonvb3_Click(sender As Object, e As EventArgs) Handles PictureButtonvb3.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Arts Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub

    Private Sub PictureButtonvb2_Click(sender As Object, e As EventArgs) Handles PictureButtonvb2.Click
        Dim entranceScreen As New Ed_EntranceInnerScreen()
        entranceScreen.labelText = "Commerce Entrance Exam"
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, entranceScreen)
    End Sub
End Class
