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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSol = New System.Windows.Forms.Button()
        Me.txtSol = New System.Windows.Forms.TextBox()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many gallons does a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'btnSol
        '
        Me.btnSol.Location = New System.Drawing.Point(12, 56)
        Me.btnSol.Name = "btnSol"
        Me.btnSol.Size = New System.Drawing.Size(192, 23)
        Me.btnSol.TabIndex = 2
        Me.btnSol.Text = "Evaluate Answer"
        Me.btnSol.UseVisualStyleBackColor = True
        '
        'txtSol
        '
        Me.txtSol.Location = New System.Drawing.Point(12, 85)
        Me.txtSol.Name = "txtSol"
        Me.txtSol.Size = New System.Drawing.Size(192, 20)
        Me.txtSol.TabIndex = 3
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(143, 24)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(61, 20)
        Me.txtAns.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ten-gallon hat hold?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 119)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.txtSol)
        Me.Controls.Add(Me.btnSol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSol As System.Windows.Forms.Button
    Friend WithEvents txtSol As System.Windows.Forms.TextBox
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
