Imports System.Data.SqlClient
Public Class ElectionInnerScreenAdmin

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminNomination)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminTimeline)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminVotes)
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminResults)
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminRTI)
    End Sub
End Class