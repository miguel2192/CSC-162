<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoopAvg
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
        Me.lblNumGrade = New System.Windows.Forms.Label()
        Me.txtNumGrade = New System.Windows.Forms.TextBox()
        Me.btnRunProgram = New System.Windows.Forms.Button()
        Me.txtRunningTotal = New System.Windows.Forms.TextBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumGrade
        '
        Me.lblNumGrade.AutoSize = True
        Me.lblNumGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumGrade.Location = New System.Drawing.Point(12, 48)
        Me.lblNumGrade.Name = "lblNumGrade"
        Me.lblNumGrade.Size = New System.Drawing.Size(230, 20)
        Me.lblNumGrade.TabIndex = 0
        Me.lblNumGrade.Text = "Enter the number of grades"
        '
        'txtNumGrade
        '
        Me.txtNumGrade.Location = New System.Drawing.Point(267, 48)
        Me.txtNumGrade.Multiline = True
        Me.txtNumGrade.Name = "txtNumGrade"
        Me.txtNumGrade.Size = New System.Drawing.Size(157, 27)
        Me.txtNumGrade.TabIndex = 1
        '
        'btnRunProgram
        '
        Me.btnRunProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunProgram.Location = New System.Drawing.Point(105, 97)
        Me.btnRunProgram.Name = "btnRunProgram"
        Me.btnRunProgram.Size = New System.Drawing.Size(187, 63)
        Me.btnRunProgram.TabIndex = 2
        Me.btnRunProgram.Text = "Run Program"
        Me.btnRunProgram.UseVisualStyleBackColor = True
        '
        'txtRunningTotal
        '
        Me.txtRunningTotal.Location = New System.Drawing.Point(266, 180)
        Me.txtRunningTotal.Multiline = True
        Me.txtRunningTotal.Name = "txtRunningTotal"
        Me.txtRunningTotal.Size = New System.Drawing.Size(157, 27)
        Me.txtRunningTotal.TabIndex = 3
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(267, 251)
        Me.txtAvg.Multiline = True
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(157, 27)
        Me.txtAvg.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Running Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Average Grade"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(346, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLoopAvg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(435, 345)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.txtRunningTotal)
        Me.Controls.Add(Me.btnRunProgram)
        Me.Controls.Add(Me.txtNumGrade)
        Me.Controls.Add(Me.lblNumGrade)
        Me.Name = "frmLoopAvg"
        Me.Text = "Loop Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumGrade As System.Windows.Forms.Label
    Friend WithEvents txtNumGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnRunProgram As System.Windows.Forms.Button
    Friend WithEvents txtRunningTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
