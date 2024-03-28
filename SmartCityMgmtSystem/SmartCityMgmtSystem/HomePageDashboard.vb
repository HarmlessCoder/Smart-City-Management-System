Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HomePageDashboard
    Private uid As Integer

    Public Sub New(uid As Integer)
        InitializeComponent()
        Me.uid = uid ' Store the passed email ID in a private field
        Dim cmd As String = "SELECT name FROM users WHERE user_id = @uid"
        Dim nm As String = "Hello!"
        Dim conStr As String = Globals.getdbConnectionString()
        Using connection As New MySqlConnection(conStr)
            Using sqlCommand As New MySqlCommand(cmd, connection)
                sqlCommand.Parameters.AddWithValue("@uid", uid)
                ' Execute the query and retrieve the user ID
                connection.Open()
                Dim result = sqlCommand.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    nm = Convert.ToString(result)
                End If
            End Using
        End Using
        Label3.Text = uid
        Label2.Text = nm
    End Sub
    Private Sub TransportationDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'View the TransportationAdminHome screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildFormAndClose(childformPanel, HomePage, Me)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim upp As New UserProfilePage(uid)
        Globals.viewChildForm(childformPanel, upp)
    End Sub
End Class
