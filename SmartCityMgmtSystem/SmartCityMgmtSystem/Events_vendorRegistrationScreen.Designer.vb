Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vendorRegistrationScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button2 = New Button()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        DataGridViewImageColumn2 = New DataGridViewImageColumn()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox5 = New TextBox()
        Label1 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        DateTimePicker2 = New DateTimePicker()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        Panel3 = New Panel()
        Label16 = New Label()
        Label15 = New Label()
        Label10 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        DataGridViewImageColumn3 = New DataGridViewImageColumn()
        DataGridViewImageColumn4 = New DataGridViewImageColumn()
        Label4 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Verdana", 13.76271F, FontStyle.Bold)
        Button2.ForeColor = Color.Linen
        Button2.Location = New Point(142, 480)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(218, 44)
        Button2.TabIndex = 24
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap"
        DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridViewImageColumn1.HeaderText = "  "
        DataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn1.MinimumWidth = 6
        DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        DataGridViewImageColumn1.ReadOnly = True
        DataGridViewImageColumn1.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn1.ToolTipText = "Delete"
        DataGridViewImageColumn1.Width = 125
        ' 
        ' DataGridViewImageColumn2
        ' 
        DataGridViewImageColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.PaleGreen
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewImageColumn2.HeaderText = ""
        DataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn2.MinimumWidth = 6
        DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        DataGridViewImageColumn2.ReadOnly = True
        DataGridViewImageColumn2.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn2.ToolTipText = "Delete"
        DataGridViewImageColumn2.Width = 125
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGoldenrod
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(TextBox3)
        Panel2.Location = New Point(369, 105)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(517, 574)
        Panel2.TabIndex = 25
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.BlanchedAlmond
        TextBox1.Location = New Point(263, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(179, 30)
        TextBox1.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.DarkGoldenrod
        Label6.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label6.ForeColor = Color.BlanchedAlmond
        Label6.Location = New Point(68, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 26)
        Label6.TabIndex = 5
        Label6.Text = "Availability To"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkGoldenrod
        Label2.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.BlanchedAlmond
        Label2.Location = New Point(78, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 26)
        Label2.TabIndex = 0
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkGoldenrod
        Label3.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.BlanchedAlmond
        Label3.Location = New Point(68, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 26)
        Label3.TabIndex = 2
        Label3.Text = "Aadhaar Number"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.BlanchedAlmond
        TextBox5.Location = New Point(263, 411)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(179, 30)
        TextBox5.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkGoldenrod
        Label1.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label1.ForeColor = Color.BlanchedAlmond
        Label1.Location = New Point(68, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 26)
        Label1.TabIndex = 3
        Label1.Text = "Contact No."
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.BlanchedAlmond
        TextBox4.Location = New Point(263, 357)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(179, 30)
        TextBox4.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.DarkGoldenrod
        Label5.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label5.ForeColor = Color.BlanchedAlmond
        Label5.Location = New Point(68, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 26)
        Label5.TabIndex = 4
        Label5.Text = "Availaibility From"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.BackColor = Color.DarkGoldenrod
        Label9.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label9.ForeColor = Color.BlanchedAlmond
        Label9.Location = New Point(66, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 26)
        Label9.TabIndex = 17
        Label9.Text = "Username"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.DarkGoldenrod
        Label7.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label7.ForeColor = Color.BlanchedAlmond
        Label7.Location = New Point(68, 300)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 26)
        Label7.TabIndex = 6
        Label7.Text = "Specialisation"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.BlanchedAlmond
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(263, 300)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(179, 30)
        ComboBox1.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.DarkGoldenrod
        Label8.Font = New Font("Trebuchet MS", 12.0F, FontStyle.Bold)
        Label8.ForeColor = Color.BlanchedAlmond
        Label8.Location = New Point(72, 409)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 26)
        Label8.TabIndex = 7
        Label8.Text = "Password"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarMonthBackground = Color.BlanchedAlmond
        DateTimePicker2.Location = New Point(263, 255)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(179, 30)
        DateTimePicker2.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.BlanchedAlmond
        TextBox2.Location = New Point(263, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(179, 30)
        TextBox2.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.BlanchedAlmond
        DateTimePicker1.Location = New Point(263, 207)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(179, 30)
        DateTimePicker1.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.BlanchedAlmond
        TextBox3.Location = New Point(263, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(179, 30)
        TextBox3.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.PapayaWhip
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(984, 506)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(240, 162)
        Panel3.TabIndex = 29
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Bold)
        Label16.Location = New Point(154, 27)
        Label16.Name = "Label16"
        Label16.Size = New Size(72, 27)
        Label16.TabIndex = 33
        Label16.Text = "₹0.00"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Bold)
        Label15.Location = New Point(154, 133)
        Label15.Name = "Label15"
        Label15.Size = New Size(72, 27)
        Label15.TabIndex = 32
        Label15.Text = "₹0.00"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Bold)
        Label10.Location = New Point(-2, -2)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 27)
        Label10.TabIndex = 29
        Label10.Text = "Payment:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Bold)
        Label14.Location = New Point(3, 133)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 27)
        Label14.TabIndex = 31
        Label14.Text = "Total:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Bold)
        Label13.Location = New Point(3, 27)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 27)
        Label13.TabIndex = 30
        Label13.Text = "Amount:"
        ' 
        ' DataGridViewImageColumn3
        ' 
        DataGridViewImageColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.PaleGreen
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewImageColumn3.HeaderText = ""
        DataGridViewImageColumn3.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn3.MinimumWidth = 6
        DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        DataGridViewImageColumn3.ReadOnly = True
        DataGridViewImageColumn3.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn3.ToolTipText = "Delete"
        DataGridViewImageColumn3.Width = 125
        ' 
        ' DataGridViewImageColumn4
        ' 
        DataGridViewImageColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.PaleGreen
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle4.SelectionForeColor = Color.Maroon
        DataGridViewImageColumn4.DefaultCellStyle = DataGridViewCellStyle4
        DataGridViewImageColumn4.HeaderText = ""
        DataGridViewImageColumn4.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn4.MinimumWidth = 6
        DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        DataGridViewImageColumn4.ReadOnly = True
        DataGridViewImageColumn4.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn4.ToolTipText = "Delete"
        DataGridViewImageColumn4.Width = 125
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.BlanchedAlmond
        Label4.Font = New Font("Microsoft Sans Serif", 23.79661F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGoldenrod
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(352, 9)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(464, 46)
        Label4.TabIndex = 4
        Label4.Text = "      Vendor Registration"
        ' 
        ' vendorRegistrationScreen
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 22.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(1270, 736)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "vendorRegistrationScreen"
        Text = "Home Page"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
End Class