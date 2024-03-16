Public Class FastagPurchase
    Public Sub SetDetails(vehnum As String,
                           Optional drvlicensenum As String = "12345",
                          Optional dt As String = "21st March 2024",
                           Optional fare As Integer = 0)
        ' Set the labels
        lblvehno.Text = "       " & vehnum
        lbldrv.Text = "     " & drvlicensenum
        lbldt.Text = "       " & dt
        lblfare.Text = "       ₹" & fare
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click


    End Sub
End Class
