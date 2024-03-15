<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FastagPlanItem
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
        Me.btnview = New System.Windows.Forms.Button()
        Me.lblfare = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnview.Location = New System.Drawing.Point(505, 0)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(67, 120)
        Me.btnview.TabIndex = 9
        Me.btnview.UseVisualStyleBackColor = False
        '
        'lblfare
        '
        Me.lblfare.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfare.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_cash_30
        Me.lblfare.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblfare.Location = New System.Drawing.Point(161, 79)
        Me.lblfare.Name = "lblfare"
        Me.lblfare.Size = New System.Drawing.Size(132, 33)
        Me.lblfare.TabIndex = 5
        Me.lblfare.Text = "       ₹150"
        Me.lblfare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_steering_wheel_301
        Me.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblname.Location = New System.Drawing.Point(161, 43)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(244, 33)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "       Light Four Wheelers"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picbox
        '
        Me.picbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox.BackColor = System.Drawing.Color.Transparent
        Me.picbox.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.Fatstag
        Me.picbox.Location = New System.Drawing.Point(0, 0)
        Me.picbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(155, 120)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'lbldt
        '
        Me.lbldt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldt.Font = New System.Drawing.Font("Trebuchet MS", 10.98305!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_calender_301
        Me.lbldt.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbldt.Location = New System.Drawing.Point(313, 79)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(208, 33)
        Me.lbldt.TabIndex = 7
        Me.lbldt.Text = "        3 Months Validity"
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(161, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fastag Plan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FastagPlanItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblfare)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.picbox)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FastagPlanItem"
        Me.Size = New System.Drawing.Size(572, 120)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbox As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblfare As Label
    Friend WithEvents btnview As Button
    Friend WithEvents lbldt As Label
    Friend WithEvents Label1 As Label
End Class
