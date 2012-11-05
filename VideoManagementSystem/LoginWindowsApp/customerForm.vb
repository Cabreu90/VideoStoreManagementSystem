Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class customerForm
    Private objCustomer As Customer

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

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

    Private Sub customerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try


            objCustomerList.Load("")

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

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

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Try
            Dim bolResults As Boolean

            objEmployeeList.DeferredDelete(idnumberTextBox.Text.Trim)
            bolResults = objCustomerList.Remove(idnumberTextBox.Text.Trim)

            If bolResults <> True Then
                MessageBox.Show("Customer Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

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

    Private Sub printAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printAllButton.Click
        Try
            objCustomerList.PrintAll()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

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