Public Class TransportRSReqPost
    Public Sub SetDetails(dname As String,
                          Optional pname As String = "",
                          Optional vehid As String = "",
                           Optional datetime As String = "",
                           Optional fromPlace As String = "",
                           Optional toPlace As String = "",
                           Optional dlid As String = "",
                           Optional capacity As Integer = 0,
                          Optional image As Image = Nothing)
        ' Set the labels
        lbldname.Text = "       " & dname
        lblpname.Text = "       " & pname
        lblvid.Text = "        " & vehid
        lbldt.Text = "       " & datetime
        lblfrom.Text = "      " & fromPlace
        lblto.Text = "      " & toPlace
        lbldlid.Text = "        " & dlid
        lblcapacity.Text = "       " & capacity

        ' Set the picture box
        If image IsNot Nothing Then
            picbox.Image = image
        End If
    End Sub



    Private Sub btnactionaccept_Click(sender As Object, e As EventArgs) Handles btnactionaccept.Click
        MessageBox.Show("ride sharing request will be approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnactionreject_Click(sender As Object, e As EventArgs) Handles btnactionreject.Click
        MessageBox.Show("ride sharing request will be rejected", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
