Public Class Healthcare_homepage
    Private Sub book_appointment_Click(sender As Object, e As EventArgs) Handles book_appointment.Click
        ' Navigate to hc_B_Appointment page
        Dim appointmentPage As New hc_B_Appointment()
        appointmentPage.Show()
        Me.Hide()
    End Sub

    Private Sub pharmacy_Click(sender As Object, e As EventArgs) Handles pharmacy.Click
        ' Navigate to hc_Pharmacy page
        Dim pharmacyPage As New hc_Pharmacy()
        pharmacyPage.Show()
        Me.Hide()
    End Sub

    Private Sub donate_blood_Click(sender As Object, e As EventArgs) Handles donate_blood.Click
        ' Navigate to hc_Donate_Blood page
        Dim donateBloodPage As New hc_Donate_Blood()
        donateBloodPage.Show()
        Me.Hide()
    End Sub

    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        ' Navigate to hc_History page
        Dim historyPage As New hc_History()
        historyPage.Show()
        Me.Hide()
    End Sub

    Private Sub emergency_Click(sender As Object, e As EventArgs) Handles emergency.Click
        ' Navigate to hc_Emergency page (if you have one)
        ' Add similar logic for emergency page if needed
    End Sub
End Class
