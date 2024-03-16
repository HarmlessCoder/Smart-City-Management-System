<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BankingDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.childformPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.childformPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 11.8209!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 783)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.13559!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MistyRose
        Me.Label1.Location = New System.Drawing.Point(4, 674)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SmartGhy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Banking Department"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'childformPanel
        '
        Me.childformPanel.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.childformPanel.Controls.Add(Me.PictureBox2)
        Me.childformPanel.Controls.Add(Me.Label8)
        Me.childformPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childformPanel.Location = New System.Drawing.Point(278, 42)
        Me.childformPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.childformPanel.Name = "childformPanel"
        Me.childformPanel.Size = New System.Drawing.Size(1276, 740)
        Me.childformPanel.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(571, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 72)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Banking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.0339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Ivory
        Me.Label3.Location = New System.Drawing.Point(885, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "{Aadhar No.}"
        '
        'Button6
        '
        Me.Button6.CausesValidation = False
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Agency FB", 14.0339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Ivory
        Me.Button6.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_back_arrow_25
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1388, 0)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(163, 39)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "      Home Page"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_user_shield_48
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(313, 5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 36)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "         {Name}"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.81356!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.iconBankAccountProfile
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(4, 195)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(319, 61)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Account Details"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.81356!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icon_paybills
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(4, 396)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(248, 61)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Pay Bills"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.SMART_CITY___GUWAHATI
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.81356!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icon_view_transactions
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(4, 329)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(353, 61)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "View Transactions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.81356!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_tollbooth_50
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(13, 463)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(344, 61)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Reacharge Fasttag"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.81356!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icon_checkbalance
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(4, 262)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(304, 61)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Check Balance"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.HomePageBank
        Me.PictureBox2.Location = New System.Drawing.Point(425, 158)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(460, 436)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'BankingDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ClientSize = New System.Drawing.Size(1552, 779)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.childformPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "BankingDashboard"
        Me.Text = "Transportation"
        Me.Panel1.ResumeLayout(False)
        Me.childformPanel.ResumeLayout(False)
        Me.childformPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents childformPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
