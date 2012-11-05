<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoGameForm
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.formatComboBox = New System.Windows.Forms.ComboBox()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.ratingComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lateFeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rentalRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.salePriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.printAllButton = New System.Windows.Forms.Button()
        Me.listAllButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.dgVideoGameList = New System.Windows.Forms.DataGridView()
        CType(Me.dgVideoGameList,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(668, 348)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(46, 32)
        Me.exitButton.TabIndex = 26
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = true
        '
        'formatComboBox
        '
        Me.formatComboBox.FormattingEnabled = true
        Me.formatComboBox.Items.AddRange(New Object() {"XBox", "XBox 360", "PS3", "PS2", "GameCube", "DS", "Wii", "PC", "None"})
        Me.formatComboBox.Location = New System.Drawing.Point(80, 345)
        Me.formatComboBox.Name = "formatComboBox"
        Me.formatComboBox.Size = New System.Drawing.Size(133, 21)
        Me.formatComboBox.TabIndex = 18
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FormattingEnabled = true
        Me.categoryComboBox.Items.AddRange(New Object() {"Action", "Roleplaying", "Shooting", "Fighting", "Racing", "Sports", "Strategy", "Horror", "Flight Simulators", "Online", "Rhythm", "None"})
        Me.categoryComboBox.Location = New System.Drawing.Point(80, 309)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(133, 21)
        Me.categoryComboBox.TabIndex = 16
        '
        'ratingComboBox
        '
        Me.ratingComboBox.FormattingEnabled = true
        Me.ratingComboBox.Items.AddRange(New Object() {"G", "PG", "PG-13", "NC-17", "R", "NONE"})
        Me.ratingComboBox.Location = New System.Drawing.Point(81, 187)
        Me.ratingComboBox.Name = "ratingComboBox"
        Me.ratingComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ratingComboBox.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(12, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Format:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(12, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Category:"
        '
        'lateFeeTextBox
        '
        Me.lateFeeTextBox.Location = New System.Drawing.Point(81, 278)
        Me.lateFeeTextBox.Name = "lateFeeTextBox"
        Me.lateFeeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lateFeeTextBox.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(12, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "LateFee:"
        '
        'rentalRateTextBox
        '
        Me.rentalRateTextBox.Location = New System.Drawing.Point(82, 250)
        Me.rentalRateTextBox.Name = "rentalRateTextBox"
        Me.rentalRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.rentalRateTextBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(12, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "RentalRate:"
        '
        'salePriceTextBox
        '
        Me.salePriceTextBox.Location = New System.Drawing.Point(81, 219)
        Me.salePriceTextBox.Name = "salePriceTextBox"
        Me.salePriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.salePriceTextBox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(12, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SalePrice:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rating:"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(81, 129)
        Me.descriptionTextBox.Multiline = true
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(146, 46)
        Me.descriptionTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(81, 95)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(146, 20)
        Me.titleTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Title:"
        '
        'idNumberTextBox
        '
        Me.idNumberTextBox.Location = New System.Drawing.Point(81, 63)
        Me.idNumberTextBox.Name = "idNumberTextBox"
        Me.idNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idNumberTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IDNumber:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VideoGame Management Screen"
        '
        'printAllButton
        '
        Me.printAllButton.Location = New System.Drawing.Point(488, 350)
        Me.printAllButton.Name = "printAllButton"
        Me.printAllButton.Size = New System.Drawing.Size(75, 23)
        Me.printAllButton.TabIndex = 24
        Me.printAllButton.Text = "Print All"
        Me.printAllButton.UseVisualStyleBackColor = true
        '
        'listAllButton
        '
        Me.listAllButton.Location = New System.Drawing.Point(655, 307)
        Me.listAllButton.Name = "listAllButton"
        Me.listAllButton.Size = New System.Drawing.Size(59, 23)
        Me.listAllButton.TabIndex = 25
        Me.listAllButton.Text = "List All"
        Me.listAllButton.UseVisualStyleBackColor = true
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(488, 321)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 23
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = true
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(398, 350)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 22
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = true
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(308, 350)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 20
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = true
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(398, 321)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 21
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = true
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(308, 321)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 19
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = true
        '
        'dgVideoGameList
        '
        Me.dgVideoGameList.AllowUserToAddRows = false
        Me.dgVideoGameList.AllowUserToDeleteRows = false
        Me.dgVideoGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVideoGameList.Location = New System.Drawing.Point(253, 63)
        Me.dgVideoGameList.Name = "dgVideoGameList"
        Me.dgVideoGameList.ReadOnly = true
        Me.dgVideoGameList.Size = New System.Drawing.Size(461, 231)
        Me.dgVideoGameList.TabIndex = 27
        '
        'VideoGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(781, 394)
        Me.Controls.Add(Me.dgVideoGameList)
        Me.Controls.Add(Me.formatComboBox)
        Me.Controls.Add(Me.categoryComboBox)
        Me.Controls.Add(Me.ratingComboBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lateFeeTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rentalRateTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.salePriceTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printAllButton)
        Me.Controls.Add(Me.listAllButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "VideoGameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VideoGame Management Screen"
        CType(Me.dgVideoGameList,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents formatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents categoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ratingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lateFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rentalRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents salePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents descriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents titleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents printAllButton As System.Windows.Forms.Button
    Friend WithEvents listAllButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents dgVideoGameList As System.Windows.Forms.DataGridView
End Class
