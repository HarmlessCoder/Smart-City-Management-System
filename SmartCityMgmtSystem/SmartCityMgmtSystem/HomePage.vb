﻿Imports System.Data.SqlClient
Public Class HomePage

    Public mainForm As Form
    Public Sub SetMainForm(parentForm As Form)
        mainForm = parentForm
    End Sub
    Private Sub ed_dept_Click(sender As Object, e As EventArgs) Handles ed_dept.Click
        Dim ed = Ed_GlobalDashboard
        ed.userID = 100
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

    Private Sub event_dept_Click(sender As Object, e As EventArgs) Handles event_dept.Click
        Dim fest = New EventDashboard()
        fest.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub lib_dept_Click(sender As Object, e As EventArgs) Handles lib_dept.Click
        Dim library = New lib_dash()
        library.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub bankDept_Click(sender As Object, e As EventArgs) Handles bankDept.Click
        Dim bank = New BankingDashboard()
        bank.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub healthDept_Click(sender As Object, e As EventArgs) Handles healthDept.Click
        Dim health = New Healthcare_homepage()
        health.Show()
        mainForm.Close()
        Me.Close()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class