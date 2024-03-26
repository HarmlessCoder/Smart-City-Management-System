Public Class Ed_Stud_Moodle
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_Stud_Moodle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, Ed_Stud_Moodle_JoinCourse)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_StudentDashboard)
    End Sub
End Class
