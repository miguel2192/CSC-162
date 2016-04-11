<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArray
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
        Me.btnFill = New System.Windows.Forms.Button()
        Me.bntSearch = New System.Windows.Forms.Button()
        Me.lblArray = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFill
        '
        Me.btnFill.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFill.Location = New System.Drawing.Point(105, 92)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(131, 55)
        Me.btnFill.TabIndex = 0
        Me.btnFill.Text = "Fill Array"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'bntSearch
        '
        Me.bntSearch.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntSearch.Location = New System.Drawing.Point(105, 168)
        Me.bntSearch.Name = "bntSearch"
        Me.bntSearch.Size = New System.Drawing.Size(131, 55)
        Me.bntSearch.TabIndex = 1
        Me.bntSearch.Text = "Search"
        Me.bntSearch.UseVisualStyleBackColor = True
        '
        'lblArray
        '
        Me.lblArray.AutoSize = True
        Me.lblArray.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArray.Location = New System.Drawing.Point(12, 23)
        Me.lblArray.Name = "lblArray"
        Me.lblArray.Size = New System.Drawing.Size(319, 19)
        Me.lblArray.TabIndex = 2
        Me.lblArray.Text = "Welcome to your array of size 10"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(28, 51)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(284, 19)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Don't Enter Duplicate Names"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(278, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(57, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(105, 245)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(152, 121)
        Me.List1.TabIndex = 5
        '
        'frmArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(347, 387)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblArray)
        Me.Controls.Add(Me.bntSearch)
        Me.Controls.Add(Me.btnFill)
        Me.Name = "frmArray"
        Me.Text = "Array Fill & Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents bntSearch As System.Windows.Forms.Button
    Friend WithEvents lblArray As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox

End Class
