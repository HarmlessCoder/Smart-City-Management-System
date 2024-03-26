Public Class HomePageDashboard

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildFormAndClose(childformPanel, HomePage, Me)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(childformPanel, UserProfilePage)
    End Sub
End Class
