Option Explicit On
Option Strict On

Imports System.IO
Imports System.Data                                     'Data Access (DataSet)
Imports System.Data.OleDb                               'OLEDB Provider
Imports System.Configuration                            'Configuration File for DB Connection
Imports System.Collections                              'Collection Library

''' <summary>
''' Store and manage Customer Objects in memory and load/save them from TEXT FILE.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>

<Serializable()> _
Public Class CustomerList
    Inherits BusinessCollectionBase

#Region "Public Properties:"
    Public Shadows ReadOnly Property count As Integer
        Get
            Return MyBase.Dictionary.Count
        End Get
    End Property

    Public Property Item(ByVal key As String) As Customer
        Get

            Return CType(MyBase.Dictionary.Item(key), Customer)
        End Get

        Set(ByVal value As Customer)


            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = value
            Else

                Throw New System.ArgumentException("ID Not found")
            End If
        End Set
    End Property
#End Region
#Region "Public Methods:"
    Public Sub Add(ByVal key As String, ByVal objCustomer As Customer)

        Try

            MyBase.Dictionary.Add(key, objCustomer)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try
    End Sub

    Public Sub Add(ByVal IDN As String, ByVal strFName As String, ByVal strLName As String, ByVal SSN As String, _
                   ByVal dBDate As Date, ByVal strAddress As String, ByVal strPhone As String)

        Try

            Dim objCustomer As New Customer

            With objCustomer
                .IDNumber = IDN
                .FirstName = strFName
                .LastName = strLName
                .SSNumber = SSN
                .BirthDate = dBDate
                .Address = strAddress
                .Phone = strPhone
            End With

            MyBase.Dictionary.Add(objCustomer.IDNumber, objCustomer)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try

    End Sub

    Public Function Edit(ByVal key As String, ByVal objCustomer As Customer) As Boolean

        Try

            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = objCustomer

                Return True
            Else

                Return False
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("EditItem Error: " & objE.Message)
        End Try
    End Function

    Public Function Edit(ByVal IDN As String, ByVal strFName As String, ByVal strLName As String, ByVal SSN As String, _
                         ByVal dBDate As Date, ByVal strAddress As String, ByVal strPhone As String) As Boolean

        Try

            Dim objCustomer As Customer

            objCustomer = CType(MyBase.Dictionary.Item(IDN), Customer)

            If objCustomer Is Nothing Then

                Return False
            Else

                With objCustomer
                    .IDNumber = IDN
                    .FirstName = strFName
                    .LastName = strLName
                    .SSNumber = SSN
                    .BirthDate = dBDate
                    .Address = strAddress
                    .Phone = strPhone

                End With

                Return True
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("EditItem Error: " & objE.Message)
        End Try
    End Function

    Public Function Remove(ByVal key As String) As Boolean

        Try

            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Remove(key)

                Return True
            Else

                Return False
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("Remove Error: " & objE.Message)
        End Try
    End Function


    Public Function Print(ByVal key As String) As Boolean

        Try

            Dim objCustomer As Customer

            objCustomer = CType(MyBase.Dictionary.Item(key), Customer)

            If objCustomer Is Nothing Then

                Return False
            Else

                objCustomer.Print()

                Return True
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("PrintCustomer Error: " & objE.Message)
        End Try
    End Function

    Public Sub PrintAll()

        Try

            Dim objDictionaryEntry As DictionaryEntry
            Dim objCustomer As Customer

            For Each objDictionaryEntry In MyBase.Dictionary

                objCustomer = CType(objDictionaryEntry.Value, Customer)

                objCustomer.Print()
            Next

        Catch objE As Exception

            Throw New System.Exception("PrintAll Method Error: " & objE.Message)
        End Try
    End Sub

    Public Shadows Sub Clear()

        Try

            MyBase.Dictionary.Clear()

        Catch objex As Exception

            Throw New System.Exception("Unexpected error clearing List. " & objex.Message)
        End Try
    End Sub

#End Region
#Region "Helper Methods:"

    Public Function ToArray() As Customer()

        Dim arrCustomerList(MyBase.Dictionary.Count - 1) As Customer


        MyBase.Dictionary.Values.CopyTo(arrCustomerList, 0)
        Return arrCustomerList
    End Function
#End Region

#Region "Public Data Access Methods:"
    Public Shared Function Create() As CustomerList
        Return DataPortal_Create()
    End Function

    Public Sub Load(ByVal Key As String)

        DataPortal_Fetch(Key)
    End Sub

    Public Sub Save()
        If IsDirty Then
            DataPortal_Save()
        End If
    End Sub

    Public Sub ImmediateDelete(ByVal Key As String)
        DataPortal_Delete(Key)
    End Sub

#End Region

