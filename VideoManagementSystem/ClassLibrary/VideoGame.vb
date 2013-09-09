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
''' Enumerated Data type that represents the video game category
''' </summary>
''' <remarks></remarks>
Public Enum VideoGameCategory
    Action
    Roleplaying
    Shooting
    Fighting
    Racing
    Sports
    Strategy
    Horror
    FlightSimulators
    Online
    Rhythm
    None
End Enum

''' <summary>
''' Enumerated Data type that represents the video game format or type of Game Consoles the game is intended for.
''' </summary>
''' <remarks></remarks>
Public Enum VideoGameFormat
    XBox
    XBox360
    PS3
    PS2
    GameCube
    DS
    Wii
    PC
    None
End Enum

''' <summary>
''' Represents a Video Game.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>
<Serializable()> _
Public Class VideoGame
    Inherits Product

    'Private Data:
    Dim m_enumVideoGameCategory As VideoGameCategory    'Enumerated Data type that represents the video game category.
    Dim m_enumVideoGameFormat As VideoGameFormat        'Enumerated Data type that represents the video game format or type of Game Console

#Region "Database Connection"
    ' Creating a connection potinter
    Private Connection As OleDbConnection

    ' Connection string with database location
    Private Const connStr As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Management.accdb"

    ' Database command
    Private cmd As New OleDbCommand
#End Region

#Region "Public Properties"
    Public Property Category As VideoGameCategory
        Get
            Return m_enumVideoGameCategory
        End Get
        Set(ByVal value As VideoGameCategory)
            m_enumVideoGameCategory = value
            MyBase.MarkDirty()
        End Set
    End Property


    Public Property Format As VideoGameFormat
        Get
            Return m_enumVideoGameFormat
        End Get
        Set(ByVal value As VideoGameFormat)
            m_enumVideoGameFormat = value
            MyBase.MarkDirty()
        End Set
    End Property
#End Region

#Region "Constructors:"
    Public Sub New()
        MyBase.New()
        m_enumVideoGameCategory = VideoGameCategory.None
        m_enumVideoGameFormat = VideoGameFormat.None
    End Sub

    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Rating, _
                  ByVal par5 As Decimal, ByVal par6 As Decimal, ByVal par7 As Decimal, ByVal par8 As VideoGameCategory, ByVal par9 As VideoGameFormat)

        MyBase.New(par1, par2, par3, par4, par5, par6, par7)
        m_enumVideoGameCategory = par8
        m_enumVideoGameFormat = par9
    End Sub
#End Region

#Region "Public Overrides Methods:"
    Public Overrides Sub Print()
        Try
            Dim DataFile As New StreamWriter("Network_Printer.txt", True)

            DataFile.WriteLine("Printing VideoGame ............" & vbNewLine & "ID Number = " & IDNumber & vbNewLine & _
                               "Title = " & Title & vbNewLine & "Description = " & Description & _
                               vbNewLine & "Rating = " & Rating.ToString & vbNewLine & "SalePrice = " _
                               & SalePrice.ToString & vbNewLine & "RentalRate = " & RentalRate.ToString & _
                               vbNewLine & "LateFee = " & LateFee.ToString & vbNewLine & "VideoGame Category = " _
                               & m_enumVideoGameCategory.ToString & vbNewLine & "VideoGame Format = " & _
                               m_enumVideoGameFormat.ToString & vbNewLine)

            DataFile.Close()

        Catch objE As DirectoryNotFoundException

            Throw New System.IO.DirectoryNotFoundException
        Catch objE As IOException

            Throw New System.IO.IOException

        Catch objE As System.Exception
            Throw New System.Exception
        End Try
    End Sub


    Public Overrides Sub Product_Rental()

    End Sub

    Public Overrides Sub Product_Return()

    End Sub

    Public Overrides Sub Product_Sell()

    End Sub
#End Region

#Region "Public Data Access Methods:"
    Shared Function Create() As VideoGame

        Return DataPortal_Create()
    End Function

    Sub Load(ByVal Key As String)
        DataPortal_Fetch(Key)
    End Sub

    Public Sub Save()
        'Delete record If it's marked for deletion and it's not new.
        If Me.IsDeleted And Not Me.IsNew Then
            'Calls Local DataPortal_Delete(Key) to execute query
            DataPortal_Delete(Me.IDNumber)

        Else
            'Update or Insert the data if it's marked as dirty, otherwise do nothing
            If Me.IsDirty Then
                If Me.IsNew Then
                    'When new, insert new record in database
                    'Calls Local DataPortal_Insert() to execute query
                    DataPortal_Insert()
                Else
                    'When not new, update record in database
                    'Calls Local DataPortal_Update() to execute query
                    DataPortal_Update()
                End If
            End If
        End If

    End Sub

    Sub ImmediateDelete(ByVal Key As String)
        DataPortal_Delete(Key)
    End Sub
#End Region

#Region "Protected Data Access Methods:"
    Protected Shared Function DataPortal_Create() As VideoGame
        Return Nothing
    End Function

    Protected Sub DataPortal_Fetch(ByVal Key As String)

        Try
            Connection = New OleDbConnection(connStr)

            ' Open connection 
            Connection.Open()

            ' Create SQL string 
            Dim strSQL As String = "SELECT * FROM VideoGame WHERE IDNumber = ?"

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
                Me.Title = CStr(objDR.Item(1))
                Me.Description = CStr(objDR.Item(2))
                Me.Rating = CType(System.Enum.Parse(GetType(Rating), CStr(objDR.Item(3))), Rating)
                Me.Available = CBool(objDR.Item(4))
                Me.SalePrice = CDec(objDR.Item(5))
                Me.RentalRate = CDec(objDR.Item(6))
                Me.LateFee = CDec(objDR.Item(7))
                Me.Category = CType(System.Enum.Parse(GetType(VideoGameCategory), CStr(objDR.Item(8))), VideoGameCategory)
                Me.Format = CType(System.Enum.Parse(GetType(VideoGameFormat), CStr(objDR.Item(9))), VideoGameFormat)
            Else

                ' If no data is returned, throw error 
                Throw New System.ApplicationException("Load Error! VideoGame Not Found")
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
            Dim strSQL As String = "UPDATE VideoGame SET Title = ?, Description = ?, Rating = ?," _
                                   & "Available = ?, SalePrice = ?, RentalRate = ?, LateFee = ?," _
                                   & "VideoGameCategory = ?, VideoGameFormat = ? WHERE IDNumber= ?"

            ' Create Command object, pass string and connection object as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Parameter to Collection & Set Value 
            objCmd.Parameters.Add("@Title", OleDbType.VarChar).Value = Me.Title
            objCmd.Parameters.Add("@Description", OleDbType.VarChar).Value = Me.Description
            objCmd.Parameters.Add("@Rating", OleDbType.VarChar).Value = Me.Rating
            objCmd.Parameters.Add("@Available", OleDbType.Boolean).Value = Me.Available
            objCmd.Parameters.Add("@SalePrice", OleDbType.Decimal).Value = Me.SalePrice
            objCmd.Parameters.Add("@RentalRate", OleDbType.Decimal).Value = Me.RentalRate
            objCmd.Parameters.Add("@LateFee", OleDbType.Decimal).Value = Me.LateFee
            objCmd.Parameters.Add("@VideoGameCategory", OleDbType.VarChar).Value = Me.Category
            objCmd.Parameters.Add("@VideoGameFormat", OleDbType.VarChar).Value = Me.Format
            objCmd.Parameters.Add("@IDNumber", OleDbType.Char).Value = Me.IDNumber

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
            Dim strSQL As String = "INSERT INTO VideoGame VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

            ' Create Command object, pass connection info as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Paramter to Pareameters Collection 
            objCmd.Parameters.Add("@IDNumber", OleDbType.Char).Value = Me.IDNumber
            objCmd.Parameters.Add("@Title", OleDbType.VarChar).Value = Me.Title
            objCmd.Parameters.Add("@Description", OleDbType.VarChar).Value = Me.Description
            objCmd.Parameters.Add("@Rating", OleDbType.VarChar).Value = Me.Rating
            objCmd.Parameters.Add("@Available", OleDbType.Boolean).Value = Me.Available
            objCmd.Parameters.Add("@SalePrice", OleDbType.Decimal).Value = Me.SalePrice
            objCmd.Parameters.Add("@RentalRate", OleDbType.Decimal).Value = Me.RentalRate
            objCmd.Parameters.Add("@LateFee", OleDbType.Decimal).Value = Me.LateFee
            objCmd.Parameters.Add("@VideoGameCategory", OleDbType.VarChar).Value = Me.Category
            objCmd.Parameters.Add("@VideoGameFormat", OleDbType.VarChar).Value = Me.Format

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
            Dim strSQL As String = "DELETE FROM VideoGame WHERE IDNumber = ?"

            ' Create Command object, pass string and connection object as arguments 
            Dim objCmd As New OleDbCommand(strSQL, Connection)

            ' Add Parameter to Collection & Set Value 
            objCmd.Parameters.Add("@IDNumber", OleDbType.Char).Value = Key

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
