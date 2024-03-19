Imports System.Configuration

'To get the global variables/declarations to be used all over the project
Public Class Globals
    'Deployed Database
    Private Shared dbConnectionString As String = "db-connection string TBA"

    'To get the dbString
    Public Shared Function getdbConnectionString() As String
        Return dbConnectionString
    End Function

    'To view the child form in the same window inside a parentPanel
    'Eg. to view InnerScreen(childform) in Dashboard Screen
    Public Shared Sub viewChildForm(ByVal parentpanel As Panel, ByVal childform As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show() 'Add to panel and show the child form
    End Sub

    Public Shared Sub viewChildFormAndClose(ByVal parentpanel As Panel, ByVal childform As Form, ByVal parentForm As Form)
        parentpanel.Controls.Clear()
        childform.TopLevel = False
        childform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        childform.BringToFront()
        parentpanel.Controls.Add(childform)
        childform.Show() ' Add to panel and show the child form

        ' Pass reference of the parent form to the child form
        If TypeOf childform Is HomePage Then
            Dim yourChildForm As HomePage = CType(childform, HomePage)
            yourChildForm.SetMainForm(parentForm)
        End If
    End Sub


End Class
