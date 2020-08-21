Imports System.IO
Imports System.Text
Public Class frmCSVImport
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
        If tbxSourceLocation.Text = "" Or tbxDestinationLocation.Text = "" Then
            MessageBox.Show("Invalid Source or Destination! Try again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If System.IO.File.Exists(tbxDestinationLocation.Text) = True Then

                System.IO.File.Delete(tbxDestinationLocation.Text)
                MessageBox.Show("File Already Exists. Original File Deleted")

            End If
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
            export.WriteLine("<!DOCTYPE html>")
            export.WriteLine("<html>")
            export.WriteLine("<head>")
            export.WriteLine("<meta charset=""UTF-8"">")
            export.WriteLine("<link rel=""stylesheet"" type=""text/css"" href=""https://quiz.mrdavis.work/quiz.css"" />")
            export.WriteLine("</head>")
            export.WriteLine("<body>")
            export.WriteLine("<h1><img style=""float:left"" src=""https://quiz.mrdavis.work/icon.png"" width=""25"" height=""25"" alt=""""/>Quiz on " + FileArray(0)(0) + "<img style=""float:right"" src=""https://quiz.mrdavis.work/icon.png"" width=""25"" height=""25"" alt=""""/></h1>")
            export.WriteLine("<div class=""quiz-container"">")
            export.WriteLine("<div id=""quiz""></div>")
            export.WriteLine("</div>")
            export.WriteLine("<button id=""previous"">Previous Question</button>")
            export.WriteLine("<button id=""Next"">Next Question</button>")
            export.WriteLine("<button id=""submit"">Submit Quiz</button>")
            export.WriteLine("<div id =""results"" ></div>")
            export.WriteLine("</body>")
            export.WriteLine("<script>(function() {")
            export.WriteLine("// Functions ")
            export.WriteLine("function buildQuiz(){")
            export.WriteLine("    // variable To store the HTML output")
            export.WriteLine("    const output = [];")
            export.WriteLine("")
            export.WriteLine("    // For Each question...")
            export.WriteLine("    myQuestions.forEach(")
            export.WriteLine("      (currentQuestion, questionNumber) => {")
            export.WriteLine("")
            export.WriteLine("        // variable To store the list Of possible answers")
            export.WriteLine("        const answers = [];")
            export.WriteLine("")
            export.WriteLine("        // And For Each available answer...")
            export.WriteLine("        for(letter in currentQuestion.answers){")
            export.WriteLine("")
            export.WriteLine("          // ...add an HTML radio button")
            export.WriteLine("          answers.push(")
            export.WriteLine("            `<label>")
            export.WriteLine("              <input type=""radio"" name=""question${questionNumber}"" value=""${letter}"">")
            export.WriteLine("              ${letter} : ")
            export.WriteLine("              ${currentQuestion.answers[letter]}")
            export.WriteLine("            </label>`")
            export.WriteLine("          );")
            export.WriteLine("        }")
            export.WriteLine("")
            export.WriteLine("        // add this question And its answers to the output")
            export.WriteLine("        output.push(")
            export.WriteLine("          `<div class=""slide"">")
            export.WriteLine("            <div class=""question""> ${currentQuestion.question} </div>")
            export.WriteLine("            <div class=""answers""> ${answers.join("""")} </div>")
            export.WriteLine("          </div>`")
            export.WriteLine("        );")
            export.WriteLine("      }")
            export.WriteLine("    );")
            export.WriteLine("")
            export.WriteLine("    // finally combine our output list into one string of HTML And put it on the page")
            export.WriteLine("    quizContainer.innerHTML = output.join('');")
            export.WriteLine("  }")
            export.WriteLine("")
            export.WriteLine("  function showResults(){")
            export.WriteLine("")
            export.WriteLine("    // gather answer containers from our quiz")
            export.WriteLine("    const answerContainers = quizContainer.querySelectorAll('.answers');")
            export.WriteLine("")
            export.WriteLine("    // keep track of user's answers")
            export.WriteLine("    let numCorrect = 0;")
            export.WriteLine("")
            export.WriteLine("    // for each question...")
            export.WriteLine("    myQuestions.forEach( (currentQuestion, questionNumber) => {")
            export.WriteLine("")
            export.WriteLine("      // find selected answer")
            export.WriteLine("      const answerContainer = answerContainers[questionNumber];")
            export.WriteLine("      const selector = `input[name=question${questionNumber}]:checked`;")
            export.WriteLine("      const userAnswer = (answerContainer.querySelector(selector) || {}).value;")
            export.WriteLine("")
            export.WriteLine("      // if answer is correct")
            export.WriteLine("      if(userAnswer === currentQuestion.correctAnswer){")
            export.WriteLine("        // add to the number of correct answers")
            export.WriteLine("        numCorrect++;")
            export.WriteLine("")
            export.WriteLine("        // color the answers green")
            export.WriteLine("        answerContainers[questionNumber].style.color = 'lightgreen';")
            export.WriteLine("      }")
            export.WriteLine("      // if answer is wrong or blank")
            export.WriteLine("      else{")
            export.WriteLine("        // color the answers red")
            export.WriteLine("        answerContainers[questionNumber].style.color = 'red';")
            export.WriteLine("      }")
            export.WriteLine("    });")
            export.WriteLine("")
            export.WriteLine("    // show number of correct answers out of total")
            export.WriteLine("    var reviseText = ""Revision Video""")
            export.WriteLine("    if (numCorrect<=(myQuestions.length/2)) {")
            export.WriteLine("      var revise = reviseText.link(""" + FileArray(0)(1) + """);")
            export.WriteLine("      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the test again: ${revise}`;")
            export.WriteLine("    } else {")
            export.WriteLine("")
            export.WriteLine("      var revise = reviseText.link(""" + FileArray(0)(2) + """);")
            export.WriteLine("      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the next test: ${revise}`;")
            export.WriteLine("    }")
            export.WriteLine("")
            export.WriteLine("  }")
            export.WriteLine("")
            export.WriteLine("  function showSlide(n) {")
            export.WriteLine("    slides[currentSlide].classList.remove('active-slide');")
            export.WriteLine("    slides[n].classList.add('active-slide');")
            export.WriteLine("    currentSlide = n;")
            export.WriteLine("    if(currentSlide === 0){")
            export.WriteLine("      previousButton.style.display = 'none';")
            export.WriteLine("    }")
            export.WriteLine("    else{")
            export.WriteLine("      previousButton.style.display = 'inline-block';")
            export.WriteLine("    }")
            export.WriteLine("    if(currentSlide === slides.length-1){")
            export.WriteLine("      nextButton.style.display = 'none';")
            export.WriteLine("      submitButton.style.display = 'inline-block';")
            export.WriteLine("    }")
            export.WriteLine("    else{")
            export.WriteLine("      nextButton.style.display = 'inline-block';")
            export.WriteLine("      submitButton.style.display = 'none';")
            export.WriteLine("    }")
            export.WriteLine("  }")
            export.WriteLine("")
            export.WriteLine("  function showNextSlide() {")
            export.WriteLine("    showSlide(currentSlide + 1);")
            export.WriteLine("  }")
            export.WriteLine("")
            export.WriteLine("  function showPreviousSlide() {")
            export.WriteLine("    showSlide(currentSlide - 1);")
            export.WriteLine("  }")
            export.WriteLine("")
            export.WriteLine("  // Variables")
            export.WriteLine("  const quizContainer = document.getElementById('quiz');")
            export.WriteLine("  const resultsContainer = document.getElementById('results');")
            export.WriteLine("  const submitButton = document.getElementById('submit');")
            export.WriteLine("  const myQuestions = [")
            Dim questionEntry
            questionEntry = True
            Dim questionNumber
            Dim answerOptions As Array = {"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
            Dim numAnswer
            Dim quizLength
            questionNumber = 0
            While questionEntry = True
                questionNumber = questionNumber + 1
                export.WriteLine("    {")
                export.WriteLine("      question: """ + FileArray(questionNumber)(0) + """,")
                export.WriteLine("      answers: {")
                numAnswer = FileArray(questionNumber).Length() - 2
                For i As Integer = 1 To (numAnswer)
                    If FileArray(questionNumber)(i) = "" Then

                    Else
                        export.Write("        " + answerOptions(i) + ": """ + FileArray(questionNumber)(i) + """")
                    End If
                    If i < numAnswer Then
                        export.WriteLine(",")
                    ElseIf i = numAnswer Then
                        export.WriteLine("")
                        export.WriteLine("      },")
                        export.WriteLine("      correctAnswer: """ + FileArray(questionNumber)(FileArray(questionNumber).Length - 1) + """")
                    End If
                Next
                quizLength = FileArray.Length - 1
                If questionNumber = quizLength Then
                    export.WriteLine("    }")
                    export.WriteLine("")
                    export.WriteLine("  ];")
                    export.WriteLine("")
                    export.WriteLine("  // Kick things off")
                    export.WriteLine("  buildQuiz();")
                    export.WriteLine("")
                    export.WriteLine("  // Pagination")
                    export.WriteLine("  const previousButton = document.getElementById(""previous"");")
                    export.WriteLine("  const nextButton = document.getElementById(""Next"");")
                    export.WriteLine("  const slides = document.querySelectorAll("".slide"");")
                    export.WriteLine("  let currentSlide = 0;")
                    export.WriteLine("")
                    export.WriteLine("  // Show the first slide")
                    export.WriteLine("  showSlide(currentSlide);")
                    export.WriteLine("")
                    export.WriteLine("  // Event listeners")
                    export.WriteLine("  submitButton.addEventListener('click', showResults);")
                    export.WriteLine("  previousButton.addEventListener(""click"", showPreviousSlide);")
                    export.WriteLine("  nextButton.addEventListener(""click"", showNextSlide);")
                    export.WriteLine("})();")
                    export.WriteLine("</script>")
                    export.WriteLine("</html>")
                    questionEntry = False
                Else
                    export.WriteLine("    },")
                End If
            End While
            export.Close()
            Dim dresult As DialogResult = MessageBox.Show("File Creation Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If (dresult = DialogResult.OK) Then
                Process.Start(newFile)
            End If
        End If
    End Sub
End Class