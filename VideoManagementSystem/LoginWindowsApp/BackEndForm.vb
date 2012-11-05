Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class BackEndForm

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub employeeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles employeeButton.Click
        Me.Hide()
        employeeForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub dvdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dvdButton.Click
        Me.Hide()
        dvdForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub customerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerButton.Click
        Me.Hide()
        customerForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub videoGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles videoGameButton.Click
        Me.Hide()
        VideoGameForm.ShowDialog()
        Me.Show()
    End Sub
End Class