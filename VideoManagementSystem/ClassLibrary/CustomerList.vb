Option Explicit On
Option Strict On

Imports System.IO
Imports System.Data                                     'Data Access (DataSet)
Imports System.Data.OleDb                               'OLEDB Provider
Imports System.Configuration                            'Configuration File for DB Connection
Imports System.Collections                              'Collection Library

''' <summary>
''' Store and manage Customer Objects in memory and load/save them
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>

<Serializable()> _
Public Class CustomerList
    Inherits BusinessCollectionBase

#Region "Database Connection"
    ' Creating a connection potinter
    Private Connection As OleDbConnection

    ' Connection string with database location
    Private Const connStr As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Management.accdb"

    ' Database command
    Private cmd As New OleDbCommand
#End Region

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

    Public Sub Load()

        DataPortal_Fetch()
    End Sub

    Public Sub Save()

        DataPortal_Save()
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
                If objItem.IDNumber = Key Then
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

    Protected Sub DataPortal_Fetch()

        ' Start trapping errors 
        Try
            Connection = New OleDbConnection(connStr)

            ' Open database connection 
            Connection.Open()

            ' Create SQL string to get all Primary Keys of Customers 
            Dim strSQL As String = "SELECT IDNumber FROM Customer"

            ' Create Command object 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Create DATAREADER object & Execute Query 
            Dim objDR As OleDbDataReader = objCmd.ExecuteReader

            ' Test to make sure there is data in the DataReader Object 
            If objDR.HasRows Then

                ' Iterate through DataReader one record at a time. 
                Do While objDR.Read

                    ' Create Customer Object 
                    Dim objItem As New Customer

                    ' Get Key from DataReader record 
                    Dim strKey As String = objDR.GetValue(0).ToString

                    ' ITEM will load itself based on key. 
                    objItem.Load(strKey)

                    ' Add object to collection 
                    Me.Add(objItem.IDNumber, objItem)

                    ' Terminate new object 
                    objItem = Nothing
                Loop
            Else

                ' No data returned, Record not found. 
                Throw New System.ApplicationException("Load Error! Record Not Found")
            End If

            ' Terminate Command Object 
            objCmd.Dispose()
            objCmd = Nothing
            objDR.Close()
            objDR = Nothing

            ' Trap all Business Object, OleDB & general Exceptions 
        Catch objBOEx As NotSupportedException
            Throw New System.NotSupportedException(objBOEx.Message)
        Catch objA As ApplicationException
            Throw New System.ApplicationException(objA.Message)
        Catch objEx As Exception
            Throw New System.Exception("Load Error: " & objEx.Message)
        Finally

            ' Terminate connection 
            Connection.Close()
            Connection.Dispose()
            Connection = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' SAVES all objects from database by Iterating through Collection, and 
    ''' calling Each ITEM object SAVE() method so each Item saves itself
    ''' </summary>
    Protected Sub DataPortal_Save()
        'Iterates through Collection, Calling Each CHILD object.Save() method
        'CHILD Objects save themselves

        ' Begin trapping errors
        Try
            ' Create Temporary Person and Dictionary object POINTERS
            Dim objDictionaryEntry As DictionaryEntry
            Dim objChild As Customer

            ' Use For..Each loop to iterate through Collection 
            For Each objDictionaryEntry In MyBase.Dictionary

                ' Convert DictionaryEntry pointer returned to Type Person 
                objChild = CType(objDictionaryEntry.Value, Customer)

                ' Call Child to Save itself 
                objChild.Save()
            Next

            ' Trap general exceptions.
        Catch objE As Exception
            ' Throw an general exceptions
            Throw New System.Exception("Save Error! " & objE.Message)
        End Try
    End Sub


    Protected Sub DataPortal_Delete(ByVal Key As String)
        'Iterates through Collection, Calling Each CHILD object.Delete() method
        'CHILD Objects Delete themselves


        ' Begin Error trapping
        Try
            ' Create Temporary Person and Dictionary object POINTERS
            Dim objDictionaryEntry As DictionaryEntry
            Dim objItem As Customer

            ' Use For..Each loop to iterate through Collection
            For Each objDictionaryEntry In MyBase.Dictionary
                ' Convert DictionaryEntry pointer returned to Type Person
                objItem = CType(objDictionaryEntry.Value, Customer)
                ' Find target object based on key
                If objItem.IDNumber = Key Then

                    'Step 5-Object deletes itself
                    objItem.ImmediateDelete(Key)
                End If
            Next


            ' Traps for general exceptions.  
        Catch objE As Exception
            ' Throw an general exceptions
            Throw New System.Exception("Dataportal Delete Error! " & objE.Message)
        End Try
    End Sub

#End Region

End Class
