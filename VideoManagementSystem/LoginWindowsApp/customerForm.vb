Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class customerForm
    Private objCustomer As Customer
    ''' <summary>
    ''' Closes the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Saves all changes to the database when the form is closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks> It also resets form's variables.</remarks>
    Private Sub customerForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            objCustomerList.Save()
            dgCustomerList.DataSource = Nothing
            objCustomerList.Clear()
            objCustomer = Nothing

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Creates a customer list and populates it with customer objects when the form is loaded.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'new
            objCustomerList = New CustomerList

            objCustomerList.Load()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Looks for the the customer with the ID Number provided by the user and populate textboxes with the customer data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Try
            objCustomer = objCustomerList.Item(idnumberTextBox.Text.Trim)

            
            If objCustomer Is Nothing Then
                MessageBox.Show("Customer Not Found")

                'Clear all controls
                idnumberTextBox.Text = ""
                fnameTextBox.Text = ""
                lnameTextBox.Text = ""
                ssnumberTextBox.Text = ""
                birthdateTextBox.Text = ""
                addressTextBox.Text = ""
                phoneTextBox.Text = ""
                
                idnumberTextBox.Focus()

            Else

                With objCustomer
                    idnumberTextBox.Text = .IDNumber
                    fnameTextBox.Text = .FirstName
                    lnameTextBox.Text = .LastName
                    ssnumberTextBox.Text = .SSNumber
                    birthdateTextBox.Text = CStr(.BirthDate)
                    addressTextBox.Text = .Address
                    phoneTextBox.Text = .Phone

                End With
            End If


        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Adds new customers to the customer list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try

            objCustomerList.Add(idnumberTextBox.Text.Trim, fnameTextBox.Text.Trim, lnameTextBox.Text.Trim, ssnumberTextBox.Text.Trim, _
            CDate(birthdateTextBox.Text), addressTextBox.Text.Trim, phoneTextBox.Text.Trim)

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objY As ArgumentException

            MessageBox.Show(objY.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Removes customers from customer list and database.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Try
            Dim bolResults As Boolean

            objCustomerList.ImmediateDelete(idnumberTextBox.Text.Trim)
            bolResults = objCustomerList.Remove(idnumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("Customer Not Found!")
            End If

            ' Traps rules violation
        Catch objNSE As NotSupportedException
            MessageBox.Show("Business Rule violation! " & objNSE.Message)

            ' Traps invalid key
        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

            ' Traps general exceptions
        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Prints the customer with the id number provided to the Network_Printer text file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        Try
            Dim bolResults As Boolean

            bolResults = objCustomerList.Print(idnumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("Customer Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Print all the customer information to the Network_Printer text file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printAllButton.Click
        Try
            objCustomerList.PrintAll()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Show all the customers information in the DataGrid.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub listAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listAllButton.Click
        Try
           'Optional- refresh the data grid 
            dgCustomerList.Refresh()
            'Bind Custom Array Object to DataGrid 
            dgCustomerList.DataSource = objCustomerList.ToArray()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Modifies and Updates the customer imformation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Try
            Dim bolResults As Boolean

            bolResults = objCustomerList.Edit(idnumberTextBox.Text.Trim, fnameTextBox.Text.Trim, lnameTextBox.Text.Trim, ssnumberTextBox.Text.Trim, _
            CDate(birthdateTextBox.Text), addressTextBox.Text.Trim, phoneTextBox.Text.Trim)

            If bolResults <> True Then
                MessageBox.Show("Customer Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

End Class