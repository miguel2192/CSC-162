<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint_Message
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
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtlName = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Last Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(249, 54)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(204, 20)
        Me.txtFname.TabIndex = 2
        '
        'txtlName
        '
        Me.txtlName.Location = New System.Drawing.Point(249, 114)
        Me.txtlName.Name = "txtlName"
        Me.txtlName.Size = New System.Drawing.Size(204, 20)
        Me.txtlName.TabIndex = 3
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(35, 231)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(418, 61)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(128, 159)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(246, 52)
        Me.btnClick.TabIndex = 5
        Me.btnClick.Text = "Click Me"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(429, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmPrint_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(516, 344)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtlName)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPrint_Message"
        Me.Text = "fmrPrint_Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtlName As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
