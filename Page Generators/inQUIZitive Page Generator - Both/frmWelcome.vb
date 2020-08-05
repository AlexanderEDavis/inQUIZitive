Public Class frmWelcome
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        frmCSVImport.Show()
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Try
            quizLength = InputBox("Please enter the number of questions in your quiz", "Enter Number of Questions", "")
            quizTopic = InputBox("Please enter the topic your quiz", "Enter quiz topic", "")
            revisionLink = InputBox("Please enter the link students can click on to revise this topic", "Enter revision link", "")
            progressionLink = InputBox("Please enter the link students can click on to revise the next topic", "Enter next revision link", "")
            frmManualEntry.Show()
            Me.Close()
        Catch
            MessageBox.Show("Invalid Quiz Length", "That is not a valid quiz length. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
