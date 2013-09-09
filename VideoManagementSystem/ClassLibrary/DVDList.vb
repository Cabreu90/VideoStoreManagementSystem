Option Explicit On
Option Strict On

Imports System.IO
Imports System.Data                                     'Data Access (DataSet)
Imports System.Data.OleDb                               'OLEDB Provider
Imports System.Configuration                            'Configuration File for DB Connection

''' <summary>
''' Store and manage DVD Objects in memory and load/save them from TEXT FILE. 
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>
<Serializable()> _
Public Class DVDList
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

    Public Property Item(ByVal key As String) As DVD
        Get

            Return CType(MyBase.Dictionary.Item(key), DVD)
        End Get

        Set(ByVal value As DVD)


            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = value
            Else

                Throw New System.ArgumentException("ID Not found")
            End If
        End Set
    End Property
#End Region

#Region "Public Methods:"
    Public Sub Add(ByVal key As String, ByVal objDVD As DVD)

        Try

            MyBase.Dictionary.Add(key, objDVD)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try
    End Sub

    Public Sub Add(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Rating, _
                  ByVal par5 As Decimal, ByVal par6 As Decimal, ByVal par7 As Decimal, _
                  ByVal par8 As MovieCategory, ByVal par9 As DVDFormat)

        Try

            Dim objDVD As New DVD

            With objDVD
                .IDNumber = par1
                .Title = par2
                .Description = par3
                .Rating = par4
                .SalePrice = par5
                .RentalRate = par6
                .LateFee = par7
                .Category = par8
                .Format = par9
                .Available = True

            End With

            MyBase.Dictionary.Add(objDVD.IDNumber, objDVD)

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objY As ArgumentException

            Throw New System.ArgumentException("Duplicate Key Error: " & objY.Message)

        Catch objE As Exception

            Throw New System.Exception("Add Method Error: " & objE.Message)
        End Try

    End Sub

    Public Function Edit(ByVal key As String, ByVal objDVD As DVD) As Boolean

        Try

            If MyBase.Dictionary.Contains(key) Then

                MyBase.Dictionary.Item(key) = objDVD

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

    Public Function Edit(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Rating, _
                          ByVal par5 As Decimal, ByVal par6 As Decimal, ByVal par7 As Decimal, _
                          ByVal par8 As MovieCategory, ByVal par9 As DVDFormat) As Boolean

        Try

            Dim objDVD As DVD

            objDVD = CType(MyBase.Dictionary.Item(par1), DVD)

            If objDVD Is Nothing Then

                Return False
            Else

                With objDVD
                    .IDNumber = par1
                    .Title = par2
                    .Description = par3
                    .Rating = par4
                    .SalePrice = par5
                    .RentalRate = par6
                    .LateFee = par7
                    .Category = par8
                    .Format = par9
                    .Available = True
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

            Dim objDVD As DVD

            objDVD = CType(MyBase.Dictionary.Item(key), DVD)

            If objDVD Is Nothing Then

                Return False
            Else

                objDVD.Print()

                Return True
            End If

        Catch objX As ArgumentNullException

            Throw New System.ArgumentNullException("Invalid Key Error: " & objX.Message)

        Catch objE As Exception

            Throw New System.Exception("PrintDVD Error: " & objE.Message)
        End Try
    End Function

    Public Sub PrintAll()

        Try

            Dim objDictionaryEntry As DictionaryEntry
            Dim objDVD As DVD

            For Each objDictionaryEntry In MyBase.Dictionary

                objDVD = CType(objDictionaryEntry.Value, DVD)

                objDVD.Print()
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

    Public Function ToArray() As DVD()

        Dim arrDVDList(MyBase.Dictionary.Count - 1) As DVD


        MyBase.Dictionary.Values.CopyTo(arrDVDList, 0)
        Return arrDVDList
    End Function
#End Region

#Region "Public Data Access Methods:"
    Public Shared Function Create() As DVDList
        Return DataPortal_Create()
    End Function

    Public Sub Load(ByVal Key As String)

        DataPortal_Fetch(Key)
    End Sub

    Public Sub Save()
        'Call DataPortal_Save() method if the object is dirty.
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
        Dim objItem As DVD

        Try

            'Search for Object to Mark Deferred Delete
            For Each objDEntry In MyBase.Dictionary
                objItem = CType(objDEntry.Value, DVD)
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
    Protected Shared Function DataPortal_Create() As DVDList
        Return Nothing
    End Function

    Protected Sub DataPortal_Fetch(ByVal Key As String)

        ' Start trapping errors 
        Try
            Connection = New OleDbConnection(connStr)

            ' Open database connection 
            Connection.Open()

            ' Create SQL string to get all Primary Keys of DVDs 
            Dim strSQL As String = "SELECT IDNumber FROM DVDData"

            ' Create Command object 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Create DATAREADER object & Execute Query 
            Dim objDR As OleDbDataReader = objCmd.ExecuteReader

            ' Test to make sure there is data in the DataReader Object 
            If objDR.HasRows Then

                ' Iterate through DataReader one record at a time. 
                Do While objDR.Read

                    ' Create DVDData Object 
                    Dim objItem As New DVD

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

        ' Begin Error trapping
        Try
            ' Create Temporary Person and Dictionary object POINTERS
            Dim objDictionaryEntry As DictionaryEntry
            Dim objChild As DVD

            ' Use For..Each loop to iterate through Collection
            For Each objDictionaryEntry In MyBase.Dictionary

                ' Convert DictionaryEntry pointer returned to Type Person
                objChild = CType(objDictionaryEntry.Value, DVD)

                ' Call Child to Save itself
                objChild.Save()

            Next

            ' Traps for general exceptions.  
        Catch objE As Exception
            ' Throw an general exceptions
            Throw New System.Exception("Dataportal Save Error! " & objE.Message)
        End Try
    End Sub


    Protected Sub DataPortal_Update()

    End Sub

    Protected Sub DataPortal_Insert()

    End Sub

    Protected Sub DataPortal_Delete(ByVal Key As String)
        ' Iterates through Collection, Calling Each CHILD object.Delete() method
        ' CHILD Objects Delete themselves

        ' Begin Error trapping
        Try
            ' Create Temporary Person and Dictionary object POINTERS
            Dim objDictionaryEntry As DictionaryEntry
            Dim objItem As DVD

            ' Use For..Each loop to iterate through Collection
            For Each objDictionaryEntry In MyBase.Dictionary

                ' Convert DictionaryEntry pointer returned to Type Person
                objItem = CType(objDictionaryEntry.Value, DVD)

                ' Find target object based on key
                If objItem.IDNumber = Key Then

                    ' Object deletes itself
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
