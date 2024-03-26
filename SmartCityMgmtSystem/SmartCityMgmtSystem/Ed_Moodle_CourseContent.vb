Imports System.Data.SqlClient
Public Class Ed_Moodle_CourseContent
    Private CourseID As Integer
    Private callingPanel As Panel


    ' Constructor that accepts a Panel parameter
    Public Sub New(courseID As Integer, panel As Panel)
        InitializeComponent()
        courseID = courseID
        callingPanel = panel
    End Sub

    Private Sub Ed_Moodle_CourseContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class