Public Class Ed_EntranceInnerScreen
    Private WithEvents marqueeTimer As New Timer()
    Private currentIndex As Integer = 0
    Public labelText As String = ""
    Private marqueeText As String = "This is a sample ticker text for demonstration purposes. You can replace it with your own news headlines.                                                                                                  "
    Private Sub Ed_EntranceInnerScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = labelText
        ' Configure the Timer
        marqueeTimer.Interval = 100 ' Adjust the interval as needed for desired scrolling speed
        marqueeTimer.Start()

        ' Set initial text
        UpdateMarqueeText()

        ' Start the marquee
        StartMarquee()
    End Sub

    Private Sub marqueeTimer_Tick(sender As Object, e As EventArgs) Handles marqueeTimer.Tick
        ' Move to the next character in the marquee text
        currentIndex += 1

        ' Check if we've reached the end of the text
        If currentIndex >= marqueeText.Length Then
            currentIndex = 0
        End If

        ' Update the label with the new text
        UpdateMarqueeText()
    End Sub

    Private Sub StartMarquee()
        ' Start the marquee by enabling the Timer
        marqueeTimer.Enabled = True
    End Sub

    Private Sub StopMarquee()
        ' Stop the marquee by disabling the Timer
        marqueeTimer.Enabled = False
    End Sub

    Private Sub UpdateMarqueeText()
        ' Display a portion of the marquee text starting from currentIndex
        Dim displayedText As String = marqueeText.Substring(currentIndex) & marqueeText.Substring(0, currentIndex)

        ' Smooth transition using opacity
        Dim opacityValue As Double = Math.Abs(Math.Sin(currentIndex / 10)) ' Adjust the divisor for smoother or faster fading
        Label2.Text = displayedText
        Label2.ForeColor = Color.FromArgb(CInt(opacityValue * 255), Label2.ForeColor)
    End Sub

    Private Sub Ed_EntranceInnerScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure the Timer is stopped when the form is closing to prevent memory leaks
        StopMarquee()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
