<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RideSharingChats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Button1 As System.Windows.Forms.Button
        Dim DataGridViewCellStyle100 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle101 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle105 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle106 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle107 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle102 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle103 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle104 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle108 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle109 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RideSharingChats))
        Dim DataGridViewCellStyle110 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PostsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.Maroon
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Verdana", 9.762712!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.ForeColor = System.Drawing.Color.Linen
        Button1.Location = New System.Drawing.Point(305, 8)
        Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(120, 37)
        Button1.TabIndex = 0
        Button1.Text = "Pay|WD"
        Button1.UseVisualStyleBackColor = False
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Location = New System.Drawing.Point(10, 63)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 656)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle100.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle100.Font = New System.Drawing.Font("Trebuchet MS", 12.20339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle100.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle100.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle100
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle101.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle101.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle101.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle101.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle101
        Me.DataGridView1.ColumnHeadersHeight = 47
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Approve})
        DataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle105.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle105.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle105.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle105.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle105.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle105.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle105
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(9, 54)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle106.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle106.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle106.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle106.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle106
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle107.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle107.Font = New System.Drawing.Font("Trebuchet MS", 12.20339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle107.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle107.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle107.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle107
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowTemplate.DividerHeight = 1
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(417, 596)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        DataGridViewCellStyle102.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle102.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle102.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle102
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        DataGridViewCellStyle103.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle103.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle103.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle103
        Me.Column2.FillWeight = 200.0!
        Me.Column2.HeaderText = "Payment"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Approve
        '
        Me.Approve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle104.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle104.NullValue = False
        DataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Approve.DefaultCellStyle = DataGridViewCellStyle104
        Me.Approve.HeaderText = "Approve"
        Me.Approve.MinimumWidth = 6
        Me.Approve.Name = "Approve"
        Me.Approve.ReadOnly = True
        Me.Approve.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Approve.ToolTipText = "Delete"
        Me.Approve.Width = 101
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.762712!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Linen
        Me.Button2.Location = New System.Drawing.Point(1081, 188)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT Condensed", 18.30509!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Riders List and Status"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle108.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle108
        Me.DataGridViewImageColumn1.HeaderText = "  "
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Delete"
        Me.DataGridViewImageColumn1.Width = 123
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle109.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle109.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle109.NullValue = CType(resources.GetObject("DataGridViewCellStyle109.NullValue"), Object)
        DataGridViewCellStyle109.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle109.SelectionForeColor = System.Drawing.Color.Maroon
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle109
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Delete"
        Me.DataGridViewImageColumn2.Width = 123
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle110.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle110.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle110.NullValue = CType(resources.GetObject("DataGridViewCellStyle110.NullValue"), Object)
        DataGridViewCellStyle110.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle110.SelectionForeColor = System.Drawing.Color.Maroon
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle110
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_edit_40
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.MinimumWidth = 6
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn3.ToolTipText = "Delete"
        Me.DataGridViewImageColumn3.Width = 123
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 23.79661!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_secretary_48
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(13, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 46)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "      Ride Sharing Chats"
        '
        'PostsPanel
        '
        Me.PostsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PostsPanel.AutoScroll = True
        Me.PostsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PostsPanel.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.PostsPanel.Location = New System.Drawing.Point(451, 7)
        Me.PostsPanel.Name = "PostsPanel"
        Me.PostsPanel.Size = New System.Drawing.Size(814, 712)
        Me.PostsPanel.TabIndex = 7
        Me.PostsPanel.WrapContents = False
        '
        'RideSharingChats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1270, 736)
        Me.Controls.Add(Me.PostsPanel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RideSharingChats"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Chats"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents PostsPanel As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Approve As DataGridViewCheckBoxColumn
End Class