#Region " Deferred Delete"

    'Search and Find the first Dirty Child Object
    Public Overrides Function DeferredDelete(ByVal Key As String) As Boolean

        Dim objDEntry As DictionaryEntry
        Dim objItem As Customer

        Try

            'Search for Object to Mark Deferred Delete
            For Each objDEntry In MyBase.Dictionary
                objItem = CType(objDEntry.Value, Customer)
                'Find object
                If objItem.SSNumber = Key Then
                    'If NOT New 
                    If Not objItem.IsNew Then
                        'Mark Object for Deletion
                        objItem.DeferredDelete()
                        'Return True and exit
                        Return True
                    Else
                        'Do not mark for deletion if the object found isNew.
                        'return false and exit
                        Return False
                    End If
                End If
            Next

            'Search Completed. Object Not found return False
            Return False

        Catch objE As Exception
            Throw New System.Exception("Deferred Delete Method Error: " & objE.Message)
        End Try
    End Function
#End Region

#Region "Protected Data Access Methods:"
    ' Empty methods for future update
    Protected Shared Function DataPortal_Create() As CustomerList
        Return Nothing
    End Function

    Protected Sub DataPortal_Fetch(ByVal Key As String)
        'Temporary implementation
        Try
            Dim strLine As String

            If Not File.Exists("CustomerData.txt") Then

                File.Create("CustomerData.txt").Close()

            End If

            Dim objDataFile As New StreamReader("CustomerData.txt")

            Do While objDataFile.Peek <> -1

                strLine = objDataFile.ReadLine

                Dim tempArray() As String = Split(strLine, ",")

                Add(tempArray(0), tempArray(1), tempArray(2), tempArray(3), _
                CDate(tempArray(4)), tempArray(5), tempArray(6))
            Loop

            objDataFile.Close()

        Catch objE As Exception

            Throw New System.Exception("Fetch Error: " & objE.Message)
        End Try
    End Sub

    ''' <summary>
    ''' SAVES all objects from database by Iterating through Collection, and 
    ''' calling Each ITEM object SAVE() method so each Item saves itself
    ''' </summary>
    Protected Sub DataPortal_Save()
        'Iterates through Collection, Calling Each CHILD object.Save() method
        'CHILD Objects save themselves
        'Step A- Begin Error trapping
        Try
            '    'Step 1-Step 1-Create Temporary Person and Dictionary object POINTERS
            '    Dim objDictionaryEntry As DictionaryEntry
            '    Dim objChild As Customer

            '    'Step 2-Use For..Each loop to iterate through Collection
            '    For Each objDictionaryEntry In MyBase.Dictionary
            '        'Step 3-Convert DictionaryEntry pointer returned to Type Person
            '        objChild = CType(objDictionaryEntry.Value, Customer)

            '        'Step 4-Call Child to Save itself
            '        objChild.Save()

            '    Next


            Dim objWrite As New StreamWriter("CustomerData.txt")

            Dim objDictionaryEntry As DictionaryEntry
            Dim objCustomer As Customer

            For Each objDictionaryEntry In MyBase.Dictionary

                objCustomer = CType(objDictionaryEntry.Value, Customer)

                objWrite.WriteLine(objCustomer.IDNumber & "," & _
                                   objCustomer.FirstName & "," & _
                                   objCustomer.LastName & "," & _
                                   objCustomer.SSNumber & "," & _
                                   objCustomer.BirthDate & "," & _
                                   objCustomer.Address & "," & _
                                   objCustomer.Phone)
            Next

            objWrite.Close()

            'Step B-Traps for general exceptions.  
        Catch objE As Exception
            'Step C-Throw an general exceptions
            Throw New System.Exception("Dataportal Save Error! " & objE.Message)
        End Try
    End Sub


    Protected Sub DataPortal_Update()

    End Sub

    Protected Sub DataPortal_Insert()

    End Sub

    Protected Sub DataPortal_Delete(ByVal Key As String)
        'Iterates through Collection, Calling Each CHILD object.Delete() method
        'CHILD Objects Delete themselves

        'Step A- Begin Error trapping
        Try
            'Step 1-Step 1-Create Temporary Person and Dictionary object POINTERS
            Dim objDictionaryEntry As DictionaryEntry
            Dim objItem As Customer

            'Step 2-Use For..Each loop to iterate through Collection
            For Each objDictionaryEntry In MyBase.Dictionary
                'Step 3-Convert DictionaryEntry pointer returned to Type Person
                objItem = CType(objDictionaryEntry.Value, Customer)

                'Step 4-Find target object based on key
                'YOU WILL NEED TO SELECT THE CORRECT PROPERTY
                If objItem.SSNumber = Key Then

                    'Step 5-Object deletes itself
                    objItem.ImmediateDelete(Key)
                End If
            Next
            'Step B-Traps for general exceptions.  
        Catch objE As Exception
            'Step C-Throw an general exceptions
            Throw New System.Exception("Dataportal Delete Error! " & objE.Message)
        End Try
    End Sub

#End Region

End Class
