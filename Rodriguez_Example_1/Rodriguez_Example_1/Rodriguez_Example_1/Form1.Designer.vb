<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExample_1
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
        Me.btnRED = New System.Windows.Forms.Button()
        Me.btnGREEN = New System.Windows.Forms.Button()
        Me.btnBLUE = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRED
        '
        Me.btnRED.Location = New System.Drawing.Point(148, 12)
        Me.btnRED.Name = "btnRED"
        Me.btnRED.Size = New System.Drawing.Size(194, 68)
        Me.btnRED.TabIndex = 0
        Me.btnRED.Text = "RED"
        Me.btnRED.UseVisualStyleBackColor = True
        '
        'btnGREEN
        '
        Me.btnGREEN.Location = New System.Drawing.Point(148, 86)
        Me.btnGREEN.Name = "btnGREEN"
        Me.btnGREEN.Size = New System.Drawing.Size(194, 68)
        Me.btnGREEN.TabIndex = 1
        Me.btnGREEN.Text = "GREEN"
        Me.btnGREEN.UseVisualStyleBackColor = True
        '
        'btnBLUE
        '
        Me.btnBLUE.Location = New System.Drawing.Point(148, 160)
        Me.btnBLUE.Name = "btnBLUE"
        Me.btnBLUE.Size = New System.Drawing.Size(194, 68)
        Me.btnBLUE.TabIndex = 2
        Me.btnBLUE.Text = "BLUE"
        Me.btnBLUE.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(148, 246)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(194, 93)
        Me.lblDisplay.TabIndex = 3
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmExample_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 370)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnBLUE)
        Me.Controls.Add(Me.btnGREEN)
        Me.Controls.Add(Me.btnRED)
        Me.Name = "frmExample_1"
        Me.Text = "Rodriguez_Example_1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRED As System.Windows.Forms.Button
    Friend WithEvents btnGREEN As System.Windows.Forms.Button
    Friend WithEvents btnBLUE As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
