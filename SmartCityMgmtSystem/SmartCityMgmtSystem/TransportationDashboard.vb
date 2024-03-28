Public Class TransportationDashboard
    'To be passed from Login Dashboard
    Public Property uid As Integer = 1
    Public Property u_name As String = "Dhanesh"
    Private rideSharingMainForm As RideSharingMain = Nothing
    Private transportationAdminHome As TransportationAdminHome = Nothing
    Private transportBusSchedule As TransportBusSchedule = Nothing
    Private transportTollPlaza As TransportTollPlaza = Nothing
    Private transportdrivingLicenseReq As TransportDrivingLicenseReq = Nothing
    Private transportVehicleRegReq As TransportVehicleRegReq = Nothing

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        transportationAdminHome?.Dispose()
        transportationAdminHome = New TransportationAdminHome()
        Globals.viewChildForm(childformPanel, transportationAdminHome)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'View the Cab Sharing Screen
        ' Check if the form is already open
        rideSharingMainForm?.Dispose()

        ' Create a new instance of the form
        rideSharingMainForm = New RideSharingMain With {
            .uid = uid,
            .u_name = u_name
        }
        Globals.viewChildForm(childformPanel, RideSharingMainForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'View the Bus Schedule Screen
        transportBusSchedule?.Dispose()
        transportBusSchedule = New TransportBusSchedule()
        Globals.viewChildForm(childformPanel, transportBusSchedule)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'View the Toll Plaza Screen
        transportTollPlaza?.Dispose()
        transportTollPlaza = New TransportTollPlaza()
        Globals.viewChildForm(childformPanel, transportTollPlaza)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'View DL req form
        transportdrivingLicenseReq?.Dispose()
        transportdrivingLicenseReq = New TransportDrivingLicenseReq()
        Globals.viewChildForm(childformPanel, transportdrivingLicenseReq)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'View Veh Reg Form
        transportVehicleRegReq?.Dispose()
        transportVehicleRegReq = New TransportVehicleRegReq()
        Globals.viewChildForm(childformPanel, transportVehicleRegReq)
    End Sub

    Private Sub TransportationDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Dispose all the child forms when the parent form is closed
        transportationAdminHome?.Dispose()
        transportBusSchedule?.Dispose()
        transportTollPlaza?.Dispose()
        transportdrivingLicenseReq?.Dispose()
        transportVehicleRegReq?.Dispose()
        rideSharingMainForm?.Dispose()
    End Sub
End Class
