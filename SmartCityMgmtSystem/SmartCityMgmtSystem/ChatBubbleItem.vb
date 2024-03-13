Imports System.Runtime.CompilerServices

Public Class ChatBubbleItem
    Public Sub SetDetails(name As String,
                           Optional datetime As String = "",
                          Optional comment As String = "",
                          Optional image As Image = Nothing,
                          Optional isRider As Boolean = True)
        ' If its not the sender(rider)
        If isRider Then
            Me.BackColor = Color.Linen
            CommentTextBox.BackColor = Color.Linen
            timebox.ForeColor = Color.DimGray
            lblname.ForeColor = Color.Maroon
            CommentTextBox.ForeColor = Color.Black
        End If
        lblname.Text = name
        timebox.Text = datetime
        CommentTextBox.Text = comment
        If image IsNot Nothing Then
            picbox.Image = image
        End If
    End Sub


End Class
