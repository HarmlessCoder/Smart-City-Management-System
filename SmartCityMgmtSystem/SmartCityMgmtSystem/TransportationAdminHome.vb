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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportFRAdmin)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAdminDLReq)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAdminVRReq)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAdminTGLog)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAdminRSReq)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportMangeBusStopAdmin)
    End Sub
End Class