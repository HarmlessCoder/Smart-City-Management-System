Public Class BankingDashboard

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Globals.viewChildForm(childformPanel, CheckBankBalance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.viewChildForm(childformPanel, ViewBankTransactions)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(childformPanel, PayBills)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Globals.viewChildForm(childformPanel, ReachargeFasttag)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Globals.viewChildForm(childformPanel, UserBankAcountDetails)
    End Sub

    Private Sub childformPanel_Paint(sender As Object, e As PaintEventArgs) Handles childformPanel.Paint

    End Sub
End Class
