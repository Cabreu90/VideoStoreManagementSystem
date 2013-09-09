Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class employeeForm

    Private objTemp As Employee
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub employeeForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try

            objTemp = Nothing
            objEmployeeList.Save()
            dgEmployeeList.DataSource = Nothing
            objEmployeeList.Clear()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub employeeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'load objects
        Try
            objEmployeeList = New EmployeeList

            objEmployeeList.Load()

        Catch objE As Exception
            MessageBox.Show(objE.Message)
        End Try

    End Sub

    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Try
            objTemp = objEmployeeList.Item(ssnumberTextBox.Text.Trim)


            If objTemp Is Nothing Then
                MessageBox.Show("Employee Not Found")

                'Clear all controls
                ssnumberTextBox.Text = ""
                fnameTextBox.Text = ""
                lnameTextBox.Text = ""
                birthdateTextBox.Text = ""
                addressTextBox.Text = ""
                phoneTextBox.Text = ""
                jobtitleTextBox.Text = ""
                unameTextBox.Text = ""
                pwordTextBox.Text = ""

                ssnumberTextBox.Focus()

            Else


                With objTemp
                    ssnumberTextBox.Text = .SSNumber
                    fnameTextBox.Text = .FirstName
                    lnameTextBox.Text = .LastName
                    birthdateTextBox.Text = CStr(.Birthdate)
                    addressTextBox.Text = .Address
                    phoneTextBox.Text = .Phone
                    jobtitleTextBox.Text = .JobTitle
                    unameTextBox.Text = .UserName
                    pwordTextBox.Text = .Password

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
            
            objEmployeeList.Add(ssnumberTextBox.Text.Trim, fnameTextBox.Text.Trim, lnameTextBox.Text.Trim, _
            CDate(birthdateTextBox.Text), addressTextBox.Text.Trim, phoneTextBox.Text.Trim, _
            jobtitleTextBox.Text.Trim, unameTextBox.Text.Trim, pwordTextBox.Text.Trim)

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objY As ArgumentException

            MessageBox.Show(objY.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Try
            Dim bolResults As Boolean

            bolResults = objEmployeeList.Edit(ssnumberTextBox.Text.Trim, fnameTextBox.Text.Trim, lnameTextBox.Text.Trim, _
            CDate(birthdateTextBox.Text), addressTextBox.Text.Trim, phoneTextBox.Text.Trim, _
            jobtitleTextBox.Text.Trim, unameTextBox.Text.Trim, pwordTextBox.Text.Trim)

            If bolResults <> True Then
                MessageBox.Show("Employee Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Try
            Dim bolResults As Boolean

            objEmployeeList.ImmediateDelete(ssnumberTextBox.Text.Trim)
            bolResults = objEmployeeList.Remove(ssnumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("Employee Not Found")
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


            bolResults = objEmployeeList.Print(ssnumberTextBox.Text.Trim)


            If bolResults <> True Then
                MessageBox.Show("Employee Not Found")
            End If

        Catch objX As ArgumentNullException

            MessageBox.Show(objX.Message)

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub printAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printAllButton.Click
        Try
            objEmployeeList.PrintAll()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub

    Private Sub listAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listAllButton.Click
        Try
            'Optional- refresh the data grid 
            dgEmployeeList.Refresh()

            'Bind Custom Array Object to DataGrid 
            dgEmployeeList.DataSource = objEmployeeList.ToArray()

        Catch objE As Exception

            MessageBox.Show(objE.Message)
        End Try
    End Sub
End Class