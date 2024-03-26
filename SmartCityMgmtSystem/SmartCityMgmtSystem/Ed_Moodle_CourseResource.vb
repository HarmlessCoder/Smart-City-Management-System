Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class Ed_Moodle_CourseResource

    Public Property CourseID As Integer
    Public Property ResourceName As String
    Public Property VideoLink As String
    Public Property TextContent As String

    Private callingPanel As Panel
    Private Course_type As String

    Public Sub New(panel As Panel, type As String)
        InitializeComponent()
        callingPanel = panel
        Course_type = type
    End Sub
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResourceName = "Testing 123"
        VideoLink = "https://www.youtube.com/watch?v=I0czvJ_jikg&list=RDI0czvJ_jikg&start_radio=1"
        Label1.Text = ResourceName
        RichTextBox1.Text = TextContent
        Dim youtubeUrl As String = "https://www.youtube.com/watch?v=WVOiDcFUg_I" ' Your YouTube video URL
        Dim videoId As String = ExtractYouTubeVideoId(youtubeUrl)

        If Not String.IsNullOrEmpty(videoId) Then
            Dim embedUrl As String = $"https://www.youtube.com/embed/{videoId}"
            Dim html As String = $"<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=edge'></head><body style='margin:0'><iframe width='964' height='239' src='{embedUrl}' frameborder='0' allowfullscreen></iframe></body></html>"
            WebBrowser1.DocumentText = html
        Else
            MessageBox.Show("Invalid YouTube URL")
        End If
    End Sub
    Private Function ExtractYouTubeVideoId(url As String) As String
        Dim regexPattern As String = "(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})"
        Dim match As Match = Regex.Match(url, regexPattern)
        If match.Success Then
            Return match.Groups(1).Value
        Else
            Return Nothing
        End If
    End Function


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Course_type = "Coursera" Then
            Globals.viewChildForm(callingPanel, New Ed_Coursera_CourseContent(CourseID, callingPanel))
        Else
            Globals.viewChildForm(callingPanel, New Ed_Moodle_CourseContent(CourseID, callingPanel))
        End If
    End Sub
End Class