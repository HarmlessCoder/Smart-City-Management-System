Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports TransportGlobals

Public Class TransportDrivingLicenseReq
    Public Property uid As Integer = 13
    Public Property u_name As String = "Dhanesh"
    Dim pay_clicked As Integer = 0
    Private currentDlId = 1
    Function GenerateDlId() As Integer
        ' Increment the current ID value
        currentDlId += 1
        ' Return the new ID
        Return currentDlId
    End Function

    Private Sub LoadandBindData()
        'Get connection from globals
        Dim Con = Globals.GetDBConnection()
        Dim reader1, reader2 As MySqlDataReader
        Dim cmd1, cmd2 As MySqlCommand

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmd1 = New MySqlCommand("SELECT name, age, profile_photo, gender, address FROM users WHERE user_id = @a", Con)
        cmd1.Parameters.AddWithValue("@a", uid)
        reader1 = cmd1.ExecuteReader()

        ' Create a DataTable to store the data
        Dim dataTable1 As New DataTable()

        ' Fill the DataTable with data from the SQL table
        dataTable1.Load(reader1)

        ' Check if there are any rows in the DataTable
        If dataTable1.Rows.Count > 0 Then
            ' Access data from the DataTable
            Dim row As DataRow = dataTable1.Rows(0)
            Nametb.Text = Convert.ToString(row("name"))
            Agetb.Text = If(Not IsDBNull(row("age")), Convert.ToInt32(row("age")), "NULL")
            Dim Address As String = If(Not IsDBNull(row("address")), Convert.ToString(row("address")), "NULL")
            Addresstb.Text = Address

            LabelName.Text = Convert.ToString(row("name"))
            LabelAge.Text = If(Not IsDBNull(row("age")), Convert.ToInt32(row("age")), "NULL")
            LabelAddress.Text = Address
            Dim Gender As String = If(Not IsDBNull(row("gender")), Convert.ToString(row("gender")), "NULL")
            LabelGender.Text = Gender
            ' Access the profile photo as a byte array
            ' Check if the profile photo is not null
            If Not IsDBNull(row("profile_photo")) Then
                ' Access the profile photo as a byte array
                Dim profilePhotoData As Byte() = DirectCast(row("profile_photo"), Byte())

                ' Check if the profile photo data has a length greater than 0
                If profilePhotoData IsNot Nothing AndAlso profilePhotoData.Length > 0 Then
                    ' Convert the byte array to an image
                    Using ms As New System.IO.MemoryStream(profilePhotoData)
                        PictureBox1.Image = Image.FromStream(ms)
                        PictureBox2.Image = Image.FromStream(ms)
                    End Using

                Else
                    ' If the profile photo data is empty, display a default image or handle it as needed
                    PictureBox1.Image = PictureBox1.Image
                End If
            Else
                ' If the profile photo is null, display a default image or handle it as needed
                PictureBox1.Image = PictureBox1.Image
            End If
        Else
            ' Handle the case where no data is returned
            MessageBox.Show("No user data is available", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        reader1.Close()

        cmd2 = New MySqlCommand("SELECT dl_id, vehicle_type, issued_on, valid_till, test_status, fee_paid, req_type FROM dl_entries WHERE uid = @a", Con)
        cmd2.Parameters.AddWithValue("@a", uid)
        reader2 = cmd2.ExecuteReader()

        ' Create another DataTable to store the data
        Dim dataTable2 As New DataTable()

        ' Fill the second DataTable with data from the SQL table
        dataTable2.Load(reader2)

        ' Display driver's license information
        If dataTable2.Rows.Count > 0 Then
            ' Access data from the DataTable
            Dim row As DataRow = dataTable2.Rows(0)
            If Not IsDBNull(row("test_status")) Then

                Dim dlId As Integer = If(Not IsDBNull(row("dl_id")), Convert.ToInt32(row("dl_id")), "NULL")
                LabelDLID.Text = dlId
                Dim lowestissuedOn As DateTime = If(Not IsDBNull(row("issued_on")), DirectCast(row("issued_on"), DateTime), DateTime.MinValue)
                Dim highestvalidTill As DateTime = If(Not IsDBNull(row("valid_till")), DirectCast(row("valid_till"), DateTime), DateTime.MinValue)
                VTypeLB.Items.Clear()
                For Each dr As DataRow In dataTable2.Rows
                    If Convert.ToInt32(dr("fee_paid")) = 1 And Convert.ToString(dr("test_status")) = "pass" Then
                        ' Access data from the current row
                        Dim vtype_id As Integer = Convert.ToInt32(dr("vehicle_type"))
                        Dim vType As String = TransportGlobals.GetVehicleType(vtype_id)
                        VTypeLB.Items.Add(vType)
                        Dim issuedOn As DateTime = If(Not IsDBNull(dr("issued_on")), DirectCast(dr("issued_on"), DateTime), DateTime.MinValue)
                        Dim validTill As DateTime = If(Not IsDBNull(dr("valid_till")), DirectCast(dr("valid_till"), DateTime), DateTime.MinValue)
                        ' Update the highest valid_till date
                        If validTill > highestvalidTill Then
                            highestvalidTill = validTill
                        End If

                        ' Update the lowest issued_on date
                        If issuedOn < lowestissuedOn Then
                            lowestissuedOn = issuedOn
                        End If
                    End If
                Next
                LabelIssuedD.Text = lowestissuedOn.ToString()
                LabelValidTill.Text = highestvalidTill.ToString()
            End If
        End If

        reader2.Close()

        If pay_clicked = 1 Then
            Dim insertStatement As String = "INSERT INTO dl_entries (dl_id, uid, vehicle_type, fee_paid, req_type) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"


            Using command As New MySqlCommand(insertStatement, Con)
                ' Set parameter values
                command.Parameters.AddWithValue("@Value2", uid)
                Dim vtype As String = VTypeCb.SelectedItem.ToString()
                Dim vTypeid As Integer = TransportGlobals.GetVehicleTypeID(vtype)
                command.Parameters.AddWithValue("@Value3", vTypeid)
                command.Parameters.AddWithValue("@Value4", 1)
                If dataTable2.Rows.Count = 0 Then
                    Dim dlid As Integer = GenerateDlId()
                    ' Create a command object with the INSERT statement and connection
                    command.Parameters.AddWithValue("@Value1", dlid)
                    command.Parameters.AddWithValue("@Value5", "fresh")
                Else
                    Dim r As DataRow = dataTable2.Rows(0)
                    ' Set parameter values
                    command.Parameters.AddWithValue("@Value1", r("dl_id"))
                    command.Parameters.AddWithValue("@Value5", "renew")

                End If

                ' Execute the command (INSERT statement)
                command.ExecuteNonQuery()
            End Using
            pay_clicked = 0
        End If



        Con.Close()


    End Sub



    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadandBindData()

        ' Populate ComboBox with vehicle types until GetVehicleType returns non-null
        Dim vtypeid As Integer = 1
        Dim vehicleType As String = TransportGlobals.GetVehicleType(vtypeid)

        While vehicleType <> "Unknown"
            VTypeCb.Items.Add(vehicleType)
            vtypeid += 1
            vehicleType = TransportGlobals.GetVehicleType(vtypeid)
        End While
    End Sub

    Private Sub Paytb_Click(sender As Object, e As EventArgs) Handles Paytb.Click
        pay_clicked = 1
        LoadandBindData()
        MessageBox.Show("Paymeny request will be sent", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Canceltb_Click(sender As Object, e As EventArgs) Handles Canceltb.Click
        MessageBox.Show("Driving license request will not be proceeded ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub
End Class


