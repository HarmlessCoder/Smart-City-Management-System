Imports System.Data.SqlClient
Imports Org.BouncyCastle.Cmp
Public Class Ed_CertificateList
    Public EC_Insti As String
    Private Sub Ed_CertificateList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure FlowLayoutPanel1
        ConfigureFlowLayoutPanel(FlowLayoutPanel1)

        ' Configure FlowLayoutPanel2
        ConfigureFlowLayoutPanel(FlowLayoutPanel2)

        ' Configure FlowLayoutPanel3
        ConfigureFlowLayoutPanel(FlowLayoutPanel3)

        Label1.Text = "Marksheets"
        Label2.Text = "Extra-Curricular CertificateStatus"
        Label3.Text = "Entrance Exam Results"

        ' Adjust layout if EC_Insti is Coursera
        If EC_Insti = "Coursera" Then
            FlowLayoutPanel2.Visible = False
            Label2.Visible = False
            FlowLayoutPanel3.Visible = False
            Label3.Visible = False
            FlowLayoutPanel1.Height *= 4
            Label1.Text = "Coursera"
        End If

    End Sub

    Private Sub ConfigureFlowLayoutPanel(panel As FlowLayoutPanel)
        ' Set AutoScroll, WrapContents, and AutoSize properties
        panel.AutoScroll = True
        panel.WrapContents = False
        panel.AutoSize = False
        panel.HorizontalScroll.Visible = True

        ' Add buttons to the panel
        For i As Integer = 1 To 20
            Dim button As New Button()
            button.Text = $"Button {i}: Button Text Here" ' Set text for each button individually
            button.Size = New Size(120, 120)
            AddHandler button.Click, AddressOf Button_Click
            panel.Controls.Add(button)
        Next
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Get the button that was clicked
        Dim button As Button = DirectCast(sender, Button)

        ' Extract information from the button text or any other logic based on button properties
        ' Here, you can navigate to the certificate view page based on the button clicked
        ' For example:
        Dim buttonText As String = button.Text ' Get button text
        Dim form As New Ed_CertificateView()
        form.CertificateName = buttonText ' Pass the certificate name to the certificate view form
        form.Par = EC_Insti ' Pass the institution type to the certificate view form
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, form)
    End Sub


End Class