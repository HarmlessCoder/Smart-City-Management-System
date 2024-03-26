Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Ed_Coursera_CourseContent

    Private CourseID As Integer
    Private callingPanel As Panel
    Public Property ResourceName As String
    Public Property VideoLink As String
    Public Property TextContent As String


    ' Constructor that accepts a Panel parameter
    Public Sub New(courseID As Integer, panel As Panel)
        InitializeComponent()
        courseID = courseID
        callingPanel = panel
    End Sub
    Private Sub Ed_Coursera_CourseContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim labels As Label() = New Label(21) {}

        ' Create labels and set properties
        For i As Integer = 0 To 20
            labels(i) = New Label()
            labels(i).Text = "Resource " & (i + 1)
            labels(i).AutoSize = False
            labels(i).Width = FlowLayoutPanel1.Width - 10
            labels(i).Height = 20 ' Adjust the height as needed
            labels(i).BackColor = Color.Transparent
            labels(i).BorderStyle = BorderStyle.None
            labels(i).Font = New Font("Cascadia Mono", 10) ' Set font to Cascadia Mono, size 10
            labels(i).ForeColor = Color.FromArgb(40, 68, 114) ' Set text color
            AddHandler labels(i).Click, AddressOf Label_Click ' Add click event handler
        Next


        ' Add labels to the FlowLayoutPanel
        For Each Label As Label In labels
            FlowLayoutPanel1.Controls.Add(Label)
        Next
        ResourceName = "Testing 123"
        VideoLink = "https://www.youtube.com/watch?v=I0czvJ_jikg&list=RDI0czvJ_jikg&start_radio=1"
        Label1.Text = ResourceName
        Dim youtubeUrl As String = "https://www.youtube.com/watch?v=WVOiDcFUg_I" ' Your YouTube video URL
        Dim videoId As String = ExtractYouTubeVideoId(youtubeUrl)

        If Not String.IsNullOrEmpty(videoId) Then
            Dim embedUrl As String = $"https://www.youtube.com/embed/{videoId}"
            Dim html As String = $"<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=edge'></head><body style='margin:0'><iframe width='566' height='265' src='{embedUrl}' frameborder='0' allowfullscreen></iframe></body></html>"
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
    Private Sub Label_Click(sender As Object, e As EventArgs)
        Globals.viewChildForm(callingPanel, New Ed_CourseResource(callingPanel, "Coursera"))
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, New Ed_Stud_MyCourses())
    End Sub
End Class