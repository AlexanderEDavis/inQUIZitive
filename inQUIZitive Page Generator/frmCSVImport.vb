Imports System.IO
Imports System.Text
Public Class frmCSVImport
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmWelcome.Show()
        Me.Close()
    End Sub

    Private Sub btnSourceBrowse_Click(sender As Object, e As EventArgs) Handles btnSourceBrowse.Click
        dbxSourceDialog.Title = "Select CSV File"
        dbxSourceDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        If dbxSourceDialog.ShowDialog() = DialogResult.OK Then
            tbxSourceLocation.Text = dbxSourceDialog.FileName
        End If
    End Sub

    Private Sub btnDestinationBrowse_Click(sender As Object, e As EventArgs) Handles btnDestinationBrowse.Click
        dbxDestinationDialog.Title = "Save Page Location"
        dbxDestinationDialog.Filter = "HTML File|*.html|All files|*.*"
        If dbxDestinationDialog.ShowDialog() = DialogResult.OK Then
            tbxDestinationLocation.Text = dbxDestinationDialog.FileName
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim FilePath As String = tbxSourceLocation.Text
        Dim Lines() As String = File.ReadAllLines(FilePath)
        Dim FileArray(Lines.Length - 1)() As String
        For I As Integer = 0 To Lines.Length - 1
            FileArray(I) = Lines(I).Split(",")
        Next
        Dim newFile As String = tbxDestinationLocation.Text
        ' Create or overwrite the file.
        Dim export As System.IO.StreamWriter
        export = My.Computer.FileSystem.OpenTextFileWriter(newFile, True)
        ' Add text to the file.
        Dim info As String = "<!DOCTYPE html>" & vbCrLf & "<html>" & vbCrLf & "<head>" & vbCrLf & "<meta charset=" & Chr(34) & "UTF-8" & Chr(34) & ">" & vbCrLf & "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & " href=" & Chr(34) & "https://quiz.mrdavis.work/quiz.css" & Chr(34) & " />" & vbCrLf & "</head>" & vbCrLf & "<body>" & vbCrLf & "<h1><img style=" & Chr(34) & "float: Left" & Chr(34) & " src=" & Chr(34) & "https://quiz.mrdavis.work/icon.png" & Chr(34) & " width=" & Chr(34) & "25" & Chr(34) & " height=" & Chr(34) & "25" & Chr(34) & " alt=" & Chr(34) & "" & Chr(34) & "/>Quiz on " + FileArray(0)(0) + "<img style=" & Chr(34) & "float:right" & Chr(34) & " src=" & Chr(34) & "https://quiz.mrdavis.work/icon.png" & Chr(34) & " width=" & Chr(34) & "25" & Chr(34) & " height=" & Chr(34) & "25" & Chr(34) & " alt=" & Chr(34) & "" & Chr(34) & "/></h1>" & vbCrLf & "<div class=" & Chr(34) & "quiz-container" & Chr(34) & ">" & vbCrLf & "  <div id=" & Chr(34) & "quiz" & Chr(34) & "></div>" & vbCrLf & "</div>" & vbCrLf & "<button id=" & Chr(34) & "previous" & Chr(34) & ">Previous Question</button>" & vbCrLf & "<button id=" & Chr(34) & "next" & Chr(34) & ">Next Question</button>" & vbCrLf & "<button id=" & Chr(34) & "submit" & Chr(34) & ">Submit Quiz</button>" & vbCrLf & "<div id=" & Chr(34) & "results" & Chr(34) & "></div>" & vbCrLf & "</body>" & vbCrLf & "<script>(function(){" & vbCrLf & "  // Functions" & vbCrLf & "  function buildQuiz(){" & vbCrLf & "    // variable to store the HTML output" & vbCrLf & "    const output = [];" & vbCrLf & "" & vbCrLf & "    // for each question..." & vbCrLf & "    myQuestions.forEach(" & vbCrLf & "      (currentQuestion, questionNumber) => {" & vbCrLf & "" & vbCrLf & "        // variable to store the list of possible answers" & vbCrLf & "        const answers = [];" & vbCrLf & "" & vbCrLf & "        // and for each available answer..." & vbCrLf & "        for(letter in currentQuestion.answers){" & vbCrLf & "" & vbCrLf & "          // ...add an HTML radio button" & vbCrLf & "          answers.push(" & vbCrLf & "            `<label>" & vbCrLf & "              <input type=" & Chr(34) & "radio" & Chr(34) & " name=" & Chr(34) & "question${questionNumber}" & Chr(34) & " value=" & Chr(34) & "${letter}" & Chr(34) & ">" & vbCrLf & "              ${letter} :" & vbCrLf & "              ${currentQuestion.answers[letter]}" & vbCrLf & "            </label>`" & vbCrLf & "          );" & vbCrLf & "        }" & vbCrLf & "" & vbCrLf & "        // add this question and its answers to the output" & vbCrLf & "        output.push(" & vbCrLf & "          `<div class=" & Chr(34) & "slide" & Chr(34) & ">" & vbCrLf & "            <div class=" & Chr(34) & "question" & Chr(34) & "> ${currentQuestion.question} </div>" & vbCrLf & "            <div class=" & Chr(34) & "answers" & Chr(34) & "> ${answers.join(" & Chr(34) & "" & Chr(34) & ")} </div>" & vbCrLf & "          </div>`" & vbCrLf & "        );" & vbCrLf & "      }" & vbCrLf & "    );" & vbCrLf & "" & vbCrLf & "    // finally combine our output list into one string of HTML and put it on the page" & vbCrLf & "    quizContainer.innerHTML = output.join('');" & vbCrLf & "  }" & vbCrLf & "" & vbCrLf & "  function showResults(){" & vbCrLf & "" & vbCrLf & "    // gather answer containers from our quiz" & vbCrLf & "    const answerContainers = quizContainer.querySelectorAll('.answers');" & vbCrLf & "" & vbCrLf & "    // keep track of user's answers" & vbCrLf & "    let numCorrect = 0;" & vbCrLf & "" & vbCrLf & "    // for each question..." & vbCrLf & "    myQuestions.forEach( (currentQuestion, questionNumber) => {" & vbCrLf & "" & vbCrLf & "      // find selected answer" & vbCrLf & "      const answerContainer = answerContainers[questionNumber];" & vbCrLf & "      const selector = `input[name=question${questionNumber}]:checked`;" & vbCrLf & "      const userAnswer = (answerContainer.querySelector(selector) || {}).value;" & vbCrLf & "" & vbCrLf & "      // if answer is correct" & vbCrLf & "      if(userAnswer === currentQuestion.correctAnswer){" & vbCrLf & "        // add to the number of correct answers" & vbCrLf & "        numCorrect++;" & vbCrLf & "" & vbCrLf & "        // color the answers green" & vbCrLf & "        answerContainers[questionNumber].style.color = 'lightgreen';" & vbCrLf & "      }" & vbCrLf & "      // if answer is wrong or blank" & vbCrLf & "      else{" & vbCrLf & "        // color the answers red" & vbCrLf & "        answerContainers[questionNumber].style.color = 'red';" & vbCrLf & "      }" & vbCrLf & "    });" & vbCrLf & "" & vbCrLf & "    // show number of correct answers out of total" & vbCrLf & "    var reviseText = " & Chr(34) & "Revision Video" & Chr(34) & "" & vbCrLf & "    if (numCorrect<=(myQuestions.length/2)) {" & vbCrLf & "      var revise = reviseText.link(" & Chr(34) & FileArray(0)(1) & ");" & vbCrLf & "      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the test again: ${revise}`;" & vbCrLf & "    } else {" & vbCrLf & "      var revise = reviseText.link(" & Chr(34) & "" + FileArray(0)(2) + "" & Chr(34) & ");" & vbCrLf & "      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the next test: ${revise}`;" & vbCrLf & "    }" & vbCrLf & "" & vbCrLf & "  }" & vbCrLf & "" & vbCrLf & "  function showSlide(n) {" & vbCrLf & "    slides[currentSlide].classList.remove('active-slide');" & vbCrLf & "    slides[n].classList.add('active-slide');" & vbCrLf & "    currentSlide = n;" & vbCrLf & "    if(currentSlide === 0){" & vbCrLf & "      previousButton.style.display = 'none';" & vbCrLf & "    }" & vbCrLf & "    else{" & vbCrLf & "      previousButton.style.display = 'inline-block';" & vbCrLf & "    }" & vbCrLf & "    if(currentSlide === slides.length-1){" & vbCrLf & "      nextButton.style.display = 'none';" & vbCrLf & "      submitButton.style.display = 'inline-block';" & vbCrLf & "    }" & vbCrLf & "    else{" & vbCrLf & "      nextButton.style.display = 'inline-block';" & vbCrLf & "      submitButton.style.display = 'none';" & vbCrLf & "    }" & vbCrLf & "  }" & vbCrLf & "" & vbCrLf & "  function showNextSlide() {" & vbCrLf & "    showSlide(currentSlide + 1);" & vbCrLf & "  }" & vbCrLf & "" & vbCrLf & "  function showPreviousSlide() {" & vbCrLf & "    showSlide(currentSlide - 1);" & vbCrLf & "  }" & vbCrLf & "" & vbCrLf & "  // Variables" & vbCrLf & "  const quizContainer = document.getElementById('quiz');" & vbCrLf & "  const resultsContainer = document.getElementById('results');" & vbCrLf & "  const submitButton = document.getElementById('submit');" & vbCrLf & "  const myQuestions = [" & vbCrLf & ""
        export.Write(info)
        Dim dataString As String = ""
        Dim questionEntry
        questionEntry = True
        Dim questionNumber
        Dim answerOptions As Array = {"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim numAnswer
        Dim quizLength
        questionNumber = 0
        While questionEntry = True
            questionNumber = questionNumber + 1
            dataString = dataString + "    {" & vbCrLf & "      question: " & Chr(34) & FileArray(questionNumber)(0) & ": " & Chr(34) & vbCrLf & "      answers: {" & vbCrLf
            numAnswer = FileArray(questionNumber).Length() - 2
            For i As Integer = 1 To (numAnswer + 1)
                If FileArray(questionNumber)(i) = "" Then

                Else
                    dataString = dataString & "        " & answerOptions(i) & ": " & Chr(34) & "" & FileArray(questionNumber)(i) & "" & Chr(34)
                End If
                If i < numAnswer Then
                    dataString = dataString + "," & vbCrLf
                ElseIf i = numAnswer Then
                    dataString = dataString & vbCrLf & "      }," & vbCrLf
                    dataString = dataString & "      correctAnswer: " & Chr(34) & FileArray(questionNumber)(FileArray(questionNumber).Length - 1) + " \ " & vbCrLf
                End If
                quizLength = FileArray.Length - 1
                If questionNumber = quizLength Then
                    dataString = dataString & "    }" & vbCrLf & "" & vbCrLf & "  ];" & vbCrLf & "" & vbCrLf & "  // Kick things off" & vbCrLf & "  buildQuiz();" & vbCrLf & "" & vbCrLf & "  // Pagination" & vbCrLf & "  const previousButton = document.getElementById(" & Chr(34) & "previous" & Chr(34) & ");" & vbCrLf & "  const nextButton = document.getElementById(" & Chr(34) & "Next" & Chr(34) & ");" & vbCrLf & "  const slides = document.querySelectorAll(" & Chr(34) & ".slide" & Chr(34) & ");" & vbCrLf & "  let currentSlide = 0;" & vbCrLf & "" & vbCrLf & "  // Show the first slide" & vbCrLf & "  showSlide(currentSlide);" & vbCrLf & "" & vbCrLf & "  // Event listeners" & vbCrLf & "  submitButton.addEventListener('click', showResults);" & vbCrLf & "  previousButton.addEventListener(" & Chr(34) & "click" & Chr(34) & ", showPreviousSlide);" & vbCrLf & "  nextButton.addEventListener(" & Chr(34) & "click" & Chr(34) & ", showNextSlide);" & vbCrLf & "})();" & vbCrLf & "</script>" & vbCrLf & "</html>"
                    questionEntry = False
                Else
                    dataString = dataString & "    }," & vbCrLf
                End If
            Next
        End While
        export.Write(dataString)
        export.Close()
        MsgBox("File Creation Complete", 0, "Complete")
    End Sub
End Class