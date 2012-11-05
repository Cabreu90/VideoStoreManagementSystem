<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoPOSForm
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
        Me.rentButton = New System.Windows.Forms.Button()
        Me.returnsButton = New System.Windows.Forms.Button()
        Me.regButton = New System.Windows.Forms.Button()
        Me.infoButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Video POS Form"
        '
        'rentButton
        '
        Me.rentButton.Location = New System.Drawing.Point(40, 52)
        Me.rentButton.Name = "rentButton"
        Me.rentButton.Size = New System.Drawing.Size(106, 42)
        Me.rentButton.TabIndex = 1
        Me.rentButton.Text = "Rent"
        Me.rentButton.UseVisualStyleBackColor = True
        '
        'returnsButton
        '
        Me.returnsButton.Location = New System.Drawing.Point(40, 100)
        Me.returnsButton.Name = "returnsButton"
        Me.returnsButton.Size = New System.Drawing.Size(106, 42)
        Me.returnsButton.TabIndex = 2
        Me.returnsButton.Text = "Returns"
        Me.returnsButton.UseVisualStyleBackColor = True
        '
        'regButton
        '
        Me.regButton.Location = New System.Drawing.Point(40, 148)
        Me.regButton.Name = "regButton"
        Me.regButton.Size = New System.Drawing.Size(106, 42)
        Me.regButton.TabIndex = 3
        Me.regButton.Text = "Customer Reg."
        Me.regButton.UseVisualStyleBackColor = True
        '
        'infoButton
        '
        Me.infoButton.Location = New System.Drawing.Point(40, 196)
        Me.infoButton.Name = "infoButton"
        Me.infoButton.Size = New System.Drawing.Size(106, 42)
        Me.infoButton.TabIndex = 4
        Me.infoButton.Text = "Customer Info."
        Me.infoButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(40, 244)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(106, 42)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'VideoPOSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(206, 316)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.infoButton)
        Me.Controls.Add(Me.regButton)
        Me.Controls.Add(Me.returnsButton)
        Me.Controls.Add(Me.rentButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VideoPOSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VideoPOSForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rentButton As System.Windows.Forms.Button
    Friend WithEvents returnsButton As System.Windows.Forms.Button
    Friend WithEvents regButton As System.Windows.Forms.Button
    Friend WithEvents infoButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
