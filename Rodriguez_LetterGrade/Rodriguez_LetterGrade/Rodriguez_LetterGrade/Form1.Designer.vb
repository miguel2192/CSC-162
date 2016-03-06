<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLetterGrade
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
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnCmd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCmdClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.Location = New System.Drawing.Point(22, 66)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(194, 24)
        Me.lblCourseName.TabIndex = 8
        Me.lblCourseName.Text = "&Enter Course Name"
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterGrade.Location = New System.Drawing.Point(22, 123)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(204, 24)
        Me.lblLetterGrade.TabIndex = 10
        Me.lblLetterGrade.Text = "Enter Grade Number"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(232, 71)
        Me.txtCourse.Multiline = True
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(162, 24)
        Me.txtCourse.TabIndex = 9
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(232, 123)
        Me.txtGrade.Multiline = True
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(162, 24)
        Me.txtGrade.TabIndex = 11
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(26, 202)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(323, 242)
        Me.txtDisplay.TabIndex = 12
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCmd
        '
        Me.btnCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCmd.Location = New System.Drawing.Point(31, 161)
        Me.btnCmd.Name = "btnCmd"
        Me.btnCmd.Size = New System.Drawing.Size(195, 35)
        Me.btnCmd.TabIndex = 14
        Me.btnCmd.Text = "Calculate Letter"
        Me.btnCmd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(352, 412)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 32)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCmdClear
        '
        Me.btnCmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCmdClear.Location = New System.Drawing.Point(242, 161)
        Me.btnCmdClear.Name = "btnCmdClear"
        Me.btnCmdClear.Size = New System.Drawing.Size(107, 35)
        Me.btnCmdClear.TabIndex = 15
        Me.btnCmdClear.Text = "Clear"
        Me.btnCmdClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to Letter Grade Calculator"
        '
        'frmLetterGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(413, 456)
        Me.Controls.Add(Me.btnCmdClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCmd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.lblCourseName)
        Me.Name = "frmLetterGrade"
        Me.Text = "Letter Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnCmd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCmdClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
