Imports System.Net.Mail

Public Class UserGetOtp
    Private ReadOnly email As String
    Private ReadOnly password As String
    Private ReadOnly nextPage As Integer
    Dim randstr As String

    Public Sub New(email As String, password As String, nextPage As Integer)
        InitializeComponent()
        Me.email = email ' Store the passed email ID in a private field
        Me.password = password
        Me.nextPage = nextPage          '0 for details page, 1 for password reset page

        Dim randomNumber As Integer = New Random().Next(1000, 10000)
        randstr = randomNumber.ToString()

        ' Send the random number to the user's email
        SendEmail(email, randstr)

    End Sub
    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SendEmail(recipientEmail As String, randomNumber As String)
        Try
            Dim smtpClient As New SmtpClient()
            Dim mail As New MailMessage()

            Dim from, pass As String
            from = "smartcityiitguwahati@gmail.com"
            pass = "cypu wiqj ntsh buoy"

            ' Configure SMTP settings
            smtpClient.Host = "smtp.gmail.com" ' SMTP server address
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
            smtpClient.Port = 587 ' the SMTP port number
            smtpClient.EnableSsl = True ' Enable SSL if required
            smtpClient.UseDefaultCredentials = False
            smtpClient.Credentials = New System.Net.NetworkCredential(from, pass)
            ' SMTP username and password

            ' Configure email message
            mail.From = New MailAddress(from) ' the sender's email address
            mail.To.Add(recipientEmail) ' the recipient's email address
            mail.Subject = "SmartCityGuwahati Verification Code"
            mail.Body = "Your 4-digit verification code is: " & randomNumber

            ' Send the email
            smtpClient.Send(mail)
            MessageBox.Show("Please check your mail and enter the OTP")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        'Globals.viewChildForm(childformPanel, TransportationAdminHome)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox1.Text.Equals(randstr) AndAlso nextPage = 0) Then
            Dim details = New UserDetails(email, password)
            details.Show()
            Me.Close()
        ElseIf (TextBox1.Text.Equals(randstr) AndAlso nextPage = 1) Then
            Dim reset = New UserResetPassword(email, password)
            reset.Show()
            Me.Close()
        Else
            MessageBox.Show("OTP verification failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class
