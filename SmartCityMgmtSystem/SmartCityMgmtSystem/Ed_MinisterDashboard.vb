Public Class Ed_MinisterDashboard
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_MinisterDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, New Ed_Institute_List())
    End Sub
End Class
