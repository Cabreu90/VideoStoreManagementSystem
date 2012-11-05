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
''' This is an enumerated Data type declaration that represents product’s rating.
''' </summary>
''' <remarks></remarks>
Public Enum Rating
    G
    PG
    PG13
    NC17
    R
    NONE
End Enum

''' <summary>
''' Represents a Product. Designed to be inherited. It can't be instantiated.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>
<Serializable()> _
Public MustInherit Class Product
    Inherits BusinessBase

#Region "Private Data:"
    Private m_IDNumber As String        'Represents product’s ID number.
    Private m_Title As String           'Represents product’s name.
    Private m_Description As String     'Represents product’s description.
    Private m_enumRating As Rating      'This is variable of the Enum Rating Data which will store only Rating variables.
    Private m_Available As Boolean      'Represents product’s availability, in stock (true or false).
    Private m_SalePrice As Decimal      'Represents product’s sales price.
    Private m_RentalRate As Decimal     'Represents product’s daily rental rate.
    Private m_LateFee As Decimal        'Represents product’s daily late fees for rentals.
#End Region

#Region "Public Properties:"
    Public Property IDNumber As String
        Get
            Return m_IDNumber
        End Get

        Set(ByVal value As String)
            m_IDNumber = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property Title As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property Description As String
        Get
            Return m_Description
        End Get
        Set(ByVal value As String)
            m_Description = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property Rating As Rating
        Get
            Return m_enumRating
        End Get
        Set(ByVal value As Rating)
            m_enumRating = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property Available As Boolean
        Get
            Return m_Available
        End Get
        Set(ByVal value As Boolean)
            m_Available = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property SalePrice As Decimal
        Get
            Return m_SalePrice
        End Get
        Set(ByVal value As Decimal)
            m_SalePrice = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property RentalRate As Decimal
        Get
            Return m_RentalRate
        End Get
        Set(ByVal value As Decimal)
            m_RentalRate = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property LateFee As Decimal
        Get
            Return m_LateFee
        End Get
        Set(ByVal value As Decimal)
            m_LateFee = value
            MyBase.MarkDirty()
        End Set
    End Property
#End Region

#Region "Constructors:"
    Public Sub New()
        m_IDNumber = ""
        m_Title = ""
        m_Description = ""
        m_enumRating = Rating.NONE
        m_Available = True
        m_SalePrice = CDec(0.0)
        m_RentalRate = CDec(0.0)
        m_LateFee = CDec(0.0)
    End Sub

    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Rating, _
                  ByVal par5 As Decimal, ByVal par6 As Decimal, ByVal par7 As Decimal)
        IDNumber = par1
        Title = par2
        Description = par3
        Rating = par4
        SalePrice = par5
        RentalRate = par6
        LateFee = par7
        m_Available = True
    End Sub
#End Region

#Region "Public Data Access Methods:"
    Public MustOverride Sub Print()             'Intended for derived classes to print their data.
    Public MustOverride Sub Product_Rental()    'Intended for derived classes to be able to perform Product Rentals.
    Public MustOverride Sub Product_Return()    'Intended for derived classes to be able to perform Product Returns as part of rental process.
    Public MustOverride Sub Product_Sell()      'Intended for derived classes to be able to SELL the Products of the business.
#End Region
End Class
