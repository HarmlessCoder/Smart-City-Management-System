Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports Google.Protobuf.WellKnownTypes
Imports System.Text.RegularExpressions


Public Class ElectionInnerScreenAdminNomination

    ' Create a new dictionary with Integer keys and String values
    Dim ministryToId As New Dictionary(Of String, Integer)

    ' Add items to the dictionary

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

        cmd = New MySqlCommand("SELECT election_id, candidate_uid, name, ministry_name, agenda, status 
                                FROM candidate_register
                                JOIN users ON users.user_id = candidate_register.candidate_uid
                                JOIN ministries ON ministries.ministry_id = candidate_register.ministry_id;", Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "election_id"
        DataGridView1.Columns(1).DataPropertyName = "candidate_uid"
        DataGridView1.Columns(2).DataPropertyName = "name"
        DataGridView1.Columns(3).DataPropertyName = "ministry_name"
        DataGridView1.Columns(4).DataPropertyName = "agenda"
        DataGridView1.Columns(5).DataPropertyName = "status"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    column.Frozen = False
        'Next

        'DataGridView1.RowTemplate.Height = 300
        'DataGridView1.ScrollBars = ScrollBars.Both

        'Dim rowIndex As Integer = DataGridView1.Rows.Add()
        'DataGridView1.Rows(rowIndex).Cells(0).Value = "1"
        'DataGridView1.Rows(rowIndex).Cells(1).Value = "121"
        'DataGridView1.Rows(rowIndex).Cells(2).Value = "Neha Sharma"
        'DataGridView1.Rows(rowIndex).Cells(3).Value = "Power Minister"
        'DataGridView1.Rows(rowIndex).Cells(4).Value = "Implementing renewable energy initiatives to reduce reliance on fossil fuels and promote sustainability. Modernizing and upgrading existing power infrastructure to ensure reliable and efficient electricity supply for all citizens."
        'DataGridView1.Rows(rowIndex).Cells(5).Value = "No"
        'DataGridView1.Rows(rowIndex).Cells(6).Value = "Pending"

        'rowIndex = DataGridView1.Rows.Add()
        'DataGridView1.Rows(rowIndex).Cells(0).Value = "2"
        'DataGridView1.Rows(rowIndex).Cells(1).Value = "256"
        'DataGridView1.Rows(rowIndex).Cells(2).Value = "Rajesh Patel"
        'DataGridView1.Rows(rowIndex).Cells(3).Value = "Finance Minister"
        'DataGridView1.Rows(rowIndex).Cells(4).Value = "Implementing fiscal policies to stimulate economic growth and job creation while maintaining fiscal discipline. Enhancing financial inclusion and stability through measures to promote investment, manage public debt, and ensure equitable distribution of resources."
        'DataGridView1.Rows(rowIndex).Cells(5).Value = "Yes"
        'DataGridView1.Rows(rowIndex).Cells(6).Value = "Approved"

        'Employment
        'Education
        'Health
        'Transport
        'Culture
        'Power
        'Finance
        'Broadcasting
        'IT

        ministryToId.Add("Employment", 1)
        ministryToId.Add("Education", 2)
        ministryToId.Add("Health", 3)
        ministryToId.Add("Transport", 4)
        ministryToId.Add("Culture", 5)
        ministryToId.Add("Power", 6)
        ministryToId.Add("Finance", 7)
        ministryToId.Add("Broadcasting", 8)
        ministryToId.Add("IT", 9)

        LoadandBindDataGridView()


    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ' Check if the value changed in the ComboBox column and it's not a header row
        If e.ColumnIndex = 5 AndAlso e.RowIndex <> -1 Then
            Dim selectedValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            ' You can perform any other actions here based on the changed value
            Dim Con = Globals.GetDBConnection()
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand

            Try
                Con.Open()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New MySqlCommand("UPDATE candidate_register SET status = " + """" + selectedValue + """" + " WHERE election_id = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & " AND candidate_uid = " & DataGridView1.Rows(e.RowIndex).Cells(1).Value & ";", Con)
            reader = cmd.ExecuteReader

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenAdmin)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedValue1 As Object = ComboBox1.SelectedItem
        Dim selectedValue2 As Object = ComboBox2.SelectedItem

        If selectedValue1 Is Nothing And selectedValue2 IsNot Nothing Then
            Dim status As String = selectedValue2.ToString()
            'Get connection from globals
            Dim Con = Globals.GetDBConnection()
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand

            Try
                Con.Open()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New MySqlCommand("SELECT election_id, candidate_uid, name, ministry_name, agenda, status 
                                    FROM candidate_register
                                    JOIN users ON users.user_id = candidate_register.candidate_uid
                                    JOIN ministries ON ministries.ministry_id = candidate_register.ministry_id
                                    WHERE status = """ + status + """;", Con)
            reader = cmd.ExecuteReader
            ' Create a DataTable to store the data
            Dim dataTable As New DataTable()

            'Fill the DataTable with data from the SQL table
            dataTable.Load(reader)
            reader.Close()
            Con.Close()

            'IMP: Specify the Column Mappings from DataGridView to SQL Table
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns(0).DataPropertyName = "election_id"
            DataGridView1.Columns(1).DataPropertyName = "candidate_uid"
            DataGridView1.Columns(2).DataPropertyName = "name"
            DataGridView1.Columns(3).DataPropertyName = "ministry_name"
            DataGridView1.Columns(4).DataPropertyName = "agenda"
            DataGridView1.Columns(5).DataPropertyName = "status"

            ' Bind the data to DataGridView
            DataGridView1.DataSource = dataTable
        ElseIf selectedValue1 IsNot Nothing And selectedValue2 Is Nothing Then
            Dim position As String = selectedValue1.ToString()
            'Get connection from globals
            Dim Con = Globals.GetDBConnection()
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand

            Try
                Con.Open()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New MySqlCommand("SELECT election_id, candidate_uid, name, ministry_name, agenda, status 
                                    FROM candidate_register
                                    JOIN users ON users.user_id = candidate_register.candidate_uid
                                    JOIN ministries ON ministries.ministry_id = candidate_register.ministry_id
                                    WHERE ministries.ministry_id = " & ministryToId(position) & ";", Con)
            reader = cmd.ExecuteReader
            ' Create a DataTable to store the data
            Dim dataTable As New DataTable()

            'Fill the DataTable with data from the SQL table
            dataTable.Load(reader)
            reader.Close()
            Con.Close()

            'IMP: Specify the Column Mappings from DataGridView to SQL Table
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns(0).DataPropertyName = "election_id"
            DataGridView1.Columns(1).DataPropertyName = "candidate_uid"
            DataGridView1.Columns(2).DataPropertyName = "name"
            DataGridView1.Columns(3).DataPropertyName = "ministry_name"
            DataGridView1.Columns(4).DataPropertyName = "agenda"
            DataGridView1.Columns(5).DataPropertyName = "status"

            ' Bind the data to DataGridView
            DataGridView1.DataSource = dataTable
        ElseIf selectedValue1 IsNot Nothing And selectedValue2 IsNot Nothing Then
            Dim status As String = selectedValue2.ToString()
            Dim position As String = selectedValue1.ToString()

            'Get connection from globals
            Dim Con = Globals.GetDBConnection()
            Dim reader As MySqlDataReader
            Dim cmd As MySqlCommand

            Try
                Con.Open()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New MySqlCommand("SELECT election_id, candidate_uid, name, ministry_name, agenda, status 
                                    FROM candidate_register
                                    JOIN users ON users.user_id = candidate_register.candidate_uid
                                    JOIN ministries ON ministries.ministry_id = candidate_register.ministry_id
                                    WHERE status = """ + status + """ AND " + "ministries.ministry_id = " & ministryToId(position) & ";", Con)
            reader = cmd.ExecuteReader
            ' Create a DataTable to store the data
            Dim dataTable As New DataTable()

            'Fill the DataTable with data from the SQL table
            dataTable.Load(reader)
            reader.Close()
            Con.Close()

            'IMP: Specify the Column Mappings from DataGridView to SQL Table
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns(0).DataPropertyName = "election_id"
            DataGridView1.Columns(1).DataPropertyName = "candidate_uid"
            DataGridView1.Columns(2).DataPropertyName = "name"
            DataGridView1.Columns(3).DataPropertyName = "ministry_name"
            DataGridView1.Columns(4).DataPropertyName = "agenda"
            DataGridView1.Columns(5).DataPropertyName = "status"

            ' Bind the data to DataGridView
            DataGridView1.DataSource = dataTable
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class