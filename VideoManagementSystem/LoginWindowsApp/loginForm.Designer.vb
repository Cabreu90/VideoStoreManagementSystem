<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.cancellButton = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cancellButton
        '
        Me.cancellButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancellButton.Location = New System.Drawing.Point(185, 43)
        Me.cancellButton.Name = "cancellButton"
        Me.cancellButton.Size = New System.Drawing.Size(75, 23)
        Me.cancellButton.TabIndex = 5
        Me.cancellButton.Text = "Cancel"
        Me.cancellButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(185, 12)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(76, 43)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 3
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(78, 14)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "App By Cesarin Abreu"
        '
        'loginForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancellButton
        Me.ClientSize = New System.Drawing.Size(284, 96)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancellButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancellButton As System.Windows.Forms.Button
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
