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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lstWhyNot = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdFour = New System.Windows.Forms.RadioButton()
        Me.rdFive = New System.Windows.Forms.RadioButton()
        Me.rdSix = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdPlus = New System.Windows.Forms.RadioButton()
        Me.RdTimes = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(97, 18)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstWhyNot
        '
        Me.lstWhyNot.FormattingEnabled = True
        Me.lstWhyNot.Location = New System.Drawing.Point(151, 47)
        Me.lstWhyNot.Name = "lstWhyNot"
        Me.lstWhyNot.Size = New System.Drawing.Size(120, 95)
        Me.lstWhyNot.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "6"
        '
        'rdFour
        '
        Me.rdFour.AutoSize = True
        Me.rdFour.Location = New System.Drawing.Point(7, 11)
        Me.rdFour.Name = "rdFour"
        Me.rdFour.Size = New System.Drawing.Size(14, 13)
        Me.rdFour.TabIndex = 2
        Me.rdFour.TabStop = True
        Me.rdFour.UseVisualStyleBackColor = True
        '
        'rdFive
        '
        Me.rdFive.AutoSize = True
        Me.rdFive.Location = New System.Drawing.Point(58, 11)
        Me.rdFive.Name = "rdFive"
        Me.rdFive.Size = New System.Drawing.Size(14, 13)
        Me.rdFive.TabIndex = 3
        Me.rdFive.TabStop = True
        Me.rdFive.UseVisualStyleBackColor = True
        '
        'rdSix
        '
        Me.rdSix.AutoSize = True
        Me.rdSix.Location = New System.Drawing.Point(113, 11)
        Me.rdSix.Name = "rdSix"
        Me.rdSix.Size = New System.Drawing.Size(14, 13)
        Me.rdSix.TabIndex = 4
        Me.rdSix.TabStop = True
        Me.rdSix.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rdSix)
        Me.GroupBox1.Controls.Add(Me.rdFive)
        Me.GroupBox1.Controls.Add(Me.rdFour)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 47)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'rdPlus
        '
        Me.rdPlus.AutoSize = True
        Me.rdPlus.Location = New System.Drawing.Point(79, 10)
        Me.rdPlus.Name = "rdPlus"
        Me.rdPlus.Size = New System.Drawing.Size(14, 13)
        Me.rdPlus.TabIndex = 6
        Me.rdPlus.TabStop = True
        Me.rdPlus.UseVisualStyleBackColor = True
        '
        'RdTimes
        '
        Me.RdTimes.AutoSize = True
        Me.RdTimes.Location = New System.Drawing.Point(15, 10)
        Me.RdTimes.Name = "RdTimes"
        Me.RdTimes.Size = New System.Drawing.Size(14, 13)
        Me.RdTimes.TabIndex = 6
        Me.RdTimes.TabStop = True
        Me.RdTimes.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(80, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPlus)
        Me.GroupBox2.Controls.Add(Me.RdTimes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 48)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 160)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstWhyNot)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "Form1"
        Me.Text = "Loop Practice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lstWhyNot As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdFour As System.Windows.Forms.RadioButton
    Friend WithEvents rdFive As System.Windows.Forms.RadioButton
    Friend WithEvents rdSix As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPlus As System.Windows.Forms.RadioButton
    Friend WithEvents RdTimes As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
