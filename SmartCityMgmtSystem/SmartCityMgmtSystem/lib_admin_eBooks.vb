Public Class lib_admin_eBooks
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim lib_adminSearch = New lib_adminSearch()
        lib_adminSearch.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim lib_adminBM = New lib_adminBM()
        lib_adminBM.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim lib_adminEBM = New lib_adminEBM()
        lib_adminEBM.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lib_adminBM = New lib_adminBM()
        lib_adminBM.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim lib_adminDash = New lib_adminDash()
        lib_adminDash.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lib_adminSearch = New lib_adminSearch()
        lib_adminSearch.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lib_adminMT = New lib_adminMT()
        lib_adminMT.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim lib_adminReq = New lib_adminReq()
        lib_adminReq.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim HomePageDashboard = New HomePageDashboard()
        HomePageDashboard.Show()
        Me.Close()
    End Sub
End Class