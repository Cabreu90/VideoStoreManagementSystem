<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerInfoForm
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
        Me.idnumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.birthdateTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ssnumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Information  Screen"
        '
        'idnumberTextBox
        '
        Me.idnumberTextBox.Location = New System.Drawing.Point(104, 46)
        Me.idnumberTextBox.Name = "idnumberTextBox"
        Me.idnumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idnumberTextBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "IDNumber:"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneTextBox.Location = New System.Drawing.Point(103, 223)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.ReadOnly = True
        Me.phoneTextBox.Size = New System.Drawing.Size(182, 20)
        Me.phoneTextBox.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Phone Number:"
        '
        'addressTextBox
        '
        Me.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressTextBox.Location = New System.Drawing.Point(103, 197)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.ReadOnly = True
        Me.addressTextBox.Size = New System.Drawing.Size(182, 20)
        Me.addressTextBox.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Address:"
        '
        'birthdateTextBox
        '
        Me.birthdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.birthdateTextBox.Location = New System.Drawing.Point(103, 171)
        Me.birthdateTextBox.Name = "birthdateTextBox"
        Me.birthdateTextBox.ReadOnly = True
        Me.birthdateTextBox.Size = New System.Drawing.Size(182, 20)
        Me.birthdateTextBox.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Birthdate:"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lnameTextBox.Location = New System.Drawing.Point(104, 78)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.ReadOnly = True
        Me.lnameTextBox.Size = New System.Drawing.Size(181, 20)
        Me.lnameTextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Last Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fnameTextBox.Location = New System.Drawing.Point(103, 106)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.ReadOnly = True
        Me.fnameTextBox.Size = New System.Drawing.Size(182, 20)
        Me.fnameTextBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "First Name:"
        '
        'ssnumberTextBox
        '
        Me.ssnumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ssnumberTextBox.Location = New System.Drawing.Point(103, 140)
        Me.ssnumberTextBox.Name = "ssnumberTextBox"
        Me.ssnumberTextBox.ReadOnly = True
        Me.ssnumberTextBox.Size = New System.Drawing.Size(182, 20)
        Me.ssnumberTextBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "SS Number:"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(210, 46)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 27
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(210, 251)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 28
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'customerInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 286)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.birthdateTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ssnumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idnumberTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customerInfoForm"
        Me.Text = "customerInfoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents birthdateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ssnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
