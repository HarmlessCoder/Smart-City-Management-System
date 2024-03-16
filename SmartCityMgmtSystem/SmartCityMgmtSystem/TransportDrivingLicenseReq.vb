Imports System.Data.SqlClient
Public Class TransportDrivingLicenseReq



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


    End Sub

    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Paytb_Click(sender As Object, e As EventArgs) Handles Paytb.Click
        MessageBox.Show("Paymeny request will be sent", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Canceltb_Click(sender As Object, e As EventArgs) Handles Canceltb.Click
        MessageBox.Show("Driving license request will be cancelled ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub
End Class


