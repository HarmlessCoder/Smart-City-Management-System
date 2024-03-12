Public Class RideSharingPost
    Public Sub SetDetails(name As String,
                           Optional datetime As String = "",
                           Optional fromPlace As String = "",
                           Optional toPlace As String = "",
                           Optional fare As Integer = 0,
                           Optional capacity As Integer = 0,
                          Optional image As Image = Nothing)
        ' Set the labels
        lblname.Text = "       " & name
        lbldt.Text = "       " & datetime
        lblfrom.Text = "      " & fromPlace
        lblto.Text = "      " & toPlace
        lblfare.Text = "       ₹" & fare
        lblcapacity.Text = "       " & capacity

        ' Set the picture box
        If image IsNot Nothing Then
            picbox.Image = image
        End If
    End Sub

End Class
