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
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.btnFindArea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(75, 29)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 0
        Me.txtRadius.Text = "Type radius here..."
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(33, 133)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(142, 20)
        Me.txtArea.TabIndex = 1
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(30, 32)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(49, 13)
        Me.lblRadius.TabIndex = 2
        Me.lblRadius.Text = "Radius  :"
        '
        'btnFindArea
        '
        Me.btnFindArea.Location = New System.Drawing.Point(63, 79)
        Me.btnFindArea.Name = "btnFindArea"
        Me.btnFindArea.Size = New System.Drawing.Size(75, 23)
        Me.btnFindArea.TabIndex = 3
        Me.btnFindArea.Text = "Find Area"
        Me.btnFindArea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 190)
        Me.Controls.Add(Me.btnFindArea)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtRadius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents btnFindArea As System.Windows.Forms.Button

End Class
