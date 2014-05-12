Public Class VideoPOSForm

  
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub infoButton_Click(sender As System.Object, e As System.EventArgs) Handles infoButton.Click
        Me.Hide()
        customerInfoForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub regButton_Click(sender As System.Object, e As System.EventArgs) Handles regButton.Click
        Me.Hide()
        customerRegistrationForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub rentButton_Click(sender As System.Object, e As System.EventArgs) Handles rentButton.Click
        Me.Hide()
        RentForm.ShowDialog()
        Me.Show()
    End Sub
End Class