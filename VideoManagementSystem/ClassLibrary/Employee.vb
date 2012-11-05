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

' Event and BirthDate see page 20 authenticate page 22 pg 24


''' <summary>
''' Represent epmloyees of the company.
''' </summary>
''' <remarks>Serialization enabled for this class.</remarks>
<Serializable()> _
Public Class Employee
    Inherits Person

#Region "Private Data:"
    Private m_JobTitle As String
    Private m_UserName As String
    Private m_Password As String

    Public Event SecurityAlert(ByVal username As String, ByVal password As String)
#End Region

#Region "Public Properties:"
    Public Property JobTitle As String
        Get
            Return m_JobTitle
        End Get
        Set(ByVal value As String)
            m_JobTitle = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property UserName As String
        Get
            Return m_UserName
        End Get
        Set(ByVal value As String)
            m_UserName = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Property Password As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
            MyBase.MarkDirty()
        End Set
    End Property

    Public Overrides Property Birthdate As Date
        Get
            Return MyBase.BirthDate
        End Get
        Set(ByVal value As Date)
            If DateDiff(DateInterval.Year, value, Now()) >= 16 Then
                MyBase.BirthDate = value
            Else
                'unhandled system.exception
                Throw New System.Exception("Under Age Employee, an Employee must be 16 Years old")
            End If
        End Set
    End Property
#End Region

#Region "Constructors:"
    Public Sub New()

        MyBase.New()


        m_JobTitle = ""
        m_UserName = ""
        m_Password = ""
        Count = Count + 1
    End Sub

    Public Sub New(ByVal par1 As String, ByVal par2 As String, ByVal par3 As String, ByVal par4 As Date, _
                  ByVal par5 As String, ByVal par6 As String, ByVal par7 As String, ByVal par8 As String, ByVal par9 As String)

        MyBase.New(par1, par2, par3, par4, par5, par6)

        JobTitle = par7
        m_UserName = par8
        m_Password = par9
        Count = Count + 1
    End Sub
#End Region

#Region "Public Overrides Methods:"
    Overrides Sub Print()
        Try
            Dim DataFile As New StreamWriter("Network_Printer.txt", True)



            DataFile.WriteLine("Printing Employee ............" & vbNewLine & "Name = " & FirstName & vbNewLine & _
                               "Last Name = " & LastName & vbNewLine & "Social Security Number = " & SSNumber & _
                               vbNewLine & "Birthday = " & MyBase.BirthDate.ToString("d") & vbNewLine & "Adress = " _
                               & Address & vbNewLine & "Age = " & Age & vbNewLine & "Phone Number = " & Phone & _
                               vbNewLine & "Job Title = " & JobTitle & vbNewLine & "User Name = " & UserName & _
                               vbNewLine & "Password = " & Password & vbNewLine)

            DataFile.Close()

        Catch objE As DirectoryNotFoundException

            Throw New System.IO.DirectoryNotFoundException
        Catch objE As IOException

            Throw New System.IO.IOException

        Catch objE As System.Exception
            Throw New System.Exception
        End Try
    End Sub
    Overrides Function Authenticate(ByVal user As String, ByVal pass As String) As Boolean
        RaiseEvent SecurityAlert(user, pass)
        If (m_UserName = user And m_Password = pass) Then
            Return True
        End If
        Return False
    End Function
#End Region

#Region "Public Overridable Methods:"
    Overridable Sub Product_Rental()
        'disable via exceptions
        Throw New System.Exception("Prouct Rental as Employee is a violation of current company polocy")
    End Sub
    Overridable Sub Product_Return()
        'Disable via exceptions
        Throw New System.Exception("Prouct Return as Employee is a violation of current company polocy")
    End Sub
#End Region

#Region "Public Data Access Methods:"
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
