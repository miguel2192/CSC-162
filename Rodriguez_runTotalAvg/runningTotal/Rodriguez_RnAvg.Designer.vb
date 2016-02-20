<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRunningTotal
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
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtNumEntered = New System.Windows.Forms.TextBox()
        Me.txtRunTotal = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblAmtPrompt = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cdmAvg = New System.Windows.Forms.Button()
        Me.txtDisplayAvg = New System.Windows.Forms.Label()
        Me.lblRunningAvg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEnd
        '
        Me.cmdEnd.BackColor = System.Drawing.Color.Red
        Me.cmdEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnd.Location = New System.Drawing.Point(225, 437)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnd.Size = New System.Drawing.Size(129, 49)
        Me.cmdEnd.TabIndex = 13
        Me.cmdEnd.Text = "END"
        Me.cmdEnd.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Red
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(29, 437)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(145, 49)
        Me.cmdClear.TabIndex = 12
        Me.cmdClear.Text = "CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Red
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(61, 188)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(249, 49)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Add to Total"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'txtNumEntered
        '
        Me.txtNumEntered.AcceptsReturn = True
        Me.txtNumEntered.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumEntered.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumEntered.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumEntered.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumEntered.Location = New System.Drawing.Point(231, 101)
        Me.txtNumEntered.MaxLength = 0
        Me.txtNumEntered.Name = "txtNumEntered"
        Me.txtNumEntered.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumEntered.Size = New System.Drawing.Size(65, 44)
        Me.txtNumEntered.TabIndex = 10
        Me.txtNumEntered.Text = " "
        Me.txtNumEntered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRunTotal
        '
        Me.txtRunTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtRunTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRunTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRunTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtRunTotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRunTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRunTotal.Location = New System.Drawing.Point(286, 252)
        Me.txtRunTotal.Name = "txtRunTotal"
        Me.txtRunTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRunTotal.Size = New System.Drawing.Size(68, 41)
        Me.txtRunTotal.TabIndex = 15
        Me.txtRunTotal.Text = " "
        Me.txtRunTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalLabel.Location = New System.Drawing.Point(9, 253)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalLabel.Size = New System.Drawing.Size(255, 41)
        Me.lblTotalLabel.TabIndex = 14
        Me.lblTotalLabel.Text = "Running Total:"
        Me.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAmtPrompt
        '
        Me.lblAmtPrompt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAmtPrompt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAmtPrompt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtPrompt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAmtPrompt.Location = New System.Drawing.Point(22, 103)
        Me.lblAmtPrompt.Name = "lblAmtPrompt"
        Me.lblAmtPrompt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmtPrompt.Size = New System.Drawing.Size(178, 41)
        Me.lblAmtPrompt.TabIndex = 9
        Me.lblAmtPrompt.Text = "Enter in Amount:"
        Me.lblAmtPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfo.Location = New System.Drawing.Point(29, 21)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInfo.Size = New System.Drawing.Size(313, 77)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = " "
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cdmAvg
        '
        Me.cdmAvg.BackColor = System.Drawing.Color.Red
        Me.cdmAvg.Cursor = System.Windows.Forms.Cursors.Default
        Me.cdmAvg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdmAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cdmAvg.Location = New System.Drawing.Point(61, 308)
        Me.cdmAvg.Name = "cdmAvg"
        Me.cdmAvg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cdmAvg.Size = New System.Drawing.Size(249, 49)
        Me.cdmAvg.TabIndex = 16
        Me.cdmAvg.Text = "Compute Average"
        Me.cdmAvg.UseVisualStyleBackColor = False
        '
        'txtDisplayAvg
        '
        Me.txtDisplayAvg.BackColor = System.Drawing.SystemColors.Control
        Me.txtDisplayAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDisplayAvg.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDisplayAvg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtDisplayAvg.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDisplayAvg.Location = New System.Drawing.Point(286, 380)
        Me.txtDisplayAvg.Name = "txtDisplayAvg"
        Me.txtDisplayAvg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDisplayAvg.Size = New System.Drawing.Size(68, 41)
        Me.txtDisplayAvg.TabIndex = 17
        Me.txtDisplayAvg.Text = " "
        Me.txtDisplayAvg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRunningAvg
        '
        Me.lblRunningAvg.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRunningAvg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRunningAvg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRunningAvg.Location = New System.Drawing.Point(25, 393)
        Me.lblRunningAvg.Name = "lblRunningAvg"
        Me.lblRunningAvg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRunningAvg.Size = New System.Drawing.Size(255, 41)
        Me.lblRunningAvg.TabIndex = 18
        Me.lblRunningAvg.Text = "Running Average:"
        Me.lblRunningAvg.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmRunningTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(399, 529)
        Me.Controls.Add(Me.lblRunningAvg)
        Me.Controls.Add(Me.txtDisplayAvg)
        Me.Controls.Add(Me.cdmAvg)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtNumEntered)
        Me.Controls.Add(Me.txtRunTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblAmtPrompt)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "frmRunningTotal"
        Me.Text = "Running Total & Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdEnd As System.Windows.Forms.Button
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents txtNumEntered As System.Windows.Forms.TextBox
    Public WithEvents txtRunTotal As System.Windows.Forms.Label
    Public WithEvents lblTotalLabel As System.Windows.Forms.Label
    Public WithEvents lblAmtPrompt As System.Windows.Forms.Label
    Public WithEvents lblInfo As System.Windows.Forms.Label
    Public WithEvents cdmAvg As System.Windows.Forms.Button
    Public WithEvents txtDisplayAvg As System.Windows.Forms.Label
    Public WithEvents lblRunningAvg As System.Windows.Forms.Label

End Class
