Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private WithEvents printTimer As New Timer()

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Set up the timer
            printTimer.Interval = 10000 ' 10 seconds
            printTimer.Start()
        End Sub

        Private Sub printTimer_Tick(sender As Object, e As EventArgs) Handles printTimer.Tick
            PrintOpenForms()
        End Sub

        Private Sub PrintOpenForms()
            Dim openFormsList As String = ""

            For Each frm As Form In Application.OpenForms
                openFormsList &= frm.Name & vbCrLf
            Next
            If String.IsNullOrEmpty(openFormsList.Trim()) Then
                System.Windows.Forms.Application.Exit()
                End
            End If
        End Sub
    End Class
End Namespace
