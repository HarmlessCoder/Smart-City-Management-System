Imports System.Data.SqlClient
Public Class TransportTollPlaza
    Private Sub AddPostPurchase(postNum As Integer, vehnum As String,
                           Optional drvlicensenum As String = "12345",
                          Optional dt As String = "21st March 2024",
                           Optional fare As Integer = 0)
        Dim RidePost As FastagPurchase
        RidePost = New FastagPurchase()
        With RidePost
            .Name = "post_" & postNum
        End With
        RidePost.SetDetails(vehnum, drvlicensenum, dt, fare)
        PostsPanel2.Controls.Add(RidePost)
    End Sub
    Private Sub AddPostPlan(postNum As Integer, vehtype As String,
                           Optional validity As String = "Valid for 3 months",
                           Optional fare As Integer = 0)
        Dim RidePost As FastagPlanItem
        RidePost = New FastagPlanItem()
        With RidePost
            .Name = "post_" & postNum
        End With
        RidePost.SetDetails(vehtype, validity, fare)
        PostsPanel.Controls.Add(RidePost)
    End Sub
    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dummy Data, Change it to LoadandBindDataGridView() 
        AddPostPurchase(1, "AS-01-1234", "12345", "21st March 2024", 100)
        AddPostPurchase(2, "AS-01-1234", "12345", "21st March 2024", 100)
        AddPostPlan(1, "Car", "Valid for 3 months", 100)
        AddPostPlan(2, "Car", "Valid for 3 months", 100)


    End Sub

End Class