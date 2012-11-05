Option Explicit On
Option Strict On
Imports ClassLibrary

Public Class loginForm


    Public Sub GetUserInfoAndDisplayForm(ByRef U As String, ByRef P As String)
        Me.ShowDialog()
        U = usernameTextBox.Text
        P = passwordTextBox.Text
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Me.Hide()
    End Sub

    Private Sub cancellButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancellButton.Click
        usernameTextBox.Text = ""
        passwordTextBox.Text = ""

        usernameTextBox.Focus()
    End Sub
End Class
