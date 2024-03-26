Public Class Ed_GlobalDashboard
    Public innerpanel As Panel
    Public Sub OpenFormInGlobalEdPanel(ByVal formToShow As Form)
        ' Clear the panel before adding a new form
        Panel1.Controls.Clear()

        ' Set the form properties
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to the panel
        Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()
    End Sub
    Private Sub Ed_GlobalDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFormInGlobalEdPanel(Ed_RoleSelect)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
