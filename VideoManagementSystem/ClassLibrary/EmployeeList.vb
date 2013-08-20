Option Explicit On
Option Strict On

Imports System.IO
Imports System.Data                                     'Data Access (DataSet)
Imports System.Data.OleDb                               'OLEDB Provider
Imports System.Configuration                            'Configuration File for DB Connection
Imports System.Collections                              'Collection Library

''' <summary>
''' Store and manage Employee Objects in memory and load/save them from TEXT FILE.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>

<Serializable()> _
Public Class EmployeeList
    Inherits BusinessCollectionBase

    ''' <summary>
    ''' Database connection -incase
    ''' </summary>
    ''' <remarks></remarks>
    Private Const strConn As String = "Provider=Microsoft.Jet.OleDB.4.0;" & _
        "Data Source=MANAGEMENT.mdb"
    ''creating connection object
    Dim conn As OleDbConnection = New OleDbConnection(strConn)
    Dim cmd As OleDbCommand
    Dim _dataAdapter As OleDbDataAdapter
    Dim _dataSet As DataSet

#Region "Public Properties:"
    Public Shadows ReadOnly Property count As Integer
        Get
            Return MyBase.Dictionary.Count
        End Get
    End Property

    Public Property Item(ByVal key As String) As Employee
        Get

            Return CType(MyBase.Dictionary.Item(key), Employee)
        End Get

        Set(ByVal value As Employee)


            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = value
            Else

                Throw New System.ArgumentException("Key Not found")
            End If
        End Set
    End Property
#End Region

#Region "Public Methods:"
    Public Sub Add(ByVal key As String, ByVal objEmployee As Employee)

        Try

            MyBase.Dictionary.Add(key, objEmployee)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try
    End Sub

    Public Sub Add(ByVal SSN As String, ByVal strFName As String, ByVal strLName As String, _
                   ByVal dBDate As Date, ByVal strAddress As String, ByVal strPhone As String, _
                   ByVal JobTlt As String, ByVal uname As String, ByVal pword As String)

        Try

            Dim objEmployee As New Employee

            With objEmployee
                .SSNumber = SSN
                .FirstName = strFName
                .LastName = strLName
                .Birthdate = dBDate
                .Address = strAddress
                .Phone = strPhone
                .JobTitle = JobTlt
                .UserName = uname
                .Password = pword

            End With

            MyBase.Dictionary.Add(objEmployee.SSNumber, objEmployee)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try

    End Sub

    Public Function Edit(ByVal key As String, ByVal objEmployee As Employee) As Boolean

        Try

            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = objEmployee

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

    Public Function Edit(ByVal SSN As String, ByVal strFName As String, ByVal strLName As String, _
                   ByVal dBDate As Date, ByVal strAddress As String, ByVal strPhone As String, _
                   ByVal JobTlt As String, ByVal uname As String, ByVal pword As String) As Boolean

        Try

            Dim objEmployee As Employee

            objEmployee = CType(MyBase.Dictionary.Item(SSN), Employee)

            If objEmployee Is Nothing Then

                Return False
            Else

                With objEmployee
                    .SSNumber = SSN
                    .FirstName = strFName
                    .LastName = strLName
                    .Birthdate = dBDate
                    .Address = strAddress
                    .Phone = strPhone
                    .JobTitle = JobTlt
                    .UserName = uname
                    .Password = pword
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

            Dim objEmployee As Employee

            objEmployee = CType(MyBase.Dictionary.Item(key), Employee)

            If objEmployee Is Nothing Then

                Return False
            Else

                objEmployee.Print()

                Return True
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("PrintEmployee Error: " & objE.Message)
        End Try
    End Function

    Public Sub PrintAll()

        Try

            Dim objDictionaryEntry As DictionaryEntry
            Dim objEmployee As Employee

            For Each objDictionaryEntry In MyBase.Dictionary

                objEmployee = CType(objDictionaryEntry.Value, Employee)

                objEmployee.Print()
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

    Public Function Authenticate(ByVal u As String, ByVal p As String) As Boolean
        Try
            Dim objDictionaryEntry As DictionaryEntry
            Dim objEmployee As Employee

            Load("")

            For Each objDictionaryEntry In MyBase.Dictionary


                objEmployee = CType(objDictionaryEntry.Value, Employee)
                If objEmployee.Authenticate(u, p) Then
                    Clear()

                    Return True
                End If

            Next

            Clear()
            Return False

        Catch objE As Exception

            Throw New System.Exception("Authenticate Method Error: " & objE.Message)
        End Try
    End Function
