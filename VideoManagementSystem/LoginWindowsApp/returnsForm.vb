Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class returnsForm
    ''' <summary>
    ''' Closing returnsform.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class