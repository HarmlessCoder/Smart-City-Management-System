Public Class Ed_Stud_Institute
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_Stud_Institute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, New Ed_Institute_List())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_StudentDashboard)
    End Sub
End Class
