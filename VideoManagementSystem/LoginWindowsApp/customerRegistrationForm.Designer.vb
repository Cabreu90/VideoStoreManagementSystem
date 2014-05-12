<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerRegistrationForm
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
        Me.dgCustomerList = New System.Windows.Forms.DataGridView()
        Me.idnumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.printAllButton = New System.Windows.Forms.Button()
        Me.listAllButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCustomerList
        '
        Me.dgCustomerList.AllowUserToAddRows = False
        Me.dgCustomerList.AllowUserToDeleteRows = False
        Me.dgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomerList.Location = New System.Drawing.Point(233, 52)
        Me.dgCustomerList.Name = "dgCustomerList"
        Me.dgCustomerList.ReadOnly = True
        Me.dgCustomerList.Size = New System.Drawing.Size(438, 225)
        Me.dgCustomerList.TabIndex = 48
        '
        'idnumberTextBox
        '
        Me.idnumberTextBox.Location = New System.Drawing.Point(127, 52)
        Me.idnumberTextBox.Name = "idnumberTextBox"
        Me.idnumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idnumberTextBox.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "IDNumber:"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(596, 308)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 47
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'printAllButton
        '
        Me.printAllButton.Location = New System.Drawing.Point(127, 312)
        Me.printAllButton.Name = "printAllButton"
        Me.printAllButton.Size = New System.Drawing.Size(75, 23)
        Me.printAllButton.TabIndex = 45
        Me.printAllButton.Text = "Print All"
        Me.printAllButton.UseVisualStyleBackColor = True
        '
        'listAllButton
        '
        Me.listAllButton.Location = New System.Drawing.Point(233, 308)
        Me.listAllButton.Name = "listAllButton"
        Me.listAllButton.Size = New System.Drawing.Size(75, 23)
        Me.listAllButton.TabIndex = 46
        Me.listAllButton.Text = "List All"
        Me.listAllButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(39, 312)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 44
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(127, 283)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 43
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(127, 254)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 41
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(39, 283)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 42
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(40, 254)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 40
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(127, 224)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.phoneTextBox.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Phone Number:"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(127, 198)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.addressTextBox.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Address:"
        '
        'birthdateTextBox
        '
        Me.birthdateTextBox.Location = New System.Drawing.Point(127, 172)
        Me.birthdateTextBox.Name = "birthdateTextBox"
        Me.birthdateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.birthdateTextBox.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Birthdate:"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(128, 79)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lnameTextBox.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Last Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Location = New System.Drawing.Point(127, 107)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fnameTextBox.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "First Name:"
        '
        'ssnumberTextBox
        '
        Me.ssnumberTextBox.Location = New System.Drawing.Point(127, 141)
        Me.ssnumberTextBox.Name = "ssnumberTextBox"
        Me.ssnumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ssnumberTextBox.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "SS Number:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 40)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Customer Registration Screen"
        '
        'customerRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 347)
        Me.Controls.Add(Me.dgCustomerList)
        Me.Controls.Add(Me.idnumberTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printAllButton)
        Me.Controls.Add(Me.listAllButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "customerRegistrationForm"
        Me.Text = "Customer Registration Form"
        CType(Me.dgCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCustomerList As System.Windows.Forms.DataGridView
    Friend WithEvents idnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents printAllButton As System.Windows.Forms.Button
    Friend WithEvents listAllButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
