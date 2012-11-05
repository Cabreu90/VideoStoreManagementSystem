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
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Update()
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Insert()
        MyBase.MarkOld()
    End Sub

    Protected Sub DataPortal_Delete(ByVal Key As String)
        MyBase.MarkNew()
    End Sub

#End Region
End Class
