Public Class Ed_Stud_Moodle
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_Stud_Moodle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, Ed_Stud_Moodle_JoinCourse)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_StudentDashboard)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cur_course As New Ed_Moodle_CourseList()
        cur_course.Cur_All = "Current"
        Globals.viewChildForm(childformPanel, cur_course)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim all_course As New Ed_Moodle_CourseList()
        all_course.Cur_All = "All"
        Globals.viewChildForm(childformPanel, all_course)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.viewChildForm(childformPanel, New Ed_Moodle_AssList())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(childformPanel, New Ed_Stud_Moodle_JoinCourse())
    End Sub
End Class
