<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackEndForm
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
        Me.employeeButton = New System.Windows.Forms.Button()
        Me.customerButton = New System.Windows.Forms.Button()
        Me.videoGameButton = New System.Windows.Forms.Button()
        Me.dvdButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'employeeButton
        '
        Me.employeeButton.Location = New System.Drawing.Point(12, 36)
        Me.employeeButton.Name = "employeeButton"
        Me.employeeButton.Size = New System.Drawing.Size(140, 37)
        Me.employeeButton.TabIndex = 0
        Me.employeeButton.Text = "Employee M"
        Me.employeeButton.UseVisualStyleBackColor = True
        '
        'customerButton
        '
        Me.customerButton.Location = New System.Drawing.Point(164, 36)
        Me.customerButton.Name = "customerButton"
        Me.customerButton.Size = New System.Drawing.Size(140, 37)
        Me.customerButton.TabIndex = 1
        Me.customerButton.Text = "Customer M"
        Me.customerButton.UseVisualStyleBackColor = True
        '
        'videoGameButton
        '
        Me.videoGameButton.Location = New System.Drawing.Point(164, 87)
        Me.videoGameButton.Name = "videoGameButton"
        Me.videoGameButton.Size = New System.Drawing.Size(140, 37)
        Me.videoGameButton.TabIndex = 3
        Me.videoGameButton.Text = "Video Game M"
        Me.videoGameButton.UseVisualStyleBackColor = True
        '
        'dvdButton
        '
        Me.dvdButton.Location = New System.Drawing.Point(12, 87)
        Me.dvdButton.Name = "dvdButton"
        Me.dvdButton.Size = New System.Drawing.Size(140, 37)
        Me.dvdButton.TabIndex = 2
        Me.dvdButton.Text = "DVD M"
        Me.dvdButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(231, 148)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'BackEndForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(318, 183)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.videoGameButton)
        Me.Controls.Add(Me.dvdButton)
        Me.Controls.Add(Me.customerButton)
        Me.Controls.Add(Me.employeeButton)
        Me.Name = "BackEndForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackEndForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents employeeButton As System.Windows.Forms.Button
    Friend WithEvents customerButton As System.Windows.Forms.Button
    Friend WithEvents videoGameButton As System.Windows.Forms.Button
    Friend WithEvents dvdButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
