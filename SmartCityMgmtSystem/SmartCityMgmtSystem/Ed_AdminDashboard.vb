Public Class Ed_AdminDashboard

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(childformPanel, TransportationAdminHome)
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Ed_GlobalDashboard.OpenFormInGlobalEdPanel(Ed_RoleSelect)
    End Sub
End Class
