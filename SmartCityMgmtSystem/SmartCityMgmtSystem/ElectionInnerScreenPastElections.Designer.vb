<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ElectionInnerScreenPastElections
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
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.NullValue = "System.Drawing.Bitmap"
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewImageColumn1.HeaderText = "  "
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Delete"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle24.NullValue = Nothing
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Maroon
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Delete"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Past Elections"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_politician_96
        Me.PictureBox1.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle25.NullValue = Nothing
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Maroon
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_edit_40
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.MinimumWidth = 6
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn3.ToolTipText = "Delete"
        Me.DataGridViewImageColumn3.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Trebuchet MS", 12.20339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView1.ColumnHeadersHeight = 47
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGridView1.Location = New System.Drawing.Point(62, 194)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Trebuchet MS", 12.20339!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.RowTemplate.DividerHeight = 1
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1142, 410)
        Me.DataGridView1.TabIndex = 23
        '
        'Column1
        '
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle28
        Me.Column1.HeaderText = "Position"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle29
        Me.Column2.FillWeight = 70.0!
        Me.Column2.HeaderText = "Candidate Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle30
        Me.Column3.FillWeight = 200.0!
        Me.Column3.HeaderText = "Votes Received"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Turnout for Position"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(603, 124)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 30)
        Me.ComboBox1.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(391, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 45)
        Me.Panel1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Year"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(524, 637)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 46)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1100, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 43)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ElectionInnerScreenPastElections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1270, 736)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Verdana", 10.98305!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ElectionInnerScreenPastElections"
        Me.Text = "Home Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
