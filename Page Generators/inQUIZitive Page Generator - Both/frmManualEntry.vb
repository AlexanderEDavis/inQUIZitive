Public Class frmManualEntry
    Dim QuizArray(quizLength + 1)() As String
    Dim qi As Integer = 2
    Dim oi As Integer = 1
    Dim question
    Dim answerOptions As Array = {"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim availableOptions As Integer
    Dim msgRemainingQuestions
    Dim numRemainingQuestions
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmWelcome.Show()
        Me.Close()
    End Sub

    Private Sub frmManualEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msgRemainingQuestions = "Number of Questions Remaining: "
        numRemainingQuestions = quizLength
        lblQuizLength.Text = msgRemainingQuestions + numRemainingQuestions.ToString

    End Sub

    Private Sub btnResetQuestion_Click(sender As Object, e As EventArgs) Handles btnResetQuestion.Click
        tbxQuestionDetails.Text = ""
        question = ""
    End Sub

    Private Sub btnNextQuestion_Click(sender As Object, e As EventArgs) Handles btnNextQuestion.Click
        If btnNextQuestion.Text <> "Export Quiz" Then
            QuizArray(qi) = question.Split(",")
            qi += 1
            tbxQuestionDetails.Text = ""
            numRemainingQuestions -= 1
            lblQuizLength.Text = msgRemainingQuestions + numRemainingQuestions.ToString
            If numRemainingQuestions <= 1 Then
                btnNextQuestion.Text = "Export Quiz"
            End If
        Else
            modFunc.export()
        End If
    End Sub

    Private Sub btnQuestionSave_Click(sender As Object, e As EventArgs) Handles btnQuestionSave.Click
        lblQuestion.Text = tbxQuestion.Text
        tbxQuestionDetails.Text = tbxQuestion.Text + vbCrLf
        lblOptions.Visible = True
        tbxAvailableOptions.Visible = True
        btnAvailableOptions.Visible = True
        tbxQuestion.ReadOnly = True
        btnQuestionSave.Visible = False
        btnResetQuestion.Visible = True
        question = question + tbxQuestion.Text + ","
    End Sub

    Private Sub btnAvailableOptions_Click(sender As Object, e As EventArgs) Handles btnAvailableOptions.Click
        Try
            availableOptions = tbxAvailableOptions.Text
            lblAnswers.Text = lblAnswers.Text + answerOptions(oi)
            lblAnswers.Visible = True
            tbxAnswer.Visible = True
            btnOptionEntry.Visible = True
            btnAvailableOptions.Visible = False
            tbxAvailableOptions.ReadOnly = True
        Catch
            MessageBox.Show("Invalid Entry! Try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxAvailableOptions.Text = ""
        End Try
    End Sub

    Private Sub btnOptionEntry_Click(sender As Object, e As EventArgs) Handles btnOptionEntry.Click
        If oi <= availableOptions Then
            tbxQuestionDetails.Text = tbxQuestionDetails.Text + answerOptions(oi) + ":" + tbxAnswer.Text + vbCrLf
            oi += 1
            lblAnswers.Text = "Please Enter Option " + answerOptions(oi)
        ElseIf oi > availableOptions Then
            lblCorrectAnswer.Visible = True
            tbxCorrectAnswer.Visible = True
            btnCorrectAnswer.Visible = True
            btnOptionEntry.Visible = False
            lblAnswers.Visible = False
            tbxAnswer.Visible = False
        End If
    End Sub

    Private Sub btnCorrectAnswer_Click(sender As Object, e As EventArgs) Handles btnCorrectAnswer.Click
        MessageBox.Show("Please confirm the question information", "Confirm Question", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbxQuestionDetails.Text = tbxQuestionDetails.Text + "Correct Answer: " + tbxCorrectAnswer.Text
    End Sub
End Class