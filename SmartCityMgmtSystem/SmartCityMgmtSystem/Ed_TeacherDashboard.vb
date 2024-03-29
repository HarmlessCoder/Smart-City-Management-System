Public Class Ed_TeacherDashboard
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_RoleSelect)
    End Sub

    Private Sub Ed_TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, Ed_ManageECourse)
    End Sub
End Class
