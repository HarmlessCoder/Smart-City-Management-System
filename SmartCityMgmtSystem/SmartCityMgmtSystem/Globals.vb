Imports System.Configuration
Imports MySql.Data.MySqlClient

'To get the global variables/declarations to be used all over the project
Public Class Globals
    'Deployed Database
    Private Shared dbConnectionString As String = "server=mysql9001.site4now.net;user id=aa69bc_sghy;password=swelab123;database=db_aa69bc_sghy;"


    'To get the dbString
    Public Shared Function getdbConnectionString() As String
        Return dbConnectionString
    End Function

    'To get the dbConnection
    Public Shared Function GetDBConnection() As MySqlConnection
        Dim dbConnectionString As String = getdbConnectionString()
        Dim conn = New MySqlConnection(dbConnectionString)
        Return conn
    End Function

    'To execute a Delete Query - returns True if succesful
    Public Shared Function ExecuteDeleteQuery(query As String) As Boolean

        Using conn As MySqlConnection = GetDBConnection()
            Try
                conn.Open()
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Row deleted successfully.", "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return False
    End Function
    'To execute a Update Query returns True if succesful
    Public Shared Function ExecuteUpdateQuery(query As String) As Boolean

        Using conn As MySqlConnection = GetDBConnection()
            Try
                conn.Open()
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Row updated successfully.", "Update Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return False
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

End Class
