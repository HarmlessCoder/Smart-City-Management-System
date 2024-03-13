Public Class ElectionDashboard
    Private Sub election_Click(sender As Object, e As EventArgs) Handles election.Click
        Globals.viewChildForm(childformPanel, ElectionInnerScreen1)
    End Sub

    Private Sub ElectionDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
