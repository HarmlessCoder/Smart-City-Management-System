Imports System.Data.SqlClient
Public Class ElectionInnerScreen1
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenVoter)
    End Sub

End Class