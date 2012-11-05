<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.videoButton = New System.Windows.Forms.Button()
        Me.backEndButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'videoButton
        '
        Me.videoButton.Location = New System.Drawing.Point(12, 28)
        Me.videoButton.Name = "videoButton"
        Me.videoButton.Size = New System.Drawing.Size(127, 35)
        Me.videoButton.TabIndex = 0
        Me.videoButton.Text = "Video POS"
        Me.videoButton.UseVisualStyleBackColor = True
        '
        'backEndButton
        '
        Me.backEndButton.Location = New System.Drawing.Point(12, 83)
        Me.backEndButton.Name = "backEndButton"
        Me.backEndButton.Size = New System.Drawing.Size(127, 35)
        Me.backEndButton.TabIndex = 1
        Me.backEndButton.Text = "Back-End Form"
        Me.backEndButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(12, 134)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(127, 35)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.videoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(161, 206)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.backEndButton)
        Me.Controls.Add(Me.videoButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents videoButton As System.Windows.Forms.Button
    Friend WithEvents backEndButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
