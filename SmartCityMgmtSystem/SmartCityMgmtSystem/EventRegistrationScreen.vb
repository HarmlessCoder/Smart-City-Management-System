Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
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


    Dim Mysqlconn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlCmd2 As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlRd2 As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim Dta As New MySqlDataAdapter
    Dim SqlQuery As String
    Dim SqlQuery2 As String


    Private Sub Viewtable()
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=123456;database=TelephoneDatabase;"
        Mysqlconn.Open()

        sqlCmd.Connection = Mysqlconn
        sqlCmd.CommandText = "Select * from UserData;"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)

        sqlRd.Close()
        Mysqlconn.Close()
        MessageBox.Show("Successful Connection")
        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub Insert_table()
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=Aasneh18;database=TelephoneDatabase;"
        Mysqlconn.Open()

        'SqlQuery = "Insert into UserData(name,IITG_email,phonenumber,role,password,department,plan_id,expiry_date,talktimeLeft,dataLeft,user_visibility) values ('Aasneh','p.aasneh@iitg.ac.in','7021901677','Student','Aasneh','CSE',0,'03-03-2024',0,0,'Public');"


        sqlCmd.Connection = Mysqlconn
        sqlCmd2.Connection = Mysqlconn

        sqlCmd.CommandText = SqlQuery
        sqlCmd2.CommandText = SqlQuery2

        sqlRd = sqlCmd.ExecuteReader
        sqlRd.Close()
        sqlRd2 = sqlCmd2.ExecuteReader
        sqlRd2.Close()
        'sqlDt.Load(sqlRd)


        Mysqlconn.Close()
        'MessageBox.Show("Successful Connection")
        'DataGridView1.DataSource = sqlDt




    End Sub

    Private Sub EventRegistrationScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Add options to the ComboBox
        ComboBox1.Items.Add("Marriage")
        ComboBox1.Items.Add("Religious Rites")
        ComboBox1.Items.Add("Orchestra")
        ComboBox1.Items.Add("Campaign")
        ComboBox1.Items.Add("Lecture")
        ComboBox1.Items.Add("Movie Screening")
        ComboBox1.Items.Add("Drama")
        ComboBox1.Items.Add("Exhibition")
        ComboBox1.Items.Add("Art Gallery")






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

        If False Then
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
            DataGridView1.Rows(1).Cells("Column2").Value = "3.7"
            DataGridView1.Rows(1).Cells("Column3").Value = "142"

            ' Add an empty row to the DataGridView
            Dim row2 As New DataGridViewRow()
            DataGridView1.Rows.Add(row2)
            ' Set values for the first three columns in the current row
            DataGridView1.Rows(2).Cells("Column1").Value = "Modern Trade Center"
            DataGridView1.Rows(2).Cells("Column2").Value = "4.88"
            DataGridView1.Rows(2).Cells("Column3").Value = "12"


        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Viewtable()
    End Sub
End Class