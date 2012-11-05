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
''' Represents a person. Designed to be inherited. It can't be instantiated.
''' </summary>
''' <remarks>
''' Serialization enabled for this class.
''' </remarks>
<Serializable()> _
Public MustInherit Class Person
    Inherits BusinessBase

#Region "Private data:"
    Private m_SSNumber As String
    Private m_FirstName As String
    Private m_LastName As String
    Private m_Address As String
    Private m_PhoneNumber As String
    Private m_BirthDate As Date
    Private m_Age As Integer
    Private Shared m_Count As Integer = 0

#End Region

#Region "Public Properties:"
    ''' <summary>
    ''' Sets and gets a Social Security Number.
    ''' </summary>
    ''' <value>SSNumber</value>
    ''' <returns>SSNumber</returns>
    ''' <remarks></remarks>
    Public Property SSNumber As String
        Get
            Return m_SSNumber
        End Get
        Set(ByVal value As String)
            m_SSNumber = value
            MyBase.MarkDirty()
        End Set
    End Property

    ''' <summary>
    ''' Sets and gets the person's first name.
    ''' </summary>
    ''' <value>First Name</value>
    ''' <returns>First Name</returns>
    ''' <remarks></remarks>
    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(ByVal Value As String)
            m_FirstName = Value
            MyBase.MarkDirty()
        End Set
    End Property
    ''' <summary>
    ''' Sets and gets the Last Name.
    ''' </summary>
    ''' <value>Last Name</value>
    ''' <returns>Last Name</returns>
    ''' <remarks></remarks>
    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal Value As String)
            m_LastName = Value
            MyBase.MarkDirty()
        End Set
    End Property

    ''' <summary>
    ''' Sets and gets the person's full address.
    ''' </summary>
    ''' <value>Full Address</value>
    ''' <returns>Full Address</returns>
    ''' <remarks></remarks>
    Public Property Address() As String
        Get
            Return m_Address
        End Get
        Set(ByVal Value As String)
            m_Address = Value
            MyBase.MarkDirty()
        End Set
    End Property
    ''' <summary>
    ''' Sets and gets the person phone number.
    ''' </summary>
    ''' <value>Phone Number</value>
    ''' <returns>Phone Number</returns>
    ''' <remarks></remarks>
    Public Property Phone As String
        Get
            Return m_PhoneNumber
        End Get
        Set(ByVal Value As String)
            m_PhoneNumber = Value
            MyBase.MarkDirty()
        End Set
    End Property

    ''' <summary>
    ''' Sets and gets Birthdate private data.
    ''' </summary>
    ''' <value>The person's birthdate</value>
    ''' <returns> The person's Birthdate</returns>
    ''' <remarks>Declared overridable so that derived class can override it.</remarks>
    Public Overridable Property BirthDate As Date

        Get
            Return m_BirthDate
        End Get
        Set(ByVal value As Date)
            m_BirthDate = value
            m_Age = CInt(Today.Year - value.Year)
            MyBase.MarkDirty()
        End Set
    End Property
    ''' <summary>
    ''' Gets the Age only.
    ''' </summary>
    ''' <value> N/A</value>
    ''' <returns>Age</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Age As Integer
        Get
            Return m_Age
        End Get
    End Property

    ''' <summary>
    ''' Object counter.
    ''' </summary>
    ''' <value>Number of onjects</value>
    ''' <returns>Number of objects</returns>
    ''' <remarks></remarks>
    Public Shared Property Count As Integer
        Get
            Return m_Count
        End Get
        Set(ByVal value As Integer)
            m_Count = value
        End Set
    End Property
#End Region

#Region "Constructors:"
    Public Sub New()
        m_SSNumber = ""
        m_FirstName = ""
        m_LastName = ""

        m_Address = ""
        m_BirthDate = #1/1/1900#
        m_PhoneNumber = ""
        m_Age = 0

    End Sub
    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Date, _
               ByVal par5 As String, ByVal par6 As String)

        SSNumber = par1
        FirstName = par2
        LastName = par3
        BirthDate = par4
        Address = par5
        Phone = par6
    End Sub
#End Region

#Region "Public Shared Methods:"
    ' Shared methods that can be accessed wothout instantiating an object

    ''' <summary>
    ''' Start counting from zero again.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub ResetCount()
        Count = 0
    End Sub

    ''' <summary>
    ''' The new value to it's added to the counter.
    ''' </summary>
    ''' <param name="c">New value to be added.</param>
    ''' <remarks></remarks>
    Public Shared Sub IncrementCount(ByVal c As Integer)
        Count = Count + c
    End Sub

#End Region

#Region "Public MustOverride Methods:"
    ' Methods that have to be defined/implemented in the derived class. 
    ''' <summary>
    ''' Print info.
    ''' </summary>
    ''' <remarks></remarks>
    Public MustOverride Sub Print()

    ''' <summary>
    ''' Authenticates user.
    ''' </summary>
    ''' <param name="user">Username</param>
    ''' <param name="pass">Password</param>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Public MustOverride Function Authenticate(ByVal user As String, ByVal pass As String) As Boolean

#End Region

End Class
