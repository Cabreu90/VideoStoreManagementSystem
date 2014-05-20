<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnsForm
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
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgOrderList = New System.Windows.Forms.DataGridView()
        Me.productComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.Location = New System.Drawing.Point(115, 17)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerTextBox.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Customer Number:"
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(115, 162)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.amountTextBox.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Amount:"
        '
        'dgOrderList
        '
        Me.dgOrderList.AllowUserToAddRows = False
        Me.dgOrderList.AllowUserToDeleteRows = False
        Me.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderList.Location = New System.Drawing.Point(247, 60)
        Me.dgOrderList.Name = "dgOrderList"
        Me.dgOrderList.ReadOnly = True
        Me.dgOrderList.Size = New System.Drawing.Size(461, 231)
        Me.dgOrderList.TabIndex = 74
        '
        'productComboBox
        '
        Me.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productComboBox.FormattingEnabled = True
        Me.productComboBox.Items.AddRange(New Object() {"DVD", "VideoGame"})
        Me.productComboBox.Location = New System.Drawing.Point(115, 119)
        Me.productComboBox.Name = "productComboBox"
        Me.productComboBox.Size = New System.Drawing.Size(100, 21)
        Me.productComboBox.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Item:"
        '
        'idNumberTextBox
        '
        Me.idNumberTextBox.Location = New System.Drawing.Point(115, 77)
        Me.idNumberTextBox.Name = "idNumberTextBox"
        Me.idNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idNumberTextBox.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Product Number:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 29)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Product Rent Screen"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(247, 323)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 69
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(662, 323)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(46, 27)
        Me.exitButton.TabIndex = 70
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'returnsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 353)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgOrderList)
        Me.Controls.Add(Me.productComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.idNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "returnsForm"
        Me.Text = "returnsForm"
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgOrderList As System.Windows.Forms.DataGridView
    Friend WithEvents productComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents idNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
