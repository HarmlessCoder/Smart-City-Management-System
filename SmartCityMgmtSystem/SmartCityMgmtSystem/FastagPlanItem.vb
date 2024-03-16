Public Class FastagPlanItem
    Public Sub SetDetails(vehtype As String,
                           Optional validity As String = "Valid for 3 months",
                           Optional fare As Integer = 0)
        ' Set the labels
        lblvehtype.Text = "       " & vehtype
        lblvalidity.Text = "       " & validity
        lblfare.Text = "       ₹" & fare
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click


    End Sub
End Class
