Imports System.Data.SqlClient
Public Class Ed_Moodle_CourseContent
    Private RoomID As Integer
    Private callingPanel As Panel


    ' Constructor that accepts a Panel parameter
    Public Sub New(roomID As Integer, panel As Panel)
        InitializeComponent()
        roomID = roomID
        callingPanel = panel
    End Sub

    Private Sub Ed_Moodle_CourseContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim labels As Ed_ResourceLinkItem() = New Ed_ResourceLinkItem(8) {}

        ' Create labels and set properties
        For i As Integer = 0 To 7
            labels(i) = New Ed_ResourceLinkItem()
            labels(i).Label1.Text = "Resource " & (i + 1)
            AddHandler labels(i).Label1.Click, AddressOf Label_Click ' Add click event handler
        Next
        ' Add labels to the FlowLayoutPanel
        For Each Label As Ed_ResourceLinkItem In labels
            FlowLayoutPanel1.Controls.Add(Label)
        Next
    End Sub
    Private Sub Label_Click(sender As Object, e As EventArgs)
        Dim resourceForm As New Ed_Moodle_CourseResource(callingPanel, "Moodle")
        resourceForm.Name = "HELLO"
        Globals.viewChildForm(callingPanel, resourceForm)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class