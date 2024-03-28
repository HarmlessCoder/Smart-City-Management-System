Public Class Ed_GlobalDashboard
    Public innerpanel As Panel
    Public userID As Integer
    Public Structure Profile
        Public Ed_User_ID As Integer
        Public Ed_Username As String
        Public Ed_User_Type As UserType
        Public Ed_User_Role As UserRole?
        Public Ed_Affiliation As Integer?
        Public Ed_Name As String
        Public Ed_DOB As Date?
        Public Ed_Class As Integer?
        Public Ed_Sem As Integer?
        Public Ed_LastEduQlf As String
    End Structure

    Public Enum UserType
        Student
        Teacher
        Admin
        Others
    End Enum

    Public Enum UserRole
        Minister
        Principal
        EcourseAdmin
        Bus
        Security
    End Enum

    Public Ed_Profile As Profile
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
        Globals.viewChildForm(Panel1, New Ed_RoleSelect())
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
