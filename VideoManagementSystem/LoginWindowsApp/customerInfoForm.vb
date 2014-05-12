Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class customerInfoForm
    Private objCustomer As Customer


    ''' <summary>
    ''' Looks for the the customer with the ID Number provided by the user and populate textboxes with the customer data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub searchButton_Click(sender As System.Object, e As System.EventArgs) Handles searchButton.Click
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
    ''' Closes the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Clear customer list and destroy customer object when the form is closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        objCustomerList.Clear()
        objCustomer = Nothing

        'Clear all controls
        idnumberTextBox.Text = ""
        fnameTextBox.Text = ""
        lnameTextBox.Text = ""
        ssnumberTextBox.Text = ""
        birthdateTextBox.Text = ""
        addressTextBox.Text = ""
        phoneTextBox.Text = ""

    End Sub



    ''' <summary>
    ''' Creates a customer list and populates it with customer objects when the customer information form is loaded.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerInfoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'new
            objCustomerList = New CustomerList

            objCustomerList.Load()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub
End Class