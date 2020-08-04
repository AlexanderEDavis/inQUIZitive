Public Class frmWelcome
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        frmCSVImport.Show()
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        frmManualEntry.Show()
        Me.Close()
    End Sub
End Class
