Public Class Ed_Institute_AdminDashboard
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_Institute_AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.viewChildForm(childformPanel, Ed_InstAdmin_AdmitList)
    End Sub
End Class
