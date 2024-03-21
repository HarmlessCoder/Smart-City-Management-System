Imports System.Data.SqlClient
Public Class ElectionInnerScreen1
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenVoter)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionCitizenKYC)
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionCitizenResults)
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionCitizenTimeline)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionVoterNominate)
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCastVote)
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenPastElections)
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenCoC)
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenViolation)
    End Sub

End Class