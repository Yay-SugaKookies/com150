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
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGross = New System.Windows.Forms.Button()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(9, 62)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(116, 14)
        Me.lblHours.TabIndex = 0
        Me.lblHours.Text = "Input Hours Worked:"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(41, 108)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(84, 14)
        Me.lblPay.TabIndex = 1
        Me.lblPay.Text = "Input Pay Rate:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(27, 219)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(98, 14)
        Me.lblGross.TabIndex = 2
        Me.lblGross.Text = "Gross Pay Earned:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 13
        Me.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(220, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(31, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGross
        '
        Me.btnGross.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnGross.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnGross.FlatAppearance.BorderSize = 13
        Me.btnGross.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnGross.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnGross.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnGross.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGross.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGross.Location = New System.Drawing.Point(86, 153)
        Me.btnGross.Name = "btnGross"
        Me.btnGross.Size = New System.Drawing.Size(84, 38)
        Me.btnGross.TabIndex = 4
        Me.btnGross.Text = "Calculate Pay Gross"
        Me.btnGross.UseVisualStyleBackColor = False
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(131, 217)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(100, 20)
        Me.txtGross.TabIndex = 5
        Me.txtGross.Text = "0.00"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(131, 106)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(100, 20)
        Me.txtPay.TabIndex = 6
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(131, 60)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 7
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(258, 267)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.btnGross)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblHours)
        Me.Name = "Form1"
        Me.Text = "Gross Pay Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblPay As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGross As System.Windows.Forms.Button
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox

End Class
