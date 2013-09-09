<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeeForm
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
        Me.searchButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.listAllButton = New System.Windows.Forms.Button()
        Me.printAllButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ssnumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.birthdateTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jobtitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.unameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgEmployeeList = New System.Windows.Forms.DataGridView()
        CType(Me.dgEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(14, 310)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 20
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(101, 339)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 23
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(14, 339)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 22
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(101, 310)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 21
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(490, 339)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 25
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'listAllButton
        '
        Me.listAllButton.Location = New System.Drawing.Point(571, 310)
        Me.listAllButton.Name = "listAllButton"
        Me.listAllButton.Size = New System.Drawing.Size(75, 23)
        Me.listAllButton.TabIndex = 24
        Me.listAllButton.Text = "List All"
        Me.listAllButton.UseVisualStyleBackColor = True
        '
        'printAllButton
        '
        Me.printAllButton.Location = New System.Drawing.Point(409, 339)
        Me.printAllButton.Name = "printAllButton"
        Me.printAllButton.Size = New System.Drawing.Size(75, 23)
        Me.printAllButton.TabIndex = 26
        Me.printAllButton.Text = "Print All"
        Me.printAllButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(571, 339)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 27
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Management Screen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SS Number:"
        '
        'ssnumberTextBox
        '
        Me.ssnumberTextBox.Location = New System.Drawing.Point(103, 56)
        Me.ssnumberTextBox.Name = "ssnumberTextBox"
        Me.ssnumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ssnumberTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name:"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Location = New System.Drawing.Point(103, 84)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fnameTextBox.TabIndex = 4
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(103, 116)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lnameTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Last Name"
        '
        'birthdateTextBox
        '
        Me.birthdateTextBox.Location = New System.Drawing.Point(103, 149)
        Me.birthdateTextBox.Name = "birthdateTextBox"
        Me.birthdateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.birthdateTextBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Birthdate:"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(103, 175)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.addressTextBox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address:"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(103, 201)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.phoneTextBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Phone Number:"
        '
        'jobtitleTextBox
        '
        Me.jobtitleTextBox.Location = New System.Drawing.Point(103, 227)
        Me.jobtitleTextBox.Name = "jobtitleTextBox"
        Me.jobtitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.jobtitleTextBox.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Job Title:"
        '
        'unameTextBox
        '
        Me.unameTextBox.Location = New System.Drawing.Point(103, 253)
        Me.unameTextBox.Name = "unameTextBox"
        Me.unameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.unameTextBox.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Username:"
        '
        'pwordTextBox
        '
        Me.pwordTextBox.Location = New System.Drawing.Point(103, 279)
        Me.pwordTextBox.Name = "pwordTextBox"
        Me.pwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.pwordTextBox.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Password:"
        '
        'dgEmployeeList
        '
        Me.dgEmployeeList.AllowUserToAddRows = False
        Me.dgEmployeeList.AllowUserToDeleteRows = False
        Me.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmployeeList.Location = New System.Drawing.Point(209, 56)
        Me.dgEmployeeList.Name = "dgEmployeeList"
        Me.dgEmployeeList.ReadOnly = True
        Me.dgEmployeeList.Size = New System.Drawing.Size(437, 248)
        Me.dgEmployeeList.TabIndex = 28
        '
        'employeeForm
        '
        Me.AcceptButton = Me.searchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(664, 365)
        Me.Controls.Add(Me.dgEmployeeList)
        Me.Controls.Add(Me.pwordTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.unameTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.jobtitleTextBox)
        Me.Controls.Add(Me.Label8)
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
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printAllButton)
        Me.Controls.Add(Me.listAllButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.searchButton)
        Me.Name = "employeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Management Screen"
        CType(Me.dgEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents listAllButton As System.Windows.Forms.Button
    Friend WithEvents printAllButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ssnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents birthdateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jobtitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents unameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgEmployeeList As System.Windows.Forms.DataGridView
End Class
