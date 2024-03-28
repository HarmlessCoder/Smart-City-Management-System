Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports SmartCityMgmtSystem.ElectionInnerScreenCitizenRTI
Public Class ElectionInnerScreenCitizenRTIPA

    Dim instance As New ProfileClass()
    Private Sub ElectionInnerScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        instance.UID = 10 ' Setting the value
        Dim value As Integer = instance.UID ' Getting the
        LoadandBindDataGridView()
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

        cmd = New MySqlCommand("SELECT query_id, ministry_name, query, status, response
                                FROM rti_queries_table
                                JOIN ministries ON ministries.ministry_id = rti_queries_table.ministry
                                WHERE citizen_uid = " & instance.UID & ";", Con)
        reader = cmd.ExecuteReader()

        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()

        'Fill the DataTable with data from the SQL table
        dataTable.Load(reader)
        reader.Close()
        Con.Close()

        'IMP: Specify the Column Mappings from DataGridView to SQL Table
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "query_id"
        DataGridView1.Columns(1).DataPropertyName = "ministry_name"
        DataGridView1.Columns(2).DataPropertyName = "query"
        DataGridView1.Columns(3).DataPropertyName = "status"
        DataGridView1.Columns(4).DataPropertyName = "response"

        ' Bind the data to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.viewChildForm(ElectionDashboard.childformPanel, ElectionInnerScreenCitizenRTI)
    End Sub
End Class