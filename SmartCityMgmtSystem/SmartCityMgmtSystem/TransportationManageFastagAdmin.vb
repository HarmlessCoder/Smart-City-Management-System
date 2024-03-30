Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class TransportationManageFastagAdmin
    Private primaryKeyEdit As String ' Define a class-level variable to hold the primary key of the row being edited
    Private Sub ShowEditOption(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String)
        Label3.Text = "Update Fastag Plan"
        Button3.Text = "Update"
        TextBox1.Text = txt1
        TextBox6.Text = txt2
        TextBox2.Text = txt3
        TextBox3.Text = txt4
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "EditBut" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index AndAlso e.RowIndex >= 0 Then
            ' Change this to DB logic later
            'Show Edit Option
            primaryKeyEdit = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            ShowEditOption(DataGridView1.Rows(e.RowIndex).Cells(0).Value, DataGridView1.Rows(e.RowIndex).Cells(1).Value, DataGridView1.Rows(e.RowIndex).Cells(2).Value, DataGridView1.Rows(e.RowIndex).Cells(3).Value)
            ' Check if the clicked cell is in the "DeleteBut" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "DeleteButton" column
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Call a method to delete the row from the database using the primary key
                Dim success As Boolean = Globals.ExecuteDeleteQuery("DELETE FROM fastag_plans where id = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value)

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

        cmd = New MySqlCommand("SELECT * FROM fastag_plans", Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "id"
        DataGridView1.Columns(1).DataPropertyName = "vehicle_type"
        DataGridView1.Columns(2).DataPropertyName = "fee_amt"
        DataGridView1.Columns(3).DataPropertyName = "validity_months"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadandBindDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Add Fastag Plan"
        Button3.Text = "Add"
        TextBox1.Clear()
        TextBox6.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Fastag Plan"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox6.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Fastag Plan"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Fastag Plan"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please enter some input in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add Fastag Plan"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If
        If Button3.Text = "Update" Then
            Dim cmd As String
            cmd = "UPDATE fastag_plans SET id = " & Convert.ToInt32(TextBox1.Text) & " , vehicle_type = " & Convert.ToInt32(TextBox6.Text) & " , fee_amt =" & Convert.ToInt32(TextBox2.Text) & " , validity_months = " & Convert.ToInt32(TextBox3.Text) & " WHERE id =" & primaryKeyEdit
            Dim success As Boolean = Globals.ExecuteUpdateQuery(cmd)
            If success Then
                LoadandBindDataGridView()

            End If
            Label3.Text = "Add Fastag Plan"
            Button3.Text = "Add"
            TextBox1.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            Dim cmd As String
            cmd = "INSERT into fastag_plans(id,vehicle_type,fee_amt,validity_months) VALUES (" & Convert.ToInt32(TextBox1.Text) & "," & Convert.ToInt32(TextBox6.Text) & "," & Convert.ToInt32(TextBox2.Text) & "," & Convert.ToInt32(TextBox3.Text) & ")"
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