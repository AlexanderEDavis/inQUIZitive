questionNumber = 0
availableOptions= []
fileName = input("What would you like the file to be called?\n")
with open(fileName + '.html', 'a') as a:
    a.write("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"UTF-8\">\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://quiz.mrdavis.work/quiz.css\" />\n</head>\n<body>\n")
    quizName = input("What is the quiz on?\n")
    a.write("<h1><img style=\"float:left\" src=\"https://quiz.mrdavis.work/icon.png\" width=\"25\" height=\"25\" alt=\"\"/>Quiz on " + quizName + "<img style=\"float:right\" src=\"https://quiz.mrdavis.work/icon.png\" width=\"25\" height=\"25\" alt=\"\"/></h1>")
    a.write("<div class=\"quiz-container\">\n  <div id=\"quiz\"></div>\n</div>\n<button id=\"previous\">Previous Question</button>\n<button id=\"next\">Next Question</button>\n<button id=\"submit\">Submit Quiz</button>\n<div id=\"results\"></div>\n</body>\n<script>(function(){\n  // Functions\n  function buildQuiz(){\n    // variable to store the HTML output\n    const output = [];\n\n    // for each question...\n    myQuestions.forEach(\n      (currentQuestion, questionNumber) => {\n\n        // variable to store the list of possible answers\n        const answers = [];\n\n        // and for each available answer...\n        for(letter in currentQuestion.answers){\n\n          // ...add an HTML radio button\n          answers.push(\n            `<label>\n              <input type=\"radio\" name=\"question${questionNumber}\" value=\"${letter}\">\n              ${letter} :\n              ${currentQuestion.answers[letter]}\n            </label>`\n          );\n        }\n\n        // add this question and its answers to the output\n        output.push(\n          `<div class=\"slide\">\n            <div class=\"question\"> ${currentQuestion.question} </div>\n            <div class=\"answers\"> ${answers.join(\"\")} </div>\n          </div>`\n        );\n      }\n    );\n\n    // finally combine our output list into one string of HTML and put it on the page\n    quizContainer.innerHTML = output.join('');\n  }\n\n  function showResults(){\n\n    // gather answer containers from our quiz\n    const answerContainers = quizContainer.querySelectorAll('.answers');\n\n    // keep track of user's answers\n    let numCorrect = 0;\n\n    // for each question...\n    myQuestions.forEach( (currentQuestion, questionNumber) => {\n\n      // find selected answer\n      const answerContainer = answerContainers[questionNumber];\n      const selector = `input[name=question${questionNumber}]:checked`;\n      const userAnswer = (answerContainer.querySelector(selector) || {}).value;\n\n      // if answer is correct\n      if(userAnswer === currentQuestion.correctAnswer){\n        // add to the number of correct answers\n        numCorrect++;\n\n        // color the answers green\n        answerContainers[questionNumber].style.color = 'lightgreen';\n      }\n      // if answer is wrong or blank\n      else{\n        // color the answers red\n        answerContainers[questionNumber].style.color = 'red';\n      }\n    });\n\n    // show number of correct answers out of total\n    var reviseText = \"Revision Video\"\n    if (numCorrect<=(myQuestions.length/2)) {\n")
    reviseLink = input("What is the link to rerevise the current topic?\n")
    a.write("      var revise = reviseText.link(\""+ reviseLink + "\");\n      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the test again: ${revise}`;\n    } else {\n")
    proceedLink = input("What is the link to revise the NEXT topic?\n")
    a.write("      var revise = reviseText.link(\"" + proceedLink + "\");\n      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}<br>Watch this video before trying the next test: ${revise}`;\n    }\n\n  }\n\n  function showSlide(n) {\n    slides[currentSlide].classList.remove('active-slide');\n    slides[n].classList.add('active-slide');\n    currentSlide = n;\n    if(currentSlide === 0){\n      previousButton.style.display = 'none';\n    }\n    else{\n      previousButton.style.display = 'inline-block';\n    }\n    if(currentSlide === slides.length-1){\n      nextButton.style.display = 'none';\n      submitButton.style.display = 'inline-block';\n    }\n    else{\n      nextButton.style.display = 'inline-block';\n      submitButton.style.display = 'none';\n    }\n  }\n\n  function showNextSlide() {\n    showSlide(currentSlide + 1);\n  }\n\n  function showPreviousSlide() {\n    showSlide(currentSlide - 1);\n  }\n\n  // Variables\n  const quizContainer = document.getElementById('quiz');\n  const resultsContainer = document.getElementById('results');\n  const submitButton = document.getElementById('submit');\n  const myQuestions = [\n")
    questionEntry = True
    while questionEntry:
        questionNumber = questionNumber + 1
        question = input("Please enter question " + str(questionNumber) + "\n")
        a.write("    {\n      question: \"" + question + "\",\n      answers: {\n")
        numAnswer = int(input("How many answers are there in total?\n"))
        answerOptions = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"]
        for i in range(0,(numAnswer)):
            availableOptions.append(answerOptions[i])
            answerOption = input("What is option " + answerOptions[i] + "?\n")
            a.write("        " + answerOptions[i] + ": \"" + answerOption + "\"")
            if i < (numAnswer-1):
                a.write(",\n")
            elif i == (numAnswer-1):
                a.write("\n      },\n")
        correctOption = False
        while correctOption == False:
            correctAnswer = input("What option is the correct answer?\n")
            if correctAnswer in availableOptions:
                correctOption = True
                a.write("      correctAnswer: \"" + correctAnswer + "\"\n")
            else:
                print("That isn't a valid option")
                correctAnswer = input("What option is the correct answer?\n")
        questionCheck = input("Do you have any more questions to enter?\n")
        questionCheck = questionCheck.lower()
        questionCheck = questionCheck[0]
        if questionCheck == "n":
            a.write("    }\n\n  ];\n\n  // Kick things off\n  buildQuiz();\n\n  // Pagination\n  const previousButton = document.getElementById(\"previous\");\n  const nextButton = document.getElementById(\"next\");\n  const slides = document.querySelectorAll(\".slide\");\n  let currentSlide = 0;\n\n  // Show the first slide\n  showSlide(currentSlide);\n\n  // Event listeners\n  submitButton.addEventListener('click', showResults);\n  previousButton.addEventListener(\"click\", showPreviousSlide);\n  nextButton.addEventListener(\"click\", showNextSlide);\n})();\n</script>\n</html>")
            questionEntry = False
        else:
            a.write("    },\n")
input("File Created.\nPress any key to exit...")
