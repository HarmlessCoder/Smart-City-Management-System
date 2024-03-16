Imports System.ComponentModel

Public Class pictureButtonvb
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
#Region "Properties"

    Private _title As String
    Private _message As String
    Private _icon As Image

    <Category("Custom Props")>
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            Label3.Text = value
        End Set
    End Property

    <Category("Custom Props")>
    Public Property Icon As Image
        Get
            Return _icon
        End Get
        Set(value As Image)
            _icon = value
            PictureBox1.BackgroundImage= value
        End Set
    End Property

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

#End Region


End Class
