Public Class Ed_MinisterDashboard
    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub

    Private Sub Ed_MinisterDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ed_list As New Ed_Institute_List(childformPanel)
        ed_list.user_type = "Admin"
        Globals.viewChildForm(childformPanel, ed_list)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ed_list As New Ed_Institute_List(childformPanel)
        ed_list.user_type = "Admin"
        Globals.viewChildForm(childformPanel, ed_list)
    End Sub
End Class
