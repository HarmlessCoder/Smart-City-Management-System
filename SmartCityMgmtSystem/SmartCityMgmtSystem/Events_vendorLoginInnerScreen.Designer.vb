<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Events_vendorLoginInnerScreen
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        SlNo = New DataGridViewTextBoxColumn()
        CustomerID = New DataGridViewTextBoxColumn()
        TransactionID = New DataGridViewTextBoxColumn()
        Time = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Panel6 = New Panel()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Panel3 = New Panel()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        DataGridViewImageColumn1 = New DataGridViewImageColumn()
        DataGridViewImageColumn2 = New DataGridViewImageColumn()
        DataGridViewImageColumn3 = New DataGridViewImageColumn()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Verdana", 9.762712F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Linen
        Button1.Location = New Point(33, 186)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 37)
        Button1.TabIndex = 0
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(229), CByte(195), CByte(118))
        DataGridViewCellStyle1.Font = New Font("Trebuchet MS", 12.20339F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(61), CByte(37), CByte(0))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(229), CByte(195), CByte(118))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(61), CByte(37), CByte(0))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.BackgroundColor = Color.BlanchedAlmond
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(229), CByte(195), CByte(118))
        DataGridViewCellStyle2.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(229), CByte(195), CByte(118))
        DataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 47
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {SlNo, CustomerID, TransactionID, Time})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.DarkGoldenrod
        DataGridViewCellStyle6.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkGoldenrod
        DataGridViewCellStyle6.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.GridColor = Color.DimGray
        DataGridView1.Location = New Point(15, 320)
        DataGridView1.Margin = New Padding(6)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.DarkGoldenrod
        DataGridViewCellStyle7.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionBackColor = Color.DarkGoldenrod
        DataGridViewCellStyle7.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(216), CByte(178), CByte(87))
        DataGridViewCellStyle8.Font = New Font("Trebuchet MS", 12.20339F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(41), CByte(24), CByte(0))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(216), CByte(178), CByte(87))
        DataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(CByte(41), CByte(24), CByte(0))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        DataGridView1.RowTemplate.DefaultCellStyle.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(CByte(61), CByte(37), CByte(0))
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(216), CByte(215), CByte(169))
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(CByte(61), CByte(37), CByte(0))
        DataGridView1.RowTemplate.DividerHeight = 1
        DataGridView1.RowTemplate.Height = 40
        DataGridView1.RowTemplate.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1240, 410)
        DataGridView1.TabIndex = 4
        ' 
        ' SlNo
        ' 
        DataGridViewCellStyle3.BackColor = Color.Goldenrod
        DataGridViewCellStyle3.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkCyan
        DataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke
        SlNo.DefaultCellStyle = DataGridViewCellStyle3
        SlNo.HeaderText = "Sl No"
        SlNo.MinimumWidth = 6
        SlNo.Name = "SlNo"
        SlNo.ReadOnly = True
        SlNo.Resizable = DataGridViewTriState.False
        ' 
        ' CustomerID
        ' 
        DataGridViewCellStyle4.BackColor = Color.DarkCyan
        DataGridViewCellStyle4.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = Color.DarkCyan
        DataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke
        CustomerID.DefaultCellStyle = DataGridViewCellStyle4
        CustomerID.FillWeight = 70F
        CustomerID.HeaderText = "Customer ID"
        CustomerID.MinimumWidth = 6
        CustomerID.Name = "CustomerID"
        CustomerID.ReadOnly = True
        ' 
        ' TransactionID
        ' 
        DataGridViewCellStyle5.BackColor = Color.DarkCyan
        DataGridViewCellStyle5.Font = New Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkCyan
        DataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke
        TransactionID.DefaultCellStyle = DataGridViewCellStyle5
        TransactionID.FillWeight = 200F
        TransactionID.HeaderText = "Transaction ID"
        TransactionID.MinimumWidth = 6
        TransactionID.Name = "TransactionID"
        TransactionID.ReadOnly = True
        ' 
        ' Time
        ' 
        Time.HeaderText = "Date and Time"
        Time.MinimumWidth = 6
        Time.Name = "Time"
        Time.ReadOnly = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(244), CByte(215), CByte(153))
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(18, 63)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1237, 243)
        Panel1.TabIndex = 5
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(230), CByte(179))
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(TextBox4)
        Panel6.Font = New Font("Verdana", 9.762712F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel6.Location = New Point(834, 52)
        Panel6.Margin = New Padding(4, 3, 4, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(369, 51)
        Panel6.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(4, 11)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 40)
        Label7.TabIndex = 4
        Label7.Text = "TransactionID"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Verdana", 9.762712F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(157, 11)
        TextBox4.Margin = New Padding(4, 3, 4, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(208, 27)
        TextBox4.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(230), CByte(179))
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox2)
        Panel3.Font = New Font("Verdana", 9.762712F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(434, 52)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(369, 51)
        Panel3.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 12)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 27)
        Label5.TabIndex = 4
        Label5.Text = "Time"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 9.762712F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(147, 11)
        TextBox2.Margin = New Padding(4, 3, 4, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(208, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Verdana", 9.762712F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Linen
        Button2.Location = New Point(1081, 188)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 37)
        Button2.TabIndex = 4
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(502, 1)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 55)
        Label3.TabIndex = 2
        Label3.Text = "Search" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(230), CByte(179))
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Font = New Font("Verdana", 9.762712F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(33, 52)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(369, 51)
        Panel2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 9.762712F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(147, 11)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 12)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 27)
        Label1.TabIndex = 0
        Label1.Text = "Customer ID" & vbCrLf
        ' 
        ' DataGridViewImageColumn1
        ' 
        DataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.NullValue = "System.Drawing.Bitmap"
        DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = Color.PaleGreen
        DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle10.NullValue = Nothing
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle10.SelectionForeColor = Color.Maroon
        DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle10
        DataGridViewImageColumn2.HeaderText = ""
        DataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn2.MinimumWidth = 6
        DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        DataGridViewImageColumn2.ReadOnly = True
        DataGridViewImageColumn2.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn2.ToolTipText = "Delete"
        DataGridViewImageColumn2.Width = 125
        ' 
        ' DataGridViewImageColumn3
        ' 
        DataGridViewImageColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.PaleGreen
        DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle11.SelectionForeColor = Color.Maroon
        DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle11
        DataGridViewImageColumn3.HeaderText = ""
        DataGridViewImageColumn3.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewImageColumn3.MinimumWidth = 6
        DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        DataGridViewImageColumn3.Resizable = DataGridViewTriState.False
        DataGridViewImageColumn3.ToolTipText = "Delete"
        DataGridViewImageColumn3.Width = 125
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.BlanchedAlmond
        Label4.Font = New Font("Agency FB", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(21, 7)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(301, 55)
        Label4.TabIndex = 4
        Label4.Text = "Vendor Dashboard"
        ' 
        ' Events_vendorLoginInnerScreen
        ' 
        AutoScaleDimensions = New SizeF(13F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(1270, 736)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Font = New Font("Verdana", 10.98305F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Events_vendorLoginInnerScreen"
        Text = "Home Page"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents SlNo As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
End Class
