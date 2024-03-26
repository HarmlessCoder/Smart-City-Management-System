Public Class Ed_CourseProgress
    Public CourseID As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, New Ed_Coursera_CourseContent(CourseID, Ed_GlobalDashboard.innerpanel))
    End Sub
End Class
