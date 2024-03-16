<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransportRSReqPost
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components1 IsNot Nothing Then
                components1.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components1 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnactionreject = New System.Windows.Forms.Button()
        Me.btnactionaccept = New System.Windows.Forms.Button()
        Me.lbldlid = New System.Windows.Forms.Label()
        Me.lblvid = New System.Windows.Forms.Label()
        Me.lblpname = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblcapacity = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.lbldname = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnactionreject
        '
        Me.btnactionreject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnactionreject.BackColor = System.Drawing.Color.OrangeRed
        Me.btnactionreject.BackgroundImage = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_cross_30
        Me.btnactionreject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnactionreject.FlatAppearance.BorderSize = 0
        Me.btnactionreject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactionreject.Location = New System.Drawing.Point(576, 0)
        Me.btnactionreject.Name = "btnactionreject"
        Me.btnactionreject.Size = New System.Drawing.Size(38, 209)
        Me.btnactionreject.TabIndex = 14
        Me.btnactionreject.UseVisualStyleBackColor = False
        '
        'btnactionaccept
        '
        Me.btnactionaccept.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnactionaccept.BackColor = System.Drawing.Color.Green
        Me.btnactionaccept.BackgroundImage = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_tick_30
        Me.btnactionaccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnactionaccept.FlatAppearance.BorderSize = 0
        Me.btnactionaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactionaccept.Location = New System.Drawing.Point(540, 0)
        Me.btnactionaccept.Name = "btnactionaccept"
        Me.btnactionaccept.Size = New System.Drawing.Size(38, 209)
        Me.btnactionaccept.TabIndex = 13
        Me.btnactionaccept.UseVisualStyleBackColor = False
        '
        'lbldlid
        '
        Me.lbldlid.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldlid.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_driving_license_501
        Me.lbldlid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbldlid.Location = New System.Drawing.Point(127, 113)
        Me.lbldlid.Name = "lbldlid"
        Me.lbldlid.Size = New System.Drawing.Size(174, 33)
        Me.lbldlid.TabIndex = 12
        Me.lbldlid.Text = "           {DL ID} "
        Me.lbldlid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblvid
        '
        Me.lblvid.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvid.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_vehicle_48
        Me.lblvid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblvid.Location = New System.Drawing.Point(127, 62)
        Me.lblvid.Name = "lblvid"
        Me.lblvid.Size = New System.Drawing.Size(174, 33)
        Me.lblvid.TabIndex = 11
        Me.lblvid.Text = "          {Vehicle ID} "
        Me.lblvid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpname
        '
        Me.lblpname.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpname.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_passenger_48
        Me.lblpname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblpname.Location = New System.Drawing.Point(320, 8)
        Me.lblpname.Name = "lblpname"
        Me.lblpname.Size = New System.Drawing.Size(214, 33)
        Me.lblpname.TabIndex = 10
        Me.lblpname.Text = "       {Passenger Name} "
        Me.lblpname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldt
        '
        Me.lbldt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldt.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_calender_301
        Me.lbldt.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbldt.Location = New System.Drawing.Point(329, 62)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(208, 33)
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
        Me.lblcapacity.Location = New System.Drawing.Point(329, 113)
        Me.lblcapacity.Name = "lblcapacity"
        Me.lblcapacity.Size = New System.Drawing.Size(158, 33)
        Me.lblcapacity.TabIndex = 6
        Me.lblcapacity.Text = "       {Seats left}"
        Me.lblcapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblto
        '
        Me.lblto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblto.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_location_30
        Me.lblto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblto.Location = New System.Drawing.Point(360, 162)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(177, 33)
        Me.lblto.TabIndex = 4
        Me.lblto.Text = "      {To Place} "
        Me.lblto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_arrow_30
        Me.Label3.Location = New System.Drawing.Point(285, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblfrom
        '
        Me.lblfrom.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_location_30
        Me.lblfrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblfrom.Location = New System.Drawing.Point(127, 162)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(184, 33)
        Me.lblfrom.TabIndex = 2
        Me.lblfrom.Text = "      {From Place} "
        Me.lblfrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldname
        '
        Me.lbldname.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldname.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_steering_wheel_30
        Me.lbldname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbldname.Location = New System.Drawing.Point(127, 8)
        Me.lbldname.Name = "lbldname"
        Me.lbldname.Size = New System.Drawing.Size(174, 33)
        Me.lbldname.TabIndex = 1
        Me.lbldname.Text = "       {Driver Name} "
        Me.lbldname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.picbox.Size = New System.Drawing.Size(102, 192)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'TransportRSReqPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Controls.Add(Me.btnactionreject)
        Me.Controls.Add(Me.btnactionaccept)
        Me.Controls.Add(Me.lbldlid)
        Me.Controls.Add(Me.lblvid)
        Me.Controls.Add(Me.lblpname)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblcapacity)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.lbldname)
        Me.Controls.Add(Me.picbox)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TransportRSReqPost"
        Me.Size = New System.Drawing.Size(614, 209)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbox As PictureBox
    Friend WithEvents lbldname As Label
    Friend WithEvents lblfrom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblto As Label
    Friend WithEvents lblcapacity As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents lblpname As Label
    Friend WithEvents lblvid As Label
    Friend WithEvents lbldlid As Label
    Friend WithEvents btnactionaccept As Button
    Friend WithEvents btnactionreject As Button
End Class
