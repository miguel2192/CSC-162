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
        Me.btnCMD = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblDisplay2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSortAsc = New System.Windows.Forms.Button()
        Me.btnSortDesc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCMD
        '
        Me.btnCMD.BackColor = System.Drawing.Color.DarkRed
        Me.btnCMD.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCMD.Location = New System.Drawing.Point(78, 92)
        Me.btnCMD.Name = "btnCMD"
        Me.btnCMD.Size = New System.Drawing.Size(186, 54)
        Me.btnCMD.TabIndex = 0
        Me.btnCMD.Text = "Run"
        Me.btnCMD.UseVisualStyleBackColor = False
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(24, 216)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(289, 160)
        Me.List1.TabIndex = 1
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(24, 181)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(289, 32)
        Me.lblDisplay.TabIndex = 2
        '
        'lblDisplay2
        '
        Me.lblDisplay2.Location = New System.Drawing.Point(24, 149)
        Me.lblDisplay2.Name = "lblDisplay2"
        Me.lblDisplay2.Size = New System.Drawing.Size(289, 32)
        Me.lblDisplay2.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 32)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Filling and Retrieving Array"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(132, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSortAsc
        '
        Me.btnSortAsc.BackColor = System.Drawing.Color.DarkRed
        Me.btnSortAsc.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortAsc.Location = New System.Drawing.Point(46, 392)
        Me.btnSortAsc.Name = "btnSortAsc"
        Me.btnSortAsc.Size = New System.Drawing.Size(237, 41)
        Me.btnSortAsc.TabIndex = 6
        Me.btnSortAsc.Text = "Sort Ascending"
        Me.btnSortAsc.UseVisualStyleBackColor = False
        '
        'btnSortDesc
        '
        Me.btnSortDesc.BackColor = System.Drawing.Color.DarkRed
        Me.btnSortDesc.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortDesc.Location = New System.Drawing.Point(46, 439)
        Me.btnSortDesc.Name = "btnSortDesc"
        Me.btnSortDesc.Size = New System.Drawing.Size(237, 41)
        Me.btnSortDesc.TabIndex = 7
        Me.btnSortDesc.Text = "Sort Descending"
        Me.btnSortDesc.UseVisualStyleBackColor = False
        '
        'frmArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(333, 529)
        Me.Controls.Add(Me.btnSortDesc)
        Me.Controls.Add(Me.btnSortAsc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDisplay2)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.btnCMD)
        Me.Name = "frmArray"
        Me.Text = "Array Fill & Retrieved"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCMD As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblDisplay2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSortAsc As System.Windows.Forms.Button
    Friend WithEvents btnSortDesc As System.Windows.Forms.Button

End Class
