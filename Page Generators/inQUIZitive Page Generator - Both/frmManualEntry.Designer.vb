<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualEntry))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuizLength = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.tbxQuestion = New System.Windows.Forms.TextBox()
        Me.tbxQuestionDetails = New System.Windows.Forms.TextBox()
        Me.btnQuestionSave = New System.Windows.Forms.Button()
        Me.btnAvailableOptions = New System.Windows.Forms.Button()
        Me.tbxAvailableOptions = New System.Windows.Forms.TextBox()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.tbxAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswers = New System.Windows.Forms.Label()
        Me.btnOptionEntry = New System.Windows.Forms.Button()
        Me.tbxCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.btnCorrectAnswer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnResetQuestion = New System.Windows.Forms.Button()
        Me.btnNextQuestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnHome.Location = New System.Drawing.Point(13, 13)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(104, 50)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(12, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "inQUIZitive Manual Quiz Entry"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuizLength
        '
        Me.lblQuizLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuizLength.Location = New System.Drawing.Point(389, 40)
        Me.lblQuizLength.Name = "lblQuizLength"
        Me.lblQuizLength.Size = New System.Drawing.Size(399, 23)
        Me.lblQuizLength.TabIndex = 2
        Me.lblQuizLength.Text = "Number of Questions Remaining: "
        Me.lblQuizLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuestion.Location = New System.Drawing.Point(7, 66)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(528, 23)
        Me.lblQuestion.TabIndex = 3
        Me.lblQuestion.Text = "Please Enter Your Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxQuestion
        '
        Me.tbxQuestion.Location = New System.Drawing.Point(7, 92)
        Me.tbxQuestion.Name = "tbxQuestion"
        Me.tbxQuestion.Size = New System.Drawing.Size(528, 20)
        Me.tbxQuestion.TabIndex = 4
        '
        'tbxQuestionDetails
        '
        Me.tbxQuestionDetails.Location = New System.Drawing.Point(559, 92)
        Me.tbxQuestionDetails.Multiline = True
        Me.tbxQuestionDetails.Name = "tbxQuestionDetails"
        Me.tbxQuestionDetails.ReadOnly = True
        Me.tbxQuestionDetails.Size = New System.Drawing.Size(228, 346)
        Me.tbxQuestionDetails.TabIndex = 5
        '
        'btnQuestionSave
        '
        Me.btnQuestionSave.Location = New System.Drawing.Point(460, 119)
        Me.btnQuestionSave.Name = "btnQuestionSave"
        Me.btnQuestionSave.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestionSave.TabIndex = 6
        Me.btnQuestionSave.Text = "Save"
        Me.btnQuestionSave.UseVisualStyleBackColor = True
        '
        'btnAvailableOptions
        '
        Me.btnAvailableOptions.Location = New System.Drawing.Point(460, 197)
        Me.btnAvailableOptions.Name = "btnAvailableOptions"
        Me.btnAvailableOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnAvailableOptions.TabIndex = 7
        Me.btnAvailableOptions.Text = "Save"
        Me.btnAvailableOptions.UseVisualStyleBackColor = True
        Me.btnAvailableOptions.Visible = False
        '
        'tbxAvailableOptions
        '
        Me.tbxAvailableOptions.Location = New System.Drawing.Point(7, 171)
        Me.tbxAvailableOptions.Name = "tbxAvailableOptions"
        Me.tbxAvailableOptions.Size = New System.Drawing.Size(528, 20)
        Me.tbxAvailableOptions.TabIndex = 9
        Me.tbxAvailableOptions.Visible = False
        '
        'lblOptions
        '
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblOptions.Location = New System.Drawing.Point(6, 145)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(531, 23)
        Me.lblOptions.TabIndex = 8
        Me.lblOptions.Text = "How Many Options Are There?"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOptions.Visible = False
        '
        'tbxAnswer
        '
        Me.tbxAnswer.Location = New System.Drawing.Point(7, 249)
        Me.tbxAnswer.Name = "tbxAnswer"
        Me.tbxAnswer.Size = New System.Drawing.Size(528, 20)
        Me.tbxAnswer.TabIndex = 12
        Me.tbxAnswer.Visible = False
        '
        'lblAnswers
        '
        Me.lblAnswers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblAnswers.Location = New System.Drawing.Point(6, 223)
        Me.lblAnswers.Name = "lblAnswers"
        Me.lblAnswers.Size = New System.Drawing.Size(531, 23)
        Me.lblAnswers.TabIndex = 11
        Me.lblAnswers.Text = "Please Enter Option "
        Me.lblAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAnswers.Visible = False
        '
        'btnOptionEntry
        '
        Me.btnOptionEntry.Location = New System.Drawing.Point(460, 275)
        Me.btnOptionEntry.Name = "btnOptionEntry"
        Me.btnOptionEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnOptionEntry.TabIndex = 10
        Me.btnOptionEntry.Text = "Save"
        Me.btnOptionEntry.UseVisualStyleBackColor = True
        Me.btnOptionEntry.Visible = False
        '
        'tbxCorrectAnswer
        '
        Me.tbxCorrectAnswer.Location = New System.Drawing.Point(7, 327)
        Me.tbxCorrectAnswer.Name = "tbxCorrectAnswer"
        Me.tbxCorrectAnswer.Size = New System.Drawing.Size(528, 20)
        Me.tbxCorrectAnswer.TabIndex = 15
        Me.tbxCorrectAnswer.Visible = False
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(6, 301)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(531, 23)
        Me.lblCorrectAnswer.TabIndex = 14
        Me.lblCorrectAnswer.Text = "Please Enter The Correct Answer Option"
        Me.lblCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCorrectAnswer.Visible = False
        '
        'btnCorrectAnswer
        '
        Me.btnCorrectAnswer.Location = New System.Drawing.Point(460, 353)
        Me.btnCorrectAnswer.Name = "btnCorrectAnswer"
        Me.btnCorrectAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnCorrectAnswer.TabIndex = 13
        Me.btnCorrectAnswer.Text = "Save"
        Me.btnCorrectAnswer.UseVisualStyleBackColor = True
        Me.btnCorrectAnswer.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(559, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Current Question:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnResetQuestion
        '
        Me.btnResetQuestion.Location = New System.Drawing.Point(331, 396)
        Me.btnResetQuestion.Name = "btnResetQuestion"
        Me.btnResetQuestion.Size = New System.Drawing.Size(100, 42)
        Me.btnResetQuestion.TabIndex = 17
        Me.btnResetQuestion.Text = "Reset Current Question"
        Me.btnResetQuestion.UseVisualStyleBackColor = True
        Me.btnResetQuestion.Visible = False
        '
        'btnNextQuestion
        '
        Me.btnNextQuestion.Location = New System.Drawing.Point(437, 396)
        Me.btnNextQuestion.Name = "btnNextQuestion"
        Me.btnNextQuestion.Size = New System.Drawing.Size(100, 42)
        Me.btnNextQuestion.TabIndex = 18
        Me.btnNextQuestion.Text = "Next Question"
        Me.btnNextQuestion.UseVisualStyleBackColor = True
        Me.btnNextQuestion.Visible = False
        '
        'frmManualEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNextQuestion)
        Me.Controls.Add(Me.btnResetQuestion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxCorrectAnswer)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.btnCorrectAnswer)
        Me.Controls.Add(Me.tbxAnswer)
        Me.Controls.Add(Me.lblAnswers)
        Me.Controls.Add(Me.btnOptionEntry)
        Me.Controls.Add(Me.tbxAvailableOptions)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.btnAvailableOptions)
        Me.Controls.Add(Me.btnQuestionSave)
        Me.Controls.Add(Me.tbxQuestionDetails)
        Me.Controls.Add(Me.tbxQuestion)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblQuizLength)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManualEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inQUIZitive Page Generator - Manual Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblQuizLength As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents tbxQuestion As TextBox
    Friend WithEvents tbxQuestionDetails As TextBox
    Friend WithEvents btnQuestionSave As Button
    Friend WithEvents btnAvailableOptions As Button
    Friend WithEvents tbxAvailableOptions As TextBox
    Friend WithEvents lblOptions As Label
    Friend WithEvents tbxAnswer As TextBox
    Friend WithEvents lblAnswers As Label
    Friend WithEvents btnOptionEntry As Button
    Friend WithEvents tbxCorrectAnswer As TextBox
    Friend WithEvents lblCorrectAnswer As Label
    Friend WithEvents btnCorrectAnswer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnResetQuestion As Button
    Friend WithEvents btnNextQuestion As Button
End Class
