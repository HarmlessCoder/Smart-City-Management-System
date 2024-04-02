Public Class Ed_MoodleResouceLinkItem
    Public Property callingPanel As Panel
    Public Property content As Ed_Moodle_Handler.RoomContent
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim resourceForm As New Ed_Moodle_CourseResource(callingPanel, "Moodle")
        resourceForm.CourseID = content.RoomID
        resourceForm.content = content
        Globals.viewChildForm(callingPanel, resourceForm)
    End Sub
End Class
