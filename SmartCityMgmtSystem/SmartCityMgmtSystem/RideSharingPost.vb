Public Class RideSharingPost
    Private VehicleNumber As String = "AS-01-2022"
    Private DriverNote As String = ""
    Private uid As Integer = 1
    Private u_name As String = "Dhanesh"
    Private rs_entry As String = 1
    Private uid_poster As Integer = 1
    Private rs_capacity As Integer = 1
    Public Sub SetDetails(name As String,
                           Optional datetime As String = "",
                           Optional fromPlace As String = "",
                           Optional toPlace As String = "",
                           Optional fare As Integer = 0,
                           Optional capacity As Integer = 0,
                          Optional image As Image = Nothing)
        ' Set the labels
        lblname.Text = "       " & name
        lbldt.Text = "       " & datetime
        lblfrom.Text = fromPlace
        lblto.Text = toPlace
        lblfare.Text = "       ₹" & fare
        lblcapacity.Text = "       " & capacity
        rs_capacity = capacity

        ' Set the picture box
        If image IsNot Nothing Then
            picbox.Image = image
        End If
    End Sub
    'Set Auxillary details for the second ride sharing modal
    Public Sub SetAuxillaryDetails(_uid As Integer, poster_uid As Integer, uname As String, rs_id As String, vehicleNum As String, Optional note As String = "")
        rs_entry = rs_id
        VehicleNumber = vehicleNum
        DriverNote = note
        uid = _uid
        uid_poster = poster_uid
        u_name = uname

    End Sub
    'To open the chats for that
    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim modal As New Form
        Try
            Dim chatForm As New RideSharingChats
            modal.StartPosition = FormStartPosition.Manual
            modal.Opacity = 0.4D
            modal.TopMost = True
            modal.ShowInTaskbar = False
            modal.Location = TransportationDashboard.Location
            modal.FormBorderStyle = FormBorderStyle.None
            modal.BackColor = Color.Black
            modal.Width = TransportationDashboard.Width
            modal.Height = TransportationDashboard.Height
            modal.WindowState = FormWindowState.Maximized
            modal.Show()
            modal.Owner = chatForm
            'Pass the required details to the RideSharingChats Form
            RideSharingChats.uid = uid
            RideSharingChats.capacity = rs_capacity
            RideSharingChats.u_name = u_name
            RideSharingChats.req_id = rs_entry
            RideSharingChats.poster_uid = uid_poster
            RideSharingChats.DriverNote = DriverNote
            RideSharingChats.VehicleNumber = VehicleNumber
            RideSharingChats.ShowDialog()

        Catch ex As Exception
        Finally
            modal.Dispose()
        End Try

    End Sub
End Class
