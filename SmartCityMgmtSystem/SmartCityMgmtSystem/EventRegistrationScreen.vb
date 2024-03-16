﻿Imports System.Data.SqlClient
Public Class EventRegistrationScreen

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "EditBut" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index AndAlso e.RowIndex >= 0 Then
            ' Change this to DB logic later
            MessageBox.Show("Edit button clicked for row " & e.RowIndex.ToString(), "Edit Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Check if the clicked cell is in the "DeleteBut" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "DeleteButton" column
            MessageBox.Show("Delete button clicked for row " & e.RowIndex.ToString(), "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub LoadandBindDataGridView()
        'Get connection String from globals
        Dim conString = Globals.getdbConnectionString()
        Dim Con = New SqlConnection(conString)

        'Query for SQL table
        Dim query = "enter your query"
        Con.Open()

        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)

        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        adapter.Fill(dataTable)

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "Column Name in SQL table"
        DataGridView1.Columns(1).DataPropertyName = "Column Name in SQL table"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Dummy Data, Change it to LoadandBindDataGridView() 
        If False Then
            For i As Integer = 1 To 8
                ' Add an empty row to the DataGridView
                Dim row As New DataGridViewRow()
                DataGridView1.Rows.Add(row)

                ' Set values for the first three columns in the current row
                DataGridView1.Rows(i - 1).Cells("Column1").Value = "DummyVal"
                DataGridView1.Rows(i - 1).Cells("Column2").Value = "DummyVal"
                DataGridView1.Rows(i - 1).Cells("Column3").Value = "DummyVal"
            Next
        End If
        ' Add an empty row to the DataGridView
        Dim row0 As New DataGridViewRow()
        DataGridView1.Rows.Add(row0)
        ' Set values for the first three columns in the current row
        DataGridView1.Rows(0).Cells("Column1").Value = "ABC Traders"
        DataGridView1.Rows(0).Cells("Column2").Value = "4.7"
        DataGridView1.Rows(0).Cells("Column3").Value = "52"

        ' Add an empty row to the DataGridView
        Dim row1 As New DataGridViewRow()
        DataGridView1.Rows.Add(row1)
        ' Set values for the first three columns in the current row
        DataGridView1.Rows(1).Cells("Column1").Value = "Ramesh and Sons"
        DataGridView1.Rows(1).Cells("Column2").Value = "3.9"
        DataGridView1.Rows(1).Cells("Column3").Value = "142"

        ' Add an empty row to the DataGridView
        Dim row2 As New DataGridViewRow()
        DataGridView1.Rows.Add(row2)
        ' Set values for the first three columns in the current row
        DataGridView1.Rows(2).Cells("Column1").Value = "Modern Trade Center"
        DataGridView1.Rows(2).Cells("Column2").Value = "4.88"
        DataGridView1.Rows(2).Cells("Column3").Value = "12"


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class