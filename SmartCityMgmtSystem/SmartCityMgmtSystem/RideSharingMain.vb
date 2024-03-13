Imports System.Data.SqlClient
Public Class RideSharingMain

    Private Sub AddPost(name As String,
                        Optional datetime As String = "",
                        Optional fromPlace As String = "",
                        Optional toPlace As String = "",
                        Optional fare As Integer = 0,
                        Optional capacity As Integer = 0,
                        Optional postNum As Integer = 0,
                        Optional image As Image = Nothing)
        Dim RidePost As RideSharingPost
        RidePost = New RideSharingPost()
        With RidePost
            .Name = "post_" & postNum
            .Width = 595
            .Height = 120
            '.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        End With
        RidePost.SetDetails(name, datetime, fromPlace, toPlace, fare, capacity, image)
        PostsPanel.Controls.Add(RidePost)
    End Sub
    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddPost("Dhanesh", "21st March, 6:30PM", "IIT", "Airport", 50, 3, 1, Nothing)
        AddPost("Sanjana", "22st March, 6:30PM", "Airport", "Brahmaputra", 50, 3, 2, Nothing)
        AddPost("Shivam Gupta", "1st April, 8:30AM", "Pan Bazaar", "Kamakhya", 25, 7, 3, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub
End Class