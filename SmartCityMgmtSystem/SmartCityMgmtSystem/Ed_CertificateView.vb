Imports System.Data.SqlClient
Imports System.IO
Imports PdfiumViewer
Public Class Ed_CertificateView
    Public CertificateName As String
    Public Par As String
    Private Sub Ed_CertificateView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Open file dialog to select PDF file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Read PDF file into byte array
            Dim pdfBytes As Byte() = File.ReadAllBytes(filePath)

            ' Load PDF from byte array
            LoadPdfFromByteArray(pdfBytes)
        End If
    End Sub

    Private Sub LoadPdfFromByteArray(pdfData As Byte())
        ' Create a MemoryStream from the byte array
        Dim memoryStream As New MemoryStream(pdfData)

        ' Load PDF from MemoryStream
        Dim pdfDocument As PdfDocument = PdfDocument.Load(memoryStream)

        ' Set the PdfDocument instance to the PdfViewer control
        PdfViewer1.Document = pdfDocument

        ' Dispose the MemoryStream after setting PdfViewer1.Document
        ' This ensures that the MemoryStream is disposed only after the PdfDocument is set to the PdfViewer control
    End Sub




    Private Sub PdfRenderer1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form As New Ed_CertificateList()
        form.EC_Insti = Par
        Globals.viewChildForm(Ed_GlobalDashboard.innerpanel, form)
    End Sub
End Class