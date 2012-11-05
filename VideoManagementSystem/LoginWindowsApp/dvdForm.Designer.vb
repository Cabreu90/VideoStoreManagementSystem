<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dvdForm
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.printAllButton = New System.Windows.Forms.Button()
        Me.listAllButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.ratingComboBox = New System.Windows.Forms.ComboBox()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.formatComboBox = New System.Windows.Forms.ComboBox()
        Me.dgDVDList = New System.Windows.Forms.DataGridView()
        CType(Me.dgDVDList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Format:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Category:"
        '
        'lateFeeTextBox
        '
        Me.lateFeeTextBox.Location = New System.Drawing.Point(81, 287)
        Me.lateFeeTextBox.Name = "lateFeeTextBox"
        Me.lateFeeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lateFeeTextBox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "LateFee:"
        '
        'rentalRateTextBox
        '
        Me.rentalRateTextBox.Location = New System.Drawing.Point(82, 259)
        Me.rentalRateTextBox.Name = "rentalRateTextBox"
        Me.rentalRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.rentalRateTextBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "RentalRate:"
        '
        'salePriceTextBox
        '
        Me.salePriceTextBox.Location = New System.Drawing.Point(81, 228)
        Me.salePriceTextBox.Name = "salePriceTextBox"
        Me.salePriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.salePriceTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SalePrice:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Rating:"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(81, 138)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(146, 46)
        Me.descriptionTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(81, 104)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.titleTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Title:"
        '
        'idNumberTextBox
        '
        Me.idNumberTextBox.Location = New System.Drawing.Point(81, 72)
        Me.idNumberTextBox.Name = "idNumberTextBox"
        Me.idNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idNumberTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IDNumber:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 40)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "DVD Management Screen"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(650, 359)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(64, 32)
        Me.exitButton.TabIndex = 26
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'printAllButton
        '
        Me.printAllButton.Location = New System.Drawing.Point(488, 359)
        Me.printAllButton.Name = "printAllButton"
        Me.printAllButton.Size = New System.Drawing.Size(75, 23)
        Me.printAllButton.TabIndex = 25
        Me.printAllButton.Text = "Print All"
        Me.printAllButton.UseVisualStyleBackColor = True
        '
        'listAllButton
        '
        Me.listAllButton.Location = New System.Drawing.Point(650, 316)
        Me.listAllButton.Name = "listAllButton"
        Me.listAllButton.Size = New System.Drawing.Size(64, 32)
        Me.listAllButton.TabIndex = 23
        Me.listAllButton.Text = "List All"
        Me.listAllButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(488, 330)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 24
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(395, 330)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 19
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(308, 359)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 20
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(395, 359)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 21
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(308, 330)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 18
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'ratingComboBox
        '
        Me.ratingComboBox.FormattingEnabled = True
        Me.ratingComboBox.Items.AddRange(New Object() {"G", "PG", "PG-13", "NC-17", "R", "NONE"})
        Me.ratingComboBox.Location = New System.Drawing.Point(81, 196)
        Me.ratingComboBox.Name = "ratingComboBox"
        Me.ratingComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ratingComboBox.TabIndex = 7
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Action_Adventure", "Drama", "Family_Kids", "Horror", "Sci-Fi_Fantasy", "Music", "Sports", "Romance", "Comedy", "Western", "None"})
        Me.categoryComboBox.Location = New System.Drawing.Point(80, 318)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(133, 21)
        Me.categoryComboBox.TabIndex = 15
        '
        'formatComboBox
        '
        Me.formatComboBox.FormattingEnabled = True
        Me.formatComboBox.Items.AddRange(New Object() {"DVD", "HD-DVD", "BLUE-RAY DISC", "None"})
        Me.formatComboBox.Location = New System.Drawing.Point(80, 354)
        Me.formatComboBox.Name = "formatComboBox"
        Me.formatComboBox.Size = New System.Drawing.Size(133, 21)
        Me.formatComboBox.TabIndex = 17
        '
        'dgDVDList
        '
        Me.dgDVDList.AllowUserToAddRows = False
        Me.dgDVDList.AllowUserToDeleteRows = False
        Me.dgDVDList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDVDList.Location = New System.Drawing.Point(233, 72)
        Me.dgDVDList.Name = "dgDVDList"
        Me.dgDVDList.ReadOnly = True
        Me.dgDVDList.Size = New System.Drawing.Size(481, 231)
        Me.dgDVDList.TabIndex = 37
        '
        'dvdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(734, 396)
        Me.Controls.Add(Me.dgDVDList)
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
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printAllButton)
        Me.Controls.Add(Me.listAllButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.searchButton)
        Me.Name = "dvdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DVD Management Screen"
        CType(Me.dgDVDList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents printAllButton As System.Windows.Forms.Button
    Friend WithEvents listAllButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents ratingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents categoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents formatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dgDVDList As System.Windows.Forms.DataGridView
End Class
