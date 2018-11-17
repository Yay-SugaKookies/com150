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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.txtMinus = New System.Windows.Forms.TextBox()
        Me.txtDivide = New System.Windows.Forms.TextBox()
        Me.txtMultiply = New System.Windows.Forms.TextBox()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNum1.Location = New System.Drawing.Point(69, 57)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(91, 20)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "1st Number"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblOperation.Location = New System.Drawing.Point(65, 142)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(440, 46)
        Me.lblOperation.TabIndex = 1
        Me.lblOperation.Text = "Choose Your Operation"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNum2.Location = New System.Drawing.Point(389, 57)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(96, 20)
        Me.lblNum2.TabIndex = 2
        Me.lblNum2.Text = "2nd Number"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 205)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 44)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BtnMultiply
        '
        Me.BtnMultiply.Location = New System.Drawing.Point(352, 205)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(92, 44)
        Me.BtnMultiply.TabIndex = 7
        Me.BtnMultiply.Text = "X"
        Me.BtnMultiply.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtAdd.Location = New System.Drawing.Point(22, 275)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(92, 37)
        Me.txtAdd.TabIndex = 8
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtNum1.Location = New System.Drawing.Point(46, 82)
        Me.txtNum1.Multiline = True
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(126, 40)
        Me.txtNum1.TabIndex = 9
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(133, 205)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(92, 44)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(239, 205)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(92, 44)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(470, 205)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(92, 44)
        Me.btnExp.TabIndex = 3
        Me.btnExp.Text = "^"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'txtMinus
        '
        Me.txtMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtMinus.Location = New System.Drawing.Point(133, 275)
        Me.txtMinus.Multiline = True
        Me.txtMinus.Name = "txtMinus"
        Me.txtMinus.Size = New System.Drawing.Size(92, 37)
        Me.txtMinus.TabIndex = 8
        Me.txtMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDivide
        '
        Me.txtDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtDivide.Location = New System.Drawing.Point(239, 275)
        Me.txtDivide.Multiline = True
        Me.txtDivide.Name = "txtDivide"
        Me.txtDivide.Size = New System.Drawing.Size(92, 37)
        Me.txtDivide.TabIndex = 8
        Me.txtDivide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMultiply
        '
        Me.txtMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtMultiply.Location = New System.Drawing.Point(352, 275)
        Me.txtMultiply.Multiline = True
        Me.txtMultiply.Name = "txtMultiply"
        Me.txtMultiply.Size = New System.Drawing.Size(92, 37)
        Me.txtMultiply.TabIndex = 8
        Me.txtMultiply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExp
        '
        Me.txtExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtExp.Location = New System.Drawing.Point(470, 275)
        Me.txtExp.Multiline = True
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(92, 37)
        Me.txtExp.TabIndex = 8
        Me.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtNum2.Location = New System.Drawing.Point(375, 80)
        Me.txtNum2.Multiline = True
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(126, 40)
        Me.txtNum2.TabIndex = 9
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(61, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(171, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(275, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(390, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(506, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 349)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtExp)
        Me.Controls.Add(Me.txtMultiply)
        Me.Controls.Add(Me.txtDivide)
        Me.Controls.Add(Me.txtMinus)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.BtnMultiply)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form1"
        Me.Text = "My Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnMultiply As System.Windows.Forms.Button
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents txtMinus As System.Windows.Forms.TextBox
    Friend WithEvents txtDivide As System.Windows.Forms.TextBox
    Friend WithEvents txtMultiply As System.Windows.Forms.TextBox
    Friend WithEvents txtExp As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
