Imports System.Data.SqlClient
Public Class ElectionInnerScreen1
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenVoter)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenVoterNominate)
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitzenKYC)
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenTimeline)
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenCastVote)
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenResults)
    End Sub

End Class