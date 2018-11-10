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
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtSide = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblSide = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Gadugi", 12.0!)
        Me.txtArea.Location = New System.Drawing.Point(35, 139)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(283, 29)
        Me.txtArea.TabIndex = 0
        '
        'txtSide
        '
        Me.txtSide.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSide.Location = New System.Drawing.Point(218, 38)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.Size = New System.Drawing.Size(100, 29)
        Me.txtSide.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnOk.Location = New System.Drawing.Point(137, 95)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 25)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblSide.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSide.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblSide.Location = New System.Drawing.Point(31, 38)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(181, 22)
        Me.lblSide.TabIndex = 3
        Me.lblSide.Text = "Enter side of square:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(344, 183)
        Me.Controls.Add(Me.lblSide)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.txtArea)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Area Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtSide As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblSide As System.Windows.Forms.Label

End Class
