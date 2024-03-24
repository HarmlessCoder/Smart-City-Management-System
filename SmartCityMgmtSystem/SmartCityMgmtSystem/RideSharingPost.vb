Public Class RideSharingPost
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

        ' Set the picture box
        If image IsNot Nothing Then
            picbox.Image = image
        End If
    End Sub

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
            modal.Show()
            modal.Owner = chatForm
            RideSharingChats.ShowDialog()

        Catch ex As Exception
        Finally
            modal.Dispose()
        End Try

    End Sub
End Class
