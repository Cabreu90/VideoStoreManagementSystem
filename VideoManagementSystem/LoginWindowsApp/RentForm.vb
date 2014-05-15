Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class RentForm
    Private objVideoGame As VideoGame
    Private dvdobj As DVD
    Private objCustomer As Customer

    ''' <summary>
    ''' Closing form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Verifing if the if the customer number is valid after the user finish typing the input.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerTextBox_TextLeave(sender As System.Object, e As System.EventArgs) Handles idNumberTextBox.Enter
        Try
            objCustomer = objCustomerList.Item(CustomerTextBox.Text.Trim)


            If objCustomer Is Nothing Then
                MessageBox.Show("Customer Not Found")

                'Clear all controls
                CustomerTextBox.Text = ""

                CustomerTextBox.Focus()

            Else

                CustomerTextBox.ReadOnly = True
            End If


        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Creating customer, DVD, and Video Game lists and populating them with customer objects when the form is loaded.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RentForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'new
            objCustomerList = New CustomerList
            objCustomerList.Load()

            objVideoGameList = New VideoGameList
            objVideoGameList.Load()

            'objDVDList = New DVDList
            'objDVDList.Load("")

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub


    Private Sub rentForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try

            CustomerTextBox.Clear()
            CustomerTextBox.ReadOnly = False

            objVideoGame = Nothing
            dvdobj = Nothing
            objCustomer = Nothing

            'objCustomerList.Save()


            dgOrderList.DataSource = Nothing

            objCustomerList.Clear()
            objVideoGameList.Clear()
            objDVDList.Clear()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub addButton_Click(sender As System.Object, e As System.EventArgs) Handles addButton.Click

        Dim row As String()

        ' Setting DataGridView
        dgOrderList.ColumnCount = 3
        dgOrderList.Columns(0).Name = "ProductID"
        dgOrderList.Columns(1).Name = "Item"
        dgOrderList.Columns(2).Name = "Amount"

        Try
            If (productComboBox.SelectedItem.ToString = "DVD") Then
                dvdobj = objDVDList.Item(idNumberTextBox.Text.Trim)

                If dvdobj Is Nothing Then
                    MessageBox.Show("DVD not found!")
                Else
                    ' Filling datagrid with DVD data
                    row = New String() {idNumberTextBox.Text.Trim, productComboBox.SelectedItem.ToString, amountTextBox.Text.Trim}
                    dgOrderList.Rows.Add(row)

                    'todo: dvd code

                End If
            ElseIf (productComboBox.SelectedItem.ToString = "VideoGame") Then
                objVideoGame = objVideoGameList.Item(idNumberTextBox.Text.Trim)

                If objVideoGame Is Nothing Then
                    MessageBox.Show("VideoGame not found!")
                Else
                    ' Filling datagrid with Video Game data
                    row = New String() {idNumberTextBox.Text.Trim, productComboBox.SelectedItem.ToString, amountTextBox.Text.Trim}
                    dgOrderList.Rows.Add(row)

                    'todo: Video Game code 

                End If

            End If


            ' Getting form ready for next product.
            idNumberTextBox.Text = ""
            amountTextBox.Text = ""

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Removing a product from the order.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub removeButton_Click(sender As System.Object, e As System.EventArgs) Handles removeButton.Click

        For Each row As DataGridViewRow In dgOrderList.SelectedRows
            dgOrderList.Rows.Remove(row)
        Next

    End Sub
End Class