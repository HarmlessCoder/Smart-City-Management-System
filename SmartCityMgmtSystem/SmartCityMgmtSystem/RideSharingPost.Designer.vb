<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RideSharingPost
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblcapacity = New System.Windows.Forms.Label()
        Me.lblfare = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldt
        '
        Me.lbldt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldt.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_calender_301
        Me.lbldt.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbldt.Location = New System.Drawing.Point(297, 3)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(231, 33)
        Me.lbldt.TabIndex = 7
        Me.lbldt.Text = "        {Date and Time}"
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcapacity
        '
        Me.lblcapacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcapacity.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapacity.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_group_30
        Me.lblcapacity.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcapacity.Location = New System.Drawing.Point(302, 85)
        Me.lblcapacity.Name = "lblcapacity"
        Me.lblcapacity.Size = New System.Drawing.Size(158, 33)
        Me.lblcapacity.TabIndex = 6
        Me.lblcapacity.Text = "       {Seats left}"
        Me.lblcapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfare
        '
        Me.lblfare.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfare.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_cash_30
        Me.lblfare.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblfare.Location = New System.Drawing.Point(121, 85)
        Me.lblfare.Name = "lblfare"
        Me.lblfare.Size = New System.Drawing.Size(158, 33)
        Me.lblfare.TabIndex = 5
        Me.lblfare.Text = "       ₹{Rupee}"
        Me.lblfare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblto
        '
        Me.lblto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblto.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblto.Location = New System.Drawing.Point(358, 32)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(170, 55)
        Me.lblto.TabIndex = 4
        Me.lblto.Text = "{To Place} "
        Me.lblto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_arrow_30
        Me.Label3.Location = New System.Drawing.Point(283, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblfrom
        '
        Me.lblfrom.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblfrom.Location = New System.Drawing.Point(153, 32)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(138, 59)
        Me.lblfrom.TabIndex = 2
        Me.lblfrom.Text = "{From Place} "
        Me.lblfrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_steering_wheel_301
        Me.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblname.Location = New System.Drawing.Point(117, 4)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(174, 33)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "       {Driver Name} "
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picbox
        '
        Me.picbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox.BackColor = System.Drawing.Color.Cornsilk
        Me.picbox.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_driver_48
        Me.picbox.Location = New System.Drawing.Point(9, 8)
        Me.picbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(102, 107)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'btnview
        '
        Me.btnview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnview.BackColor = System.Drawing.Color.Maroon
        Me.btnview.BackgroundImage = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_next_30
        Me.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnview.FlatAppearance.BorderSize = 0
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Location = New System.Drawing.Point(534, 0)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(38, 124)
        Me.btnview.TabIndex = 9
        Me.btnview.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_location_30
        Me.PictureBox1.Location = New System.Drawing.Point(121, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 32)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_location_30
        Me.PictureBox2.Location = New System.Drawing.Point(326, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 32)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'RideSharingPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblcapacity)
        Me.Controls.Add(Me.lblfare)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.picbox)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RideSharingPost"
        Me.Size = New System.Drawing.Size(572, 124)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbox As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblfrom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblto As Label
    Friend WithEvents lblfare As Label
    Friend WithEvents lblcapacity As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents btnview As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
