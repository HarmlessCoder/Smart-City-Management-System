Public Class TransportationDashboard

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(childformPanel, TransportationAdminHome)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'View the Cab Sharing Screen
        Globals.viewChildForm(childformPanel, RideSharingMain)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'View the Bus Schedule Screen
        Globals.viewChildForm(childformPanel, TransportBusSchedule)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'View the Toll Plaza Screen
        Globals.viewChildForm(childformPanel, TransportTollPlaza)
    End Sub
End Class
