﻿Imports System.Data.SqlClient
Imports SmartCityMgmtSystem.Ed_Coursera_Handler
Public Class Ed_ManageECourse
    Dim handler As New Ed_Coursera_Handler()

    Public Property teacherID As Integer

    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teacherID = Ed_GlobalDashboard.Ed_Profile.Ed_User_ID
        Dim courses As Course() = handler.GetTeacherCourses(teacherID)
        Dim labels As Ed_Teacher_CourseraItem() = New Ed_Teacher_CourseraItem(courses.Length - 1) {}

        ' Create labels and set properties
        For i As Integer = 0 To courses.Length - 1
            labels(i) = New Ed_Teacher_CourseraItem()
            labels(i).CourseID = courses(i).CourseID
            labels(i).Label6.Text = courses(i).Name ' Set course name
            labels(i).Label1.Text = courses(i).TeacherName ' Set instructor name
            labels(i).Label2.Text = courses(i).Institution ' Set affiliation
            labels(i).Label4.Text = courses(i).Rating.ToString() ' Set rating
            labels(i).Label3.Text = courses(i).Fees.ToString() ' Set fees
            labels(i).CourseItem = courses(i)

        Next

        ' Add labels to the FlowLayoutPanel
        For Each Ed_Teacher_CourseraItem As Ed_Teacher_CourseraItem In labels
            FlowLayoutPanel1.Controls.Add(Ed_Teacher_CourseraItem)
        Next





    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class