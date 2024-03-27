Public Class TransportationDashboard
    'To be passed from Login Dashboard
    Public Property uid As Integer = 1
    Public Property u_name As String = "Dhanesh"
    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(childformPanel, TransportationAdminHome)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'View the Cab Sharing Screen
        'Pass the deatils of the user to the RideSharingMain form
        Dim RideSharingMainForm As New RideSharingMain
        RideSharingMainForm.uid = uid
        RideSharingMainForm.u_name = u_name
        Globals.viewChildForm(childformPanel, RideSharingMainForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'View the Bus Schedule Screen
        Globals.viewChildForm(childformPanel, TransportBusSchedule)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'View the Toll Plaza Screen
        Globals.viewChildForm(childformPanel, TransportTollPlaza)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'View DL req form
        Globals.viewChildForm(childformPanel, TransportDrivingLicenseReq)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'View Veh Reg Form
        Globals.viewChildForm(childformPanel, TransportVehicleRegReq)
    End Sub
End Class
