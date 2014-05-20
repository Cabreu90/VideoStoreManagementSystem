<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentForm
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
        Me.dgOrderList = New System.Windows.Forms.DataGridView()
        Me.productComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.customerTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.daysTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgOrderList
        '
        Me.dgOrderList.AllowUserToAddRows = False
        Me.dgOrderList.AllowUserToDeleteRows = False
        Me.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderList.Location = New System.Drawing.Point(259, 57)
        Me.dgOrderList.Name = "dgOrderList"
        Me.dgOrderList.ReadOnly = True
        Me.dgOrderList.Size = New System.Drawing.Size(461, 231)
        Me.dgOrderList.TabIndex = 55
        '
        'productComboBox
        '
        Me.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productComboBox.FormattingEnabled = True
        Me.productComboBox.Items.AddRange(New Object() {"DVD", "VideoGame"})
        Me.productComboBox.Location = New System.Drawing.Point(127, 116)
        Me.productComboBox.Name = "productComboBox"
        Me.productComboBox.Size = New System.Drawing.Size(100, 21)
        Me.productComboBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-88, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Title:"
        '
        'idNumberTextBox
        '
        Me.idNumberTextBox.Location = New System.Drawing.Point(127, 74)
        Me.idNumberTextBox.Name = "idNumberTextBox"
        Me.idNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idNumberTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Product Number:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 29)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Product Rent Screen"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(259, 320)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(663, 320)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(57, 27)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(127, 159)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.amountTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Amount:"
        '
        'customerTextBox
        '
        Me.customerTextBox.Location = New System.Drawing.Point(127, 14)
        Me.customerTextBox.Name = "customerTextBox"
        Me.customerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.customerTextBox.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Customer Number:"
        '
        'daysTextBox
        '
        Me.daysTextBox.Location = New System.Drawing.Point(127, 200)
        Me.daysTextBox.Name = "daysTextBox"
        Me.daysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.daysTextBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Days:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(620, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Total:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(660, 297)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(0, 13)
        Me.totalLabel.TabIndex = 63
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(340, 320)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 7
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(579, 320)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(66, 27)
        Me.nextButton.TabIndex = 8
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'RentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 358)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.daysTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.customerTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgOrderList)
        Me.Controls.Add(Me.productComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "RentForm"
        Me.Text = "Rent Form"
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgOrderList As System.Windows.Forms.DataGridView
    Friend WithEvents productComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents customerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents daysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
End Class
