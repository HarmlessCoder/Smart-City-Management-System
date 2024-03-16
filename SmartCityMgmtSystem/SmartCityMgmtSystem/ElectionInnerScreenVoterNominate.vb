Imports System.Data.SqlClient
Imports System.IO
Public Class ElectionInnerScreenVoterNominate
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreen1)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the title and filters for the OpenFileDialog
        openFileDialog.Title = "Select a File to Upload"
        openFileDialog.Filter = "All Files (*.*)|*.*"

        ' Show the OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim fileName As String = Path.GetFileName(filePath)

            ' Display the selected file name
            Label3.Text = fileName

            ' Here you can process the uploaded file, for example, save it to a specific location
            ' File.Copy(filePath, "destination_path\" & fileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the title and filters for the OpenFileDialog
        openFileDialog.Title = "Select a File to Upload"
        openFileDialog.Filter = "All Files (*.*)|*.*"

        ' Show the OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim fileName As String = Path.GetFileName(filePath)

            ' Display the selected file name
            Label6.Text = fileName

            ' Here you can process the uploaded file, for example, save it to a specific location
            ' File.Copy(filePath, "destination_path\" & fileName)
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class