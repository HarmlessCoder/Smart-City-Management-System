Public Class UserLogin

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Globals.viewChildForm(childformPanel, UserSignUpPage)
        Dim sign = New UserSignUp()
        sign.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim home = New HomePageDashboard()
        home.Show()
        Me.Hide()
    End Sub

End Class
