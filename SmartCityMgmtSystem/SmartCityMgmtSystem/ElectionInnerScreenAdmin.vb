Imports System.Data.SqlClient
Public Class ElectionInnerScreenAdmin

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdminNomination)
    End Sub

End Class