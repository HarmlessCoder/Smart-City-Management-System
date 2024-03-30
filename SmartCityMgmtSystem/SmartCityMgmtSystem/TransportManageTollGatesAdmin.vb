﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class TransportManageTollGatesAdmin
    Private primaryKeyEdit As String

    Private Sub ShowEditOption(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String)
        Label3.Text = "Update Toll Booth"
        Button3.Text = "Update"
        TextBox1.Text = txt1
        TextBox6.Text = txt2
        TextBox2.Text = txt3
        TextBox3.Text = txt4
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "EditBut" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index AndAlso e.RowIndex >= 0 Then
            'Show Edit Option
            primaryKeyEdit = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            ShowEditOption(DataGridView1.Rows(e.RowIndex).Cells(0).Value, DataGridView1.Rows(e.RowIndex).Cells(1).Value, DataGridView1.Rows(e.RowIndex).Cells(2).Value, DataGridView1.Rows(e.RowIndex).Cells(3).Value)
            ' Check if the clicked cell is in the "DeleteBut" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "DeleteButton" column
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Call a method to delete the row from the database using the primary key
                Dim success As Boolean = Globals.ExecuteDeleteQuery("DELETE FROM tollboothdb where lane_id = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value)

                If success Then
                    ' If deletion is successful, then refresh the datagridview
                    LoadandBindDataGridView()
                End If

            End If
        End If
    End Sub

    Private Sub LoadandBindDataGridView()
        'Get connection from globals
        Dim Con = Globals.GetDBConnection()
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmd = New MySqlCommand("SELECT * FROM tollboothdb", Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "lane_id"
        DataGridView1.Columns(1).DataPropertyName = "description"
        DataGridView1.Columns(2).DataPropertyName = "allowed_vehicle_types"
        DataGridView1.Columns(3).DataPropertyName = "fare_per_vehicle"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadandBindDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Add Toll Booth"
        Button3.Text = "Add"
        TextBox1.Clear()
        TextBox6.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Toll Booth"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox6.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Toll Booth"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Toll Booth"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Toll Booth"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If Button3.Text = "Update" Then
            Dim cmd As String
            cmd = "UPDATE tollboothdb SET lane_id = " & Convert.ToInt32(TextBox1.Text) & " , description = '" & TextBox6.Text & "' , allowed_vehicle_types ='" & TextBox2.Text & "' , fare_per_vehicle = '" & TextBox3.Text & "' WHERE lane_id =" & primaryKeyEdit
            Dim success As Boolean = Globals.ExecuteUpdateQuery(cmd)
            If success Then
                LoadandBindDataGridView()

            End If
            Label3.Text = "Add Toll Booth"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            Dim cmd As String
            cmd = "INSERT into tollboothdb VALUES ('" & TextBox1.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            Dim success As Boolean = Globals.ExecuteInsertQuery(cmd)
            If success Then
                LoadandBindDataGridView()
            End If
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End If
    End Sub
End Class