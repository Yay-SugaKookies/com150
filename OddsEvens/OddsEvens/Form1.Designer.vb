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
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtScore
        '
        Me.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(39, 43)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(195, 55)
        Me.txtScore.TabIndex = 0
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnScore
        '
        Me.btnScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnScore.Location = New System.Drawing.Point(39, 127)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(195, 50)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "PASS/FAIL"
        Me.btnScore.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(271, 212)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.txtScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnScore As System.Windows.Forms.Button

End Class
