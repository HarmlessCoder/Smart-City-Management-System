Public Class BankingLogin

    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(childformPanel, TransportationAdminHome)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class
