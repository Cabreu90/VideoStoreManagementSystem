Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub backEndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backEndButton.Click
        Me.Hide()
        BackEndForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub videoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles videoButton.Click
        Me.Hide()
        VideoPOSForm.ShowDialog()
        Me.Show()
    End Sub
End Class