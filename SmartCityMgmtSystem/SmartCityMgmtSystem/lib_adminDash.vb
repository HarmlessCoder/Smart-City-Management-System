﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class lib_adminDash
    Public Property uid As Integer = -1
    Public Property u_name As String = "Hello"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lib_adminSearch = New lib_adminSearch()
        lib_adminSearch.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lib_admin_eBooks = New lib_admin_eBooks()
        lib_admin_eBooks.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lib_adminBM = New lib_adminBM()
        lib_adminBM.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lib_adminMT = New lib_adminMT()
        lib_adminMT.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim lib_adminReq = New lib_adminReq()
        lib_adminReq.Show()
        Me.Close()
    End Sub
End Class