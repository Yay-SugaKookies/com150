<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLuck = New System.Windows.Forms.Button()
        Me.txtLuck = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLuck1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLuck
        '
        Me.btnLuck.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLuck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLuck.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuck.Location = New System.Drawing.Point(32, 29)
        Me.btnLuck.Name = "btnLuck"
        Me.btnLuck.Size = New System.Drawing.Size(137, 48)
        Me.btnLuck.TabIndex = 0
        Me.btnLuck.Text = "Click For Luck"
        Me.btnLuck.UseVisualStyleBackColor = False
        '
        'txtLuck
        '
        Me.txtLuck.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLuck.Location = New System.Drawing.Point(32, 133)
        Me.txtLuck.Name = "txtLuck"
        Me.txtLuck.Size = New System.Drawing.Size(147, 13)
        Me.txtLuck.TabIndex = 1
        Me.txtLuck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lucky Numbers:"
        '
        'txtLuck1
        '
        Me.txtLuck1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLuck1.Location = New System.Drawing.Point(72, 133)
        Me.txtLuck1.Name = "txtLuck1"
        Me.txtLuck1.Size = New System.Drawing.Size(14, 13)
        Me.txtLuck1.TabIndex = 3
        Me.txtLuck1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(204, 177)
        Me.Controls.Add(Me.txtLuck1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLuck)
        Me.Controls.Add(Me.btnLuck)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuck As System.Windows.Forms.Button
    Friend WithEvents txtLuck As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLuck1 As System.Windows.Forms.TextBox

End Class
