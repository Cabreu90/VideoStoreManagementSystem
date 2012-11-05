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

'why mark old if not new works well


''' <summary>
''' Enumerated Data type that represents the movie category.
''' </summary>
''' <remarks></remarks>
Public Enum MovieCategory
    Action_Adventure
    Drama
    Family_Kids
    Horror
    SciFi_Fantasy
    Music
    Sports
    Romance
    Comedy
    Western
    None
End Enum

''' <summary>
''' Enumerated Data type that represents the DVD movie format.
''' </summary>
''' <remarks></remarks>
Public Enum DVDFormat
    DVD
    HDDVD
    BLUERAY_Disc
    None
End Enum

''' <summary>
''' Represents a DVD.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>
<Serializable()> _
Public Class DVD
    Inherits Product

    'Private Data:
    Dim m_enumMovieCategory As MovieCategory    'Enumerated Data type that represents the movie category.
    Dim m_enumDVDFormat As DVDFormat            'Enumerated Data type that represents the DVD movie format.

#Region "Public Properties"
    Public Property Category As MovieCategory
        Get
            Return m_enumMovieCategory
        End Get
        Set(ByVal value As MovieCategory)
            m_enumMovieCategory = value
            MyBase.MarkDirty()
        End Set
    End Property


    Public Property Format As DVDFormat
        Get
            Return m_enumDVDFormat
        End Get
        Set(ByVal value As DVDFormat)
            m_enumDVDFormat = value
            MyBase.MarkDirty()
        End Set
    End Property
#End Region

#Region "Constructors:"
    Public Sub New()
        MyBase.New()
        m_enumMovieCategory = MovieCategory.None
        m_enumDVDFormat = DVDFormat.None
    End Sub

    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Rating, _
                  ByVal par5 As Decimal, ByVal par6 As Decimal, ByVal par7 As Decimal, ByVal par8 As MovieCategory, ByVal par9 As DVDFormat)

        MyBase.New(par1, par2, par3, par4, par5, par6, par7)
        m_enumMovieCategory = par8
        m_enumDVDFormat = par9
    End Sub
#End Region

#Region "Public Overrides Methods:"
    Public Overrides Sub Print()
        Try
            Dim DataFile As New StreamWriter("Network_Printer.txt", True)



            DataFile.WriteLine("Printing DVD ............" & vbNewLine & "ID Number = " & IDNumber & vbNewLine & _
                               "Title = " & Title & vbNewLine & "Description = " & Description & _
                               vbNewLine & "Rating = " & Rating.ToString & vbNewLine & "SalePrice = " _
                               & SalePrice.ToString & vbNewLine & "RentalRate = " & RentalRate.ToString & _
                               vbNewLine & "LateFee = " & LateFee.ToString & vbNewLine & "Movie Category = " _
                               & m_enumMovieCategory.ToString & vbNewLine & "m_enumDVDFormat = " & _
                               m_enumDVDFormat.ToString & vbNewLine)

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
    Shared Function Create() As DVD

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
    Protected Shared Function DataPortal_Create() As DVD
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
