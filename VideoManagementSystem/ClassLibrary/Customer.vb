Option Explicit On
Option Strict On
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

'Keep commented (for future use) 
'System.Runtime.Serialization.Formatters.Binary 
'Imports System.Runtime.Remoting 
'Imports System.Runtime.Remoting.Channels 
'System.Runtime.Remoting.Channels.Http

''' <summary>
'''  Represents the customer.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>

<Serializable()> _
Public Class Customer
    Inherits Person

#Region "Database Connection"
    ' Creating a connection potinter
    Private Connection As OleDbConnection

    ' Connection string with database location
    Private Const connStr As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Management.accdb"

    ' Database command
    Private cmd As New OleDbCommand
#End Region

    'Private Data
    Private m_IDNumber As String

    'Public Property
    Public Property IDNumber As String
        Get
            Return m_IDNumber
        End Get
        Set(ByVal value As String)
            m_IDNumber = value
            MyBase.MarkDirty()
        End Set
    End Property

#Region "Constructors:"
    Public Sub New()

        MyBase.New()
        m_IDNumber = ""
        Count = Count + 1
    End Sub

    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As String, _
                  ByVal par5 As Date, ByVal par6 As String, ByVal par7 As String)

        MyBase.New(par2, par3, par4, par5, par6, par7)

        IDNumber = par1

        Count = Count + 1
    End Sub
#End Region