#End Region

#Region "Public Data Access Methods:"
    Public Shared Function Create() As EmployeeList
        Return DataPortal_Create()
    End Function

    Public Sub Load(ByVal Key As String)
        DataPortal_Fetch(Key)
    End Sub

    Public Sub Save()
        If (IsDirty) Then
            DataPortal_Save()
        End If
    End Sub

    Public Sub ImmediateDelete(ByVal Key As String)
        DataPortal_Delete(Key)
    End Sub
#End Region

#Region "Helper Methods:"

    Public Function ToArray() As Employee()

        Dim arrEmployeeList(MyBase.Dictionary.Count - 1) As Employee

        MyBase.Dictionary.Values.CopyTo(arrEmployeeList, 0)
        Return arrEmployeeList
    End Function
#End Region

#Region " Deferred Delete"

    'Search and Find the first Dirty Child Object
    Public Overrides Function DeferredDelete(ByVal Key As String) As Boolean

        Dim objDEntry As DictionaryEntry
        Dim objItem As Employee

        Try

            'Search for Object to Mark Deferred Delete
            For Each objDEntry In MyBase.Dictionary
                objItem = CType(objDEntry.Value, Employee)
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
    Protected Shared Function DataPortal_Create() As EmployeeList
        Return Nothing
    End Function

    Protected Sub DataPortal_Fetch(ByVal Key As String)
        '-incase
        Try
            cmd = New OleDbCommand("SELECT * FROM Employee", conn) 'command to retrieve data
            If (conn.State = ConnectionState.Closed) Then conn.Open() 'Open connection to database if close
            Dim reader As OleDbDataReader = cmd.ExecuteReader  'Create data reader object
            While reader.Read = True
                Add(CStr(reader.Item("SSNumber")), CStr(reader.Item("FirstName")), CStr(reader.Item("LastName")), CDate(reader.Item("BirthDate")), _
                CStr(reader.Item("Address")), CStr(reader.Item("Phone")), CStr(reader.Item("JobTitle")), CStr(reader.Item("Username")), CStr(reader.Item("Password")))
            End While

            reader.Close() 'Close the connection

            ''Temporary implementation

            '    Dim strLine As String

            '    If Not File.Exists("EmployeeData.txt") Then

            '        File.Create("EmployeeData.txt").Close()
            '    End If

            '    Dim objDataFile As New StreamReader("EmployeeData.txt")

            '    Do While objDataFile.Peek <> -1

            '        strLine = objDataFile.ReadLine

            '        Dim tempArray() As String = Split(strLine, ",")

            '        Add(tempArray(0), tempArray(1), tempArray(2), CDate(tempArray(3)), _
            '        tempArray(4), tempArray(5), tempArray(6), tempArray(7), tempArray(8))
            '    Loop

            '    objDataFile.Close()

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
            '    Dim objChild As Employee

            '    'Step 2-Use For..Each loop to iterate through Collection
            '    For Each objDictionaryEntry In MyBase.Dictionary
            '        'Step 3-Convert DictionaryEntry pointer returned to Type Person
            '        objChild = CType(objDictionaryEntry.Value, Employee)

            '        'Step 4-Call Child to Save itself
            '        objChild.Save()

            '    Next


            Dim objWrite As New StreamWriter("EmployeeData.txt")

            Dim objDictionaryEntry As DictionaryEntry
            Dim objEmployee As Employee

            For Each objDictionaryEntry In MyBase.Dictionary

                objEmployee = CType(objDictionaryEntry.Value, Employee)

                objWrite.WriteLine(objEmployee.SSNumber & "," & _
                objEmployee.FirstName & "," & _
                objEmployee.LastName & "," & _
                objEmployee.Birthdate & "," & _
                objEmployee.Address & "," & _
                objEmployee.Phone & "," & _
                objEmployee.JobTitle & "," & _
                objEmployee.UserName & "," & _
                objEmployee.Password)
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
            Dim objItem As Employee

            'Step 2-Use For..Each loop to iterate through Collection
            For Each objDictionaryEntry In MyBase.Dictionary
                'Step 3-Convert DictionaryEntry pointer returned to Type Person
                objItem = CType(objDictionaryEntry.Value, Employee)

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
