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
            DataPortal_Delete(Me.SSNumber)

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
