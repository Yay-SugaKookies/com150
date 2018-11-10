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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(30, 27)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(69, 13)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First Number:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(12, 56)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(87, 13)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = "Second Number:"
        '
        'btnResult
        '
        Me.btnResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResult.Location = New System.Drawing.Point(15, 76)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(161, 23)
        Me.btnResult.TabIndex = 2
        Me.btnResult.Text = "Find Larger Number"
        Me.btnResult.UseVisualStyleBackColor = False
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(105, 53)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(71, 20)
        Me.txtSecond.TabIndex = 3
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(105, 24)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(71, 20)
        Me.txtFirst.TabIndex = 4
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 105)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(161, 20)
        Me.txtResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(198, 142)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents btnResult As System.Windows.Forms.Button
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
