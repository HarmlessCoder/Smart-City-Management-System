Imports System.Data.SqlClient
Imports System.DirectoryServices
Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Crypto.Agreement.Srp
Imports SmartCityMgmtSystem.RideSharingMain
Public Class TransportationBusSchedulesAdmin
    Private primaryKeyEdit As String ' Define a class-level variable to hold the primary key of the row being edited
    Private Sub ShowEditOption(ByVal txt As String)
        Label3.Text = "Update Bus Schedule"
        Button3.Text = "Update"
        Using conn As New MySqlConnection(Globals.getdbConnectionString())
            conn.Open()

            Dim query As String = "SELECT bs.bus_no,bs.days_operating,bs.starting_time,bs.bus_fare,bs.capacity,src.place_name AS src,dest.place_name AS dest FROM bus_schedules bs JOIN placedb src ON bs.src_id = src.id JOIN placedb dest ON bs.dest_id = dest.id where bus_no = " + txt
            Using command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        TextBox6.Text = txt 'Bus Number
                        TextBox3.Text = reader.GetTimeSpan("starting_time").ToString() ' Bus pickup time
                        Dim temp As Integer = reader.GetInt16("days_operating")
                        Dim binary As String = Convert.ToString(temp, 2)
                        binary = binary.PadLeft(7, "0").Substring(0, 7)
                        If (binary(0) = "1") Then
                            CheckBox1.Checked = True
                        End If
                        If (binary(1) = "1") Then
                            CheckBox2.Checked = True
                        End If
                        If (binary(2) = "1") Then
                            CheckBox3.Checked = True
                        End If
                        If (binary(3) = "1") Then
                            CheckBox4.Checked = True
                        End If
                        If (binary(4) = "1") Then
                            CheckBox5.Checked = True
                        End If
                        If (binary(5) = "1") Then
                            CheckBox6.Checked = True
                        End If
                        If (binary(6) = "1") Then
                            CheckBox7.Checked = True
                        End If
                        ComboBox2.SelectedValue = reader.GetString("dest") 'Destination
                        Dim displayMemberValueToSet As String = reader.GetString("src")

                        ' Iterate through the items in the ComboBox
                        For Each item As Object In ComboBox1.Items
                            ' Assuming your display member property is "DisplayMember"
                            ' You might need to replace it with the actual property name
                            Dim displayMemberValue As String = item.GetType().GetProperty("Name").GetValue(item).ToString()

                            ' Check if the display member value matches the desired value
                            If displayMemberValue = displayMemberValueToSet Then
                                ' Set the item as the selected item
                                ComboBox1.SelectedItem = item
                                Exit For ' Exit the loop once the value is found
                            End If
                        Next

                        displayMemberValueToSet = reader.GetString("dest")
                        For Each item As Object In ComboBox2.Items
                            ' Assuming your display member property is "DisplayMember"
                            ' You might need to replace it with the actual property name
                            Dim displayMemberValue As String = item.GetType().GetProperty("Name").GetValue(item).ToString()

                            ' Check if the display member value matches the desired value
                            If displayMemberValue = displayMemberValueToSet Then
                                ' Set the item as the selected item
                                ComboBox2.SelectedItem = item
                                Exit For ' Exit the loop once the value is found
                            End If
                        Next

                        TextBox8.Text = reader.GetInt16("bus_fare") 'Fare
                        TextBox7.Text = reader.GetInt16("capacity") 'Capacity
                    End While
                End Using
            End Using
        End Using




    End Sub

    ' Function to retrieve place data from the database
    Private Function GetPlacesFromDatabase() As List(Of Place)
        Dim places As New List(Of Place)()

        Using conn As New MySqlConnection(Globals.getdbConnectionString())
            conn.Open()

            Dim query As String = "SELECT * FROM placedb"
            Using command As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32("id")
                        Dim name As String = reader.GetString("place_name")
                        Dim place As New Place(id, name)
                        places.Add(place)
                    End While
                End Using
            End Using
        End Using

        Return places
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked cell is in the "EditBut" column and not a header cell
        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index AndAlso e.RowIndex >= 0 Then
            'Show Edit Option
            primaryKeyEdit = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            ShowEditOption(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Check if the clicked cell is in the "DeleteBut" column and not a header cell
        ElseIf e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index AndAlso e.RowIndex >= 0 Then
            ' Perform the action for the "DeleteButton" column
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Call a method to delete the row from the database using the primary key
                Dim success As Boolean = Globals.ExecuteDeleteQuery("DELETE FROM bus_schedules where bus_no = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value)

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
        Dim temp, i As Integer
        Dim binary, ans As String

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmd = New MySqlCommand("SELECT bs.bus_no,bs.days_operating,bs.starting_time,src.place_name AS src,dest.place_name AS dest FROM bus_schedules bs JOIN placedb src ON bs.src_id = src.id JOIN placedb dest ON bs.dest_id = dest.id", Con)
        reader = cmd.ExecuteReader
        ' Create a DataTable to store the data
        Dim dataTable As New DataTable()
        DataGridView1.Rows.Clear()

        ans = ""
        i = 0
        While (reader.Read())
            Dim row As New DataGridViewRow()
            DataGridView1.Rows.Add(row)
            temp = reader.GetInt16("days_operating")
            binary = Convert.ToString(temp, 2)
            binary = binary.PadLeft(7, "0").Substring(0, 7)
            If (binary(0) = "1") Then
                ans += "Mon "
            End If
            If (binary(1) = "1") Then
                ans += "Tue "
            End If
            If (binary(2) = "1") Then
                ans += "Wed "
            End If
            If (binary(3) = "1") Then
                ans += "Thu "
            End If
            If (binary(4) = "1") Then
                ans += "Fri "
            End If
            If (binary(5) = "1") Then
                ans += "Sat "
            End If
            If (binary(6) = "1") Then
                ans += "Sun "
            End If
            If ans = "" Then
                ans = "None"
            End If
            DataGridView1.Rows(i).Cells("Column2").Value = ans
            DataGridView1.Rows(i).Cells("Column1").Value = reader.GetInt16("bus_no")
            DataGridView1.Rows(i).Cells("Column3").Value = reader.GetTimeSpan("starting_time")
            DataGridView1.Rows(i).Cells("Column4").Value = reader.GetString("src")
            DataGridView1.Rows(i).Cells("Column5").Value = reader.GetString("dest")
            ans = ""
            i = i + 1
        End While

        'Fill the DataTable with data from the SQL table
        reader.Close()
        Con.Close()
    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load the places from database and populate the combobox
        Dim places As List(Of Place) = GetPlacesFromDatabase()
        'To bind the places as their names in the combobox and their IDs as values
        ComboBox1.DataSource = places.ToList()
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "ID"

        ComboBox2.DataSource = places.ToList()
        ComboBox2.DisplayMember = "Name"
        ComboBox2.ValueMember = "ID"

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1

        LoadandBindDataGridView()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Prevent selecting the same place in both ComboBoxes
        Dim selectedPlace1 As Place = DirectCast(ComboBox1.SelectedItem, Place)
        Dim selectedPlace2 As Place = DirectCast(ComboBox2.SelectedItem, Place)

        If selectedPlace1 IsNot Nothing AndAlso selectedPlace2 IsNot Nothing AndAlso selectedPlace1.ID = selectedPlace2.ID Then
            ComboBox2.SelectedIndex = -1 ' Clear selection from ComboBox2
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Prevent selecting the same place in both ComboBoxes
        Dim selectedPlace1 As Place = DirectCast(ComboBox1.SelectedItem, Place)
        Dim selectedPlace2 As Place = DirectCast(ComboBox2.SelectedItem, Place)

        If selectedPlace1 IsNot Nothing AndAlso selectedPlace2 IsNot Nothing AndAlso selectedPlace1.ID = selectedPlace2.ID Then
            ComboBox1.SelectedIndex = -1 ' Clear selection from ComboBox1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Add New Bus Schedule"
        Button3.Text = "Add"
        TextBox6.Clear()
        TextBox3.Clear()
        TextBox8.Clear()
        TextBox7.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TextBox6.Text) Then
            MessageBox.Show("Please enter some input in the Bus Number textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            TextBox6.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please enter some input in the Pickup time textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            TextBox3.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox8.Text) Then
            MessageBox.Show("Please enter some input in the Fare textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            TextBox8.Clear()
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox7.Text) Then
            MessageBox.Show("Please enter some input in the Seats textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            TextBox7.Clear()
            Return
        End If
        If ComboBox1.SelectedIndex = -1 Then
            ' No item is selected
            MessageBox.Show("No Source is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            ComboBox1.SelectedIndex = -1
        End If
        If ComboBox2.SelectedIndex = -1 Then
            ' No item is selected
            MessageBox.Show("No Destination is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
            ComboBox2.SelectedIndex = -1
        End If
        If Button3.Text = "Update" Then
            Dim cmd As String

            Dim bitString As String = "0000000"
            If CheckBox1.Checked = True Then
                bitString = bitString.Remove(0, 1).Insert(0, "1")
            End If
            If CheckBox2.Checked = True Then
                bitString = bitString.Remove(1, 1).Insert(1, "1")
            End If
            If CheckBox3.Checked = True Then
                bitString = bitString.Remove(2, 1).Insert(2, "1")
            End If
            If CheckBox4.Checked = True Then
                bitString = bitString.Remove(3, 1).Insert(3, "1")
            End If
            If CheckBox5.Checked = True Then
                bitString = bitString.Remove(4, 1).Insert(4, "1")
            End If
            If CheckBox6.Checked = True Then
                bitString = bitString.Remove(5, 1).Insert(5, "1")
            End If
            If CheckBox7.Checked = True Then
                bitString = bitString.Remove(6, 1).Insert(6, "1")
            End If

            Dim decimalValue As Integer = Convert.ToInt32(bitString, 2)

            cmd = "UPDATE bus_schedules SET bus_no = '" & TextBox6.Text & "', starting_time = '" & TextBox3.Text & "', days_operating = " & decimalValue.ToString() & ", src_id = " & ComboBox1.SelectedValue & ", dest_id = " & ComboBox2.SelectedValue & ", bus_fare = '" & TextBox8.Text & "', capacity = '" & TextBox7.Text & "' WHERE bus_no = " & primaryKeyEdit

            'cmd = "UPDATE bus_schedules SET bus_no = '" & TextBox6.Text & "' starting_time = '" & TextBox3.Text & "' days_operating = " & decimalValue.ToString() & " src_id = " & ComboBox1.SelectedValue & " dest_id = " & ComboBox2.SelectedValue & " bus_fare = '" & TextBox8.Text & "' capacity = '" & TextBox7.Text & "'WHERE id =" & primaryKeyEdit
            'cmd = "UPDATE bus_schedules SET bus_no = " & TextBox6.Text & " starting_time = " & TextBox3.Text & " days_operating = " & decimalValue.ToString() & " src_id = " & ComboBox1.SelectedValue & " dest_id = " & ComboBox2.SelectedValue & " bus_fare = " & TextBox8.Text & " capacity = " & TextBox7.Text & "WHERE id =" & primaryKeyEdit
            Dim success As Boolean = Globals.ExecuteUpdateQuery(cmd)
                If success Then
                    LoadandBindDataGridView()
                End If
            Label3.Text = "Add New Bus Schedule"
            Button3.Text = "Add"
                TextBox6.Clear()
                TextBox3.Clear()
                TextBox8.Clear()
                TextBox7.Clear()
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                Else
            Dim cmd As String

            Dim bitString As String = "0000000"
            If CheckBox1.Checked = True Then
                bitString = bitString.Remove(0, 1).Insert(0, "1")
            End If
            If CheckBox2.Checked = True Then
                bitString = bitString.Remove(1, 1).Insert(1, "1")
            End If
            If CheckBox3.Checked = True Then
                bitString = bitString.Remove(2, 1).Insert(2, "1")
            End If
            If CheckBox4.Checked = True Then
                bitString = bitString.Remove(3, 1).Insert(3, "1")
            End If
            If CheckBox5.Checked = True Then
                bitString = bitString.Remove(4, 1).Insert(4, "1")
            End If
            If CheckBox6.Checked = True Then
                bitString = bitString.Remove(5, 1).Insert(5, "1")
            End If
            If CheckBox7.Checked = True Then
                bitString = bitString.Remove(6, 1).Insert(6, "1")
            End If

            Dim decimalValue As Integer = Convert.ToInt32(bitString, 2)
            cmd = "INSERT into bus_schedules (bus_no,starting_time,days_operating,src_id,dest_id,bus_fare,capacity) VALUES ('" & TextBox6.Text & "','" & TextBox3.Text & "'," & decimalValue.ToString() & "," & ComboBox1.SelectedValue & "," & ComboBox2.SelectedValue & ",'" & TextBox8.Text & "','" & TextBox7.Text & "')"
            Dim success As Boolean = Globals.ExecuteInsertQuery(cmd)
                If success Then
                    LoadandBindDataGridView()
                End If
                TextBox6.Clear()
                TextBox3.Clear()
                TextBox8.Clear()
                TextBox7.Clear()
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
        End If
    End Sub
End Class