Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class RentForm
    Private objVideoGame As VideoGame
    Private dvdobj As DVD
    Private objCustomer As Customer

    Dim totalCost As Double = 0


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

            objDVDList = New DVDList
            objDVDList.Load("")

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Verifing if the customer number is valid after the user finish typing in customerBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerTextBox_TextLeave(sender As System.Object, e As System.EventArgs) Handles idNumberTextBox.Enter
        Try
            objCustomer = objCustomerList.Item(customerTextBox.Text.Trim)


            If objCustomer Is Nothing Then
                MessageBox.Show("Customer Not Found")

                'Clear all controls
                customerTextBox.Text = ""

                customerTextBox.Focus()

            Else

                customerTextBox.ReadOnly = True
            End If


        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Saving changes to database, reseting controls, and destroying objects after closing form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rentForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            ' Getting clearing text box
            customerTextBox.Clear()
            customerTextBox.ReadOnly = False

            ' Destroying objects
            objVideoGame = Nothing
            dvdobj = Nothing
            objCustomer = Nothing

            ' Saving changes to database
            objCustomerList.Save()
            objVideoGameList.Save()
            objDVDList.Save()

            ' Clearing DataGridView
            dgOrderList.DataSource = Nothing

            ' Dstroying objects in the list/collection
            objCustomerList.Clear()
            objVideoGameList.Clear()
            objDVDList.Clear()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Displaying the order in the DataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub addButton_Click(sender As System.Object, e As System.EventArgs) Handles addButton.Click

        Dim row As String()
        Dim itemCost As Double = 0

        ' Setting up DataGridView
        dgOrderList.ColumnCount = 6
        dgOrderList.Columns(0).Name = "ProductID"
        dgOrderList.Columns(1).Name = "Item"
        dgOrderList.Columns(2).Name = "Amount"
        dgOrderList.Columns(3).Name = "Title"
        dgOrderList.Columns(4).Name = "Days"
        dgOrderList.Columns(5).Name = "Cost"

        Try
            ' No fields should be empty
            If (idNumberTextBox.Text.ToString = "" Or amountTextBox.Text.ToString = "" _
                Or productComboBox.SelectedItem.ToString = "" Or daysTextBox.Text = "") Then
                MessageBox.Show("You left a text field empty.")

            ElseIf (CInt(amountTextBox.Text) < 1) Then
                MessageBox.Show("Invalid value entered.")

            Else
                ' Find the apropriate product
                If (productComboBox.SelectedItem.ToString = "DVD") Then
                    dvdobj = objDVDList.Item(idNumberTextBox.Text.Trim)

                    If dvdobj Is Nothing Then
                        MessageBox.Show("DVD not found!")

                    Else
                        If (dvdobj.Available) Then
                            itemCost = dvdobj.RentalRate * CInt(amountTextBox.Text) * CInt(daysTextBox.Text)

                            ' Filling DataGridView with DVD data
                            row = New String() {idNumberTextBox.Text.Trim, productComboBox.SelectedItem.ToString, amountTextBox.Text.Trim,
                                                dvdobj.Title.ToString, daysTextBox.Text, itemCost.ToString}
                            dgOrderList.Rows.Add(row)

                            ' One customer per item, the store is really small lol
                            dvdobj.Available = False

                            totalCost += itemCost
                        Else
                            MessageBox.Show("The DVD/BD is not currently available.")
                        End If
                    End If
                ElseIf (productComboBox.SelectedItem.ToString = "VideoGame") Then
                    objVideoGame = objVideoGameList.Item(idNumberTextBox.Text.Trim)

                    If objVideoGame Is Nothing Then
                        MessageBox.Show("VideoGame not found!")

                    Else
                        If (objVideoGame.Available) Then
                            itemCost = objVideoGame.RentalRate * CInt(amountTextBox.Text) * CInt(daysTextBox.Text) ' Calculating cost

                            ' Filling datagrid with Video Game data
                            row = New String() {idNumberTextBox.Text.Trim, productComboBox.SelectedItem.ToString, amountTextBox.Text.Trim,
                                                objVideoGame.Title, daysTextBox.Text, itemCost.ToString}
                            dgOrderList.Rows.Add(row)

                            ' One customer per item, the store is really small lol
                            objVideoGame.Available = False

                            totalCost += itemCost
                        Else
                            MessageBox.Show("The video game is not currently available.")
                        End If
                    End If
                End If
            End If

            ' Displaying the total amount of dollars the customer owes
            totalLabel.Text = totalCost.ToString("C")

            ' Getting form ready for next product.
            idNumberTextBox.Text = ""
            amountTextBox.Text = ""
            daysTextBox.Text = ""
            idNumberTextBox.Focus()


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

        ' Going through each selected item
        For Each row As DataGridViewRow In dgOrderList.SelectedRows

            ' Checking if the item is a Movie or video game
            If (row.Cells(1).Value.ToString = "DVD") Then
                dvdobj = objDVDList.Item(row.Cells(0).Value.ToString)       ' If the item is a dvd, find its corresponding data

                ' Making the movie available again
                dvdobj.Available = True

            ElseIf (row.Cells(1).Value.ToString = "VideoGame") Then
                objVideoGame = objVideoGameList.Item(row.Cells(0).Value.ToString)  ' If the item is a video game, find its data

                ' Making the video game available again
                objVideoGame.Available = True

            End If

            ' Removing item from gridview
            dgOrderList.Rows.Remove(row)
        Next
    End Sub

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
    ''' Setting everything up for next customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click

        ' Getting form ready for next product.
        idNumberTextBox.Text = ""
        amountTextBox.Text = ""
        daysTextBox.Text = ""
        totalLabel.Text = ""
        totalCost = 0
        dgOrderList.Rows.Clear()
        customerTextBox.Text = ""
        customerTextBox.ReadOnly = False
        customerTextBox.Focus()

    End Sub
End Class