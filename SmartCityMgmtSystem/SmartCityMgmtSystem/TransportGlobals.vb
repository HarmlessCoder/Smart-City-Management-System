Public Class TransportGlobals
    ' Dictionary to store vehicle ID to vehicle type mapping
    Private Shared vehicleTypeMap As New Dictionary(Of Integer, String) From {
        {1, "Sedan"},
        {2, "SUV"},
        {3, "Bike"},
        {4, "Scooty"},
        {5, "Truck"},
        {6, "Bus"},
        {7, "Hatchback"}
    }

    ' Function to retrieve vehicle type based on vehicle ID
    Public Shared Function GetVehicleType(ByVal vehicleID As Integer) As String
        ' Check if the dictionary contains the vehicle ID
        If vehicleTypeMap.ContainsKey(vehicleID) Then
            ' Return the corresponding vehicle type
            Return vehicleTypeMap(vehicleID)
        Else
            ' Handle the case where the vehicle ID is not found (e.g., return a default value or throw an exception)
            Return "Unknown"
        End If
    End Function
End Class