#Region "Public Overrides Methods:"
    Public Overrides Sub Print()
        Try
            Dim DataFile As New StreamWriter("Network_Printer.txt", True)



            DataFile.WriteLine("Printing Customer ............" & vbNewLine & _
                               "IDNumber= " & IDNumber & vbNewLine & _
                               "Name = " & FirstName & vbNewLine & _
                               "Last Name = " & LastName & vbNewLine & _
                               "Social Security Number = " & SSNumber & vbNewLine & _
                               "Birthday = " & MyBase.BirthDate.ToString("d") & vbNewLine & _
                               "Adress = " & Address & vbNewLine & _
                               "Age = " & Age & vbNewLine & _
                               "Phone Number = " & Phone & vbNewLine)
            DataFile.Close()

        Catch objE As DirectoryNotFoundException

            Throw New System.IO.DirectoryNotFoundException
        Catch objE As IOException

            Throw New System.IO.IOException

        Catch objE As System.Exception
            Throw New System.Exception
        End Try
    End Sub

    ''' <summary>
    ''' Stub method for future update.
    ''' </summary>
    ''' <param name="user"></param>
    ''' <param name="pass"></param>
    ''' <returns></returns>
    ''' <remarks>Customers do not need to authenticate.</remarks>
    Public Overrides Function Authenticate(ByVal user As String, ByVal pass As String) As Boolean
        'Company Policy: Customers do not need to authenticate. Stub method for future update.

        Return True
    End Function
#End Region

#Region "Public Overridable Methods:"
    Overridable Sub Product_Rental()
        'For future upgrade
    End Sub
    Overridable Sub Product_Return()
        'For future upgrade
    End Sub
#End Region

#Region "Public Data Access Methods:"
    ''' <summary>
    ''' Creates new employee object using factory method.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function Create() As Employee

        Return DataPortal_Create()
    End Function

    Sub Load(ByVal Key As String)
        DataPortal_Fetch(Key)
    End Sub

    Public Sub Save()
        ' If marked for deletion or not new, delete record.
        If Me.IsDeleted And Not Me.IsNew Then
            DataPortal_Delete(Me.IDNumber)
        Else

            If Me.IsDirty Then

                If Me.IsNew Then
                    'If new, insert new record in database
                    DataPortal_Insert()
                Else
                    'If old, update record in database
                    DataPortal_Update()
                End If
            End If
        End If

    End Sub

    Public Sub ImmediateDelete(ByVal Key As String)

        'Delete record
        DataPortal_Delete(Key)
    End Sub
#End Region

#Region "Protected Data Access Methods:"
    Protected Shared Function DataPortal_Create() As Employee
        Return Nothing
    End Function

    Protected Sub DataPortal_Fetch(ByVal Key As String)

        Try
            Connection = New OleDbConnection(connStr)

            ' Open connection 
            Connection.Open()

            ' Create SQL string 
            Dim strSQL As String = "SELECT * FROM Customer WHERE IDNumber = ?"

            ' Create Command object, pass query/connection & Add paramters 
            Dim objCmd As New OleDbCommand(strSQL, Connection)
            objCmd.Parameters.Add("@IDNumber", OleDbType.Numeric).Value = Key

            ' Create DATAREADER object & Execute Query 
            Dim objDR As OleDbDataReader = objCmd.ExecuteReader

            ' Check to make sure there is data in the DataReader Object 
            If objDR.HasRows Then

                ' Call Read() Method to point and read the first record 
                objDR.Read()

                ' Extract data from a row and populate object. 
                Me.IDNumber = CStr(objDR.Item(0))
                Me.FirstName = CStr(objDR.Item(1))
                Me.LastName = CStr(objDR.Item(2))
                Me.SSNumber = CStr(objDR.Item(3))
                Me.BirthDate = CDate(objDR.Item(4))
                Me.Address = CStr(objDR.Item(5))
                Me.Phone = CStr(objDR.Item(6))
            Else

                ' If no data is returned, throw error 
                Throw New System.ApplicationException("Load Error! Customer Not Found")
            End If

            ' Terminate ADO Objects 
            objDR.Close()
            objDR = Nothing
            objCmd.Dispose()

            ' Trap for General Exceptions 
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

        'At the end, set New flag to False. NOT Dirty since found in database
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Update()

        ' Start Error Trapping 
        Try
            Connection = New OleDbConnection(connStr)

            ' Open connection 
            Connection.Open()

            ' Create Query, Command Object & initialize 
            Dim strSQL As String = "UPDATE Customer SET FirstName = ?, LastName = ?," _
                                   & "SSNumber = ?, BirthDate = ?, Address = ?," _
                                   & "Phone = ? WHERE IDNumber= ?"

            ' Create Command object, pass string and connection object as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Parameter to Collection & Set Value 
            objCmd.Parameters.Add("@FirstName", OleDbType.VarChar).Value = Me.FirstName
            objCmd.Parameters.Add("@LastName", OleDbType.VarChar).Value = Me.LastName
            objCmd.Parameters.Add("@SSNumber", OleDbType.VarChar).Value = Me.SSNumber
            objCmd.Parameters.Add("@BirthDate", OleDbType.Date).Value = Me.BirthDate
            objCmd.Parameters.Add("@Address", OleDbType.VarChar).Value = Me.Address
            objCmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Me.Phone
            objCmd.Parameters.Add("@IDNumber", OleDbType.VarChar).Value = Me.IDNumber

            ' Execute Non-Row Quer
            Dim intRecordsAffected As Integer = objCmd.ExecuteNonQuery()

            ' Test result and throw exception if it fails 
            If intRecordsAffected <> 1 Then
                Throw New System.ApplicationException("UPDATE Query Failed")
            End If

            ' Terminate Command Object 
            objCmd.Dispose()
            objCmd = Nothing

            ' Trap for App General Exceptions 
        Catch objBOEx As NotSupportedException
            Throw New System.NotSupportedException(objBOEx.Message)
        Catch objA As ApplicationException
            Throw New System.ApplicationException(objA.Message)
        Catch objEx As Exception
            Throw New System.Exception("Update Error: " & objEx.Message)
        Finally
            ' Terminate connection 
            Connection.Close()
            Connection.Dispose()
            Connection = Nothing
        End Try

        ' Set New flag to False since exist in database/and is Not dirty any longer
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Insert()

        ' Start Error Trapping 
        Try
            Connection = New OleDbConnection(connStr)

            ' Open connection 
            Connection.Open()

            ' Create Command/Query 
            Dim strSQL As String = "INSERT INTO Customer VALUES (?, ?, ?, ?, ?, ?, ?)"

            ' Create Command object, pass connection info as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Paramter to Pareameters Collection 
            objCmd.Parameters.Add("@IDNumber", OleDbType.Numeric).Value = Me.IDNumber
            objCmd.Parameters.Add("@FirstName", OleDbType.VarChar).Value = Me.FirstName
            objCmd.Parameters.Add("@LastName", OleDbType.VarChar).Value = Me.LastName
            objCmd.Parameters.Add("@SSNumber", OleDbType.VarChar).Value = Me.SSNumber
            objCmd.Parameters.Add("@BirthDate", OleDbType.Date).Value = Me.BirthDate
            objCmd.Parameters.Add("@Address", OleDbType.VarChar).Value = Me.Address
            objCmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Me.Phone

            ' Execute Non-Row Query 
            Dim intRecordsAffected As Integer = objCmd.ExecuteNonQuery()

            ' Test result and throw exception if failed
            If intRecordsAffected <> 1 Then
                Throw New System.ApplicationException("INSERT Query Failed")
            End If

            ' Terminate Command Object 
            objCmd.Dispose()
            objCmd = Nothing

            ' Trap for App General Exceptions 
        Catch objBO As NotSupportedException
            Throw New System.NotSupportedException(objBO.Message)
        Catch objA As ApplicationException
            Throw New System.ApplicationException(objA.Message)
        Catch objEx As Exception
            Throw New System.Exception("Insert Error: " & objEx.Message)
        Finally
            ' Terminate connection 
            Connection.Close()
            Connection.Dispose()
            Connection = Nothing
        End Try

        ' Set New flag to False since exist in database/and is Not new any longer
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Delete(ByVal Key As String)
        'Start Error Trapping 
        Try
            Connection = New OleDbConnection(connStr)

            ' Open connection 
            Connection.Open()

            ' Create SQL command string
            Dim strSQL As String = "DELETE FROM Customer WHERE IDNumber = ?"

            ' Create Command object, pass string and connection object as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Parameter to Collection & Set Value 
            objCmd.Parameters.Add("@IDNumber", OleDbType.Numeric).Value = Key

            ' Execute Non-Row Query 
            Dim intRecordsAffected As Integer = objCmd.ExecuteNonQuery()

            ' Test result and throw exception if it fails
            If intRecordsAffected <> 1 Then
                Throw New System.ApplicationException("DELETE Query Failed")
            End If

            ' Terminate Command Object 
            objCmd.Dispose()
            objCmd = Nothing

            ' Trap for App General Exceptions 
        Catch objBO As NotSupportedException
            Throw New System.NotSupportedException("Delete Error: " & objBO.Message)
        Catch objA As ApplicationException
            Throw New System.ApplicationException("Delete Error: " & objA.Message)
        Catch objEx As Exception
            Throw New System.Exception("Delete Error: " & objEx.Message)
        Finally
            ' Terminate connection 
            Connection.Close()
            Connection.Dispose()
            Connection = Nothing
        End Try

        'Object no longer in database, therefore reset our status to be a new object
        MyBase.MarkNew()
    End Sub

#End Region
End Class
