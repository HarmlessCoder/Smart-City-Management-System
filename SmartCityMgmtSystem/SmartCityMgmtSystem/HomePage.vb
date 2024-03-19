Imports System.Data.SqlClient
Public Class HomePage

    Private mainForm As Form
    Public Sub SetMainForm(parentForm As Form)
        mainForm = parentForm
    End Sub
    Private Sub ed_dept_Click(sender As Object, e As EventArgs) Handles ed_dept.Click
        Dim ed = New Ed_GlobalDashboard()
        ed.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub electionDept_Click(sender As Object, e As EventArgs) Handles electionDept.Click
        Dim elec = New ElectionDashboard()
        elec.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub tranDept_Click(sender As Object, e As EventArgs) Handles tranDept.Click
        Dim transport = New TransportationDashboard()
        transport.Show()
        mainForm.Close()
        Me.Close()
    End Sub


End Class