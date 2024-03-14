Imports System.Data.SqlClient
Public Class TransportationAdminHome



    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub


    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        'View the TransportAddSecys screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAddSecys)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportationBusSchedulesAdmin)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportationManageFastagAdmin)
    End Sub
End Class