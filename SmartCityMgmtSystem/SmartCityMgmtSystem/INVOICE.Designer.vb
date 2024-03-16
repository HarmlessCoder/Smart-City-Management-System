<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        TRANSACTIONID = New DataGridViewTextBoxColumn()
        RATE = New DataGridViewTextBoxColumn()
        DAYS = New DataGridViewTextBoxColumn()
        AMOUNT = New DataGridViewTextBoxColumn()
        Label7 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        eventID = New Label()
        vendorID = New Label()
        Label12 = New Label()
        bank = New Label()
        account = New Label()
        subtotal = New Label()
        tax = New Label()
        total = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 55)
        Label1.TabIndex = 0
        Label1.Text = "INVOICE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 14.0F)
        Label2.Location = New Point(66, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 28)
        Label2.TabIndex = 1
        Label2.Text = "Billed To"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(66, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 28)
        Label3.TabIndex = 2
        Label3.Text = "Pay To"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(66, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 28)
        Label5.TabIndex = 4
        Label5.Text = "Account Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(66, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 28)
        Label6.TabIndex = 5
        Label6.Text = "Bank"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(202, 399)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {TRANSACTIONID, RATE, DAYS, AMOUNT})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.GridColor = SystemColors.Info
        DataGridView1.Location = New Point(37, 341)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.Size = New Size(514, 137)
        DataGridView1.TabIndex = 8
        ' 
        ' TRANSACTIONID
        ' 
        TRANSACTIONID.HeaderText = "TRANSACTION ID"
        TRANSACTIONID.MinimumWidth = 6
        TRANSACTIONID.Name = "TRANSACTIONID"
        TRANSACTIONID.Width = 125
        ' 
        ' RATE
        ' 
        RATE.HeaderText = "RATE"
        RATE.MinimumWidth = 6
        RATE.Name = "RATE"
        RATE.Width = 125
        ' 
        ' DAYS
        ' 
        DAYS.HeaderText = "DAYS"
        DAYS.MinimumWidth = 6
        DAYS.Name = "DAYS"
        DAYS.Width = 125
        ' 
        ' AMOUNT
        ' 
        AMOUNT.HeaderText = "AMOUNT"
        AMOUNT.MinimumWidth = 6
        AMOUNT.Name = "AMOUNT"
        AMOUNT.Width = 125
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(61, 489)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 28)
        Label7.TabIndex = 9
        Label7.Text = "Sub Total "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(231, 489)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 28)
        Label9.TabIndex = 10
        Label9.Text = "Tax"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Agency FB", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(384, 481)
        Label10.Name = "Label10"
        Label10.Size = New Size(76, 36)
        Label10.TabIndex = 11
        Label10.Text = "TOTAL "
        ' 
        ' eventID
        ' 
        eventID.AutoSize = True
        eventID.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventID.Location = New Point(202, 90)
        eventID.Name = "eventID"
        eventID.Size = New Size(126, 24)
        eventID.TabIndex = 12
        eventID.Text = "432790,Customer_1"
        ' 
        ' vendorID
        ' 
        vendorID.AutoSize = True
        vendorID.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        vendorID.Location = New Point(202, 138)
        vendorID.Name = "vendorID"
        vendorID.Size = New Size(115, 72)
        vendorID.TabIndex = 13
        vendorID.Text = "1235890,Vendor_1" & vbCrLf & "Bharalumukh," & vbCrLf & "Guwahati-781009"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(202, 187)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 24)
        Label12.TabIndex = 14
        ' 
        ' bank
        ' 
        bank.AutoSize = True
        bank.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bank.Location = New Point(202, 265)
        bank.Name = "bank"
        bank.Size = New Size(73, 24)
        bank.TabIndex = 15
        bank.Text = "ABCD Bank"
        ' 
        ' account
        ' 
        account.AutoSize = True
        account.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        account.Location = New Point(202, 305)
        account.Name = "account"
        account.Size = New Size(82, 24)
        account.TabIndex = 16
        account.Text = "xxx-xxx-xxxx"
        ' 
        ' subtotal
        ' 
        subtotal.AutoSize = True
        subtotal.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subtotal.Location = New Point(150, 493)
        subtotal.Name = "subtotal"
        subtotal.Size = New Size(52, 24)
        subtotal.TabIndex = 17
        subtotal.Text = "₹4096"
        ' 
        ' tax
        ' 
        tax.AutoSize = True
        tax.Font = New Font("Agency FB", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tax.Location = New Point(273, 493)
        tax.Name = "tax"
        tax.Size = New Size(29, 24)
        tax.TabIndex = 18
        tax.Text = "138"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Font = New Font("Agency FB", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total.Location = New Point(470, 481)
        total.Name = "total"
        total.Size = New Size(81, 36)
        total.TabIndex = 19
        total.Text = "₹4234"
        ' 
        ' Invoice
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(582, 553)
        Controls.Add(total)
        Controls.Add(tax)
        Controls.Add(subtotal)
        Controls.Add(account)
        Controls.Add(bank)
        Controls.Add(Label12)
        Controls.Add(vendorID)
        Controls.Add(eventID)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Invoice"
        Text = "Invoice"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents eventID As Label
    Friend WithEvents vendorID As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents bank As Label
    Friend WithEvents account As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents tax As Label
    Friend WithEvents total As Label
    Friend WithEvents TRANSACTIONID As DataGridViewTextBoxColumn
    Friend WithEvents RATE As DataGridViewTextBoxColumn
    Friend WithEvents DAYS As DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT As DataGridViewTextBoxColumn

End Class
