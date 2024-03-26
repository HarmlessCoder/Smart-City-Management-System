Imports System.Data.SqlClient
Public Class Ed_Moodle_AssList
    Public RoomID As Integer
    Public Seq_no As Integer
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim labels As Label() = New Label(21) {}

        ' Create labels and set properties
        For i As Integer = 0 To 20
            labels(i) = New Label()
            labels(i).Text = "Course " & (i + 1) & " Assignment" & (i + 1)
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
    End Sub
    Private Sub Label_Click(sender As Object, e As EventArgs)
        Globals.viewChildForm(Panel1, New Ed_Moodle_CourseAss(Panel1))
    End Sub



End Class