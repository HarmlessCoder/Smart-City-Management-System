<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatBubbleItem
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
        Me.timebox = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.RichTextBox()
        Me.picbox = New System.Windows.Forms.PictureBox()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timebox
        '
        Me.timebox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timebox.AutoSize = True
        Me.timebox.Font = New System.Drawing.Font("Trebuchet MS", 9.152543!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timebox.ForeColor = System.Drawing.Color.LightGray
        Me.timebox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.timebox.Location = New System.Drawing.Point(356, 4)
        Me.timebox.Name = "timebox"
        Me.timebox.Size = New System.Drawing.Size(159, 22)
        Me.timebox.TabIndex = 1
        Me.timebox.Text = "13th March, 6:30PM"
        Me.timebox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblname.Location = New System.Drawing.Point(62, 6)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(111, 22)
        Me.lblname.TabIndex = 10
        Me.lblname.Text = "{User Name} "
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.BackColor = System.Drawing.Color.Sienna
        Me.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CommentTextBox.ForeColor = System.Drawing.Color.LemonChiffon
        Me.CommentTextBox.Location = New System.Drawing.Point(64, 31)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.ReadOnly = True
        Me.CommentTextBox.Size = New System.Drawing.Size(460, 49)
        Me.CommentTextBox.TabIndex = 11
        Me.CommentTextBox.Text = "Hey, Even I want to go to IITG, but I want you to wait for 20 mins."
        '
        'picbox
        '
        Me.picbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox.Image = Global.SmartCityMgmtSystem.My.Resources.Resources.icons8_driver_48
        Me.picbox.Location = New System.Drawing.Point(7, 6)
        Me.picbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(49, 39)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'ChatBubbleItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.timebox)
        Me.Controls.Add(Me.picbox)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.762712!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(15, 12, 0, 3)
        Me.Name = "ChatBubbleItem"
        Me.Size = New System.Drawing.Size(525, 83)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picbox As PictureBox
    Friend WithEvents timebox As Label
    Friend WithEvents lblname As Label
    Friend WithEvents CommentTextBox As RichTextBox
End Class
