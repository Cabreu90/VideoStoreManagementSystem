Option Explicit On
Option Strict On
Imports ClassLibrary
Imports System.IO

''' <summary>
''' This application processes the daily rentals, returns, and processing of DVDs and Video games. 
''' It also provides features to manage the customers and employees.
''' </summary>
''' <remarks></remarks>

Module MainModule
    'Collections
    Public objEmployeeList As New EmployeeList
    Public objDVDList As New DVDList
    Public objCustomerList As New CustomerList
    Public objVideoGameList As New VideoGameList


    Sub Main()

        Try
            'support Windows Form
            Application.EnableVisualStyles()

            Dim objAdmin As New Employee("", "Administrator", "", #1/1/1900#, "", "212-555-1313", "Administrator", "admin", "999")
            Dim userName As String = "-1"
            Dim passWord As String = "-1"
            Dim blnResults As Boolean = True
            Dim objLoginFormObject As New loginForm


            objLoginFormObject.GetUserInfoAndDisplayForm(userName, passWord)
            Do While userName <> "-1" Or passWord <> "-1"


                If Not (userName = objAdmin.UserName And passWord = objAdmin.Password) Then
                    blnResults = objEmployeeList.Authenticate(userName, passWord)
                End If

                If blnResults Then

                    'display the main screen if the access is granted
                    MainForm.ShowDialog()
                Else
                    'Otherwise display Access Denied
                    MsgBox("Access Denied.")
                End If

                blnResults = True
                objLoginFormObject.GetUserInfoAndDisplayForm(userName, passWord)
            Loop


        Catch objException As Exception
            MessageBox.Show(objException.Message)
        End Try
    End Sub
End Module
