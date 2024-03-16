Public Class BankingLogin

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim createAccountForm As New BankingCreateAccount()

        ' Show the bankingCreateAccount form
        createAccountForm.Show()

        ' Optionally, hide Form1 if you want to navigate away from it
        Me.Hide()
    End Sub
End Class
