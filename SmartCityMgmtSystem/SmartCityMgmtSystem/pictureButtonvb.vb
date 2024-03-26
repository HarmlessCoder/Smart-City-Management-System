Imports System.ComponentModel
Public Class pictureButtonvb
    Public Event Click As EventHandler
    Public Event Hover As EventHandler
    Public Event Leave As EventHandler

    Private Sub pictureButtonvb_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(Me, EventArgs.Empty)
    End Sub

    Private Sub pictureButtonvb_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        RaiseEvent Hover(Me, EventArgs.Empty)
    End Sub

    Private Sub pictureButtonvb_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        RaiseEvent Leave(Me, EventArgs.Empty)
    End Sub

    ' Event handlers for child controls
    Private Sub ChildControl_Click(sender As Object, e As EventArgs) Handles Label3.Click, PictureBox1.Click
        RaiseEvent Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ChildControl_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter, PictureBox1.MouseEnter
        RaiseEvent Hover(Me, EventArgs.Empty)
    End Sub

    Private Sub ChildControl_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave, PictureBox1.MouseLeave
        RaiseEvent Leave(Me, EventArgs.Empty)
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
            PictureBox1.BackgroundImage = value
        End Set
    End Property

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub pictureButtonvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region


End Class
