'NAME: Varsan Jeyakkumar
'DATE: June 9th 2023
'TITLE: Accident Stimulator
'PURPOSE: To create a roleplay stimulator where a user makes decisions to investigate and solve a vehicular collision. 

Module Module1
    'Variables for Whole Project
    Dim strUser As String 'User response
    Dim intPointsCounter As Integer = 0 'Number of points the user has
    Dim intMaxPoints As Integer = 57 'Maximum points possible
    Dim intManagementPoints As Integer 'Points for investigation
    Dim intDecisionPoints As Integer 'Points for decisions

    Sub Main()
        Console.ForegroundColor = ConsoleColor.White
        Randomize() 'Enables random function for the whole project
        Menu() 'Launches main menu at the start of the program
    End Sub



    Sub Menu()
        'Module Variables
        Dim strResponse As String 'User Response
        Dim isMenuTerminated As Boolean = False 'For menu loop

        'Program
        Do While isMenuTerminated = False
            Console.Clear() 'Clears the console of previous dialogue
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("_______________________________")
            Console.WriteLine("Welcome to Accident Stimulator!") 'Code for the main menu
            Console.WriteLine("_______________________________")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("Please select an  option:")
            Console.WriteLine("(A) PLAY GAME")
            Console.WriteLine("(B) HOW TO PLAY")
            Console.WriteLine("(C) ABOUT AND CREDITS")
            Console.WriteLine("(D) EXIT GAME")
            Console.ForegroundColor = ConsoleColor.Red
            strUser = Console.ReadLine() 'Reads user's input
            Console.ForegroundColor = ConsoleColor.White
            strResponse = strUser 'Converts input to response
            Console.WriteLine("")
            If strResponse.ToUpper = "A" Then 'Enters Game
                Introduction()
            ElseIf strResponse.ToUpper = "B" Then 'How to Play
                Instructions()
            ElseIf strResponse.ToUpper = "C" Then 'Game Credits
                Credits()
            ElseIf strResponse.ToUpper = "D" Then 'Exits Game
                Console.WriteLine("Thank you for playing!")
                Console.WriteLine("Press any key to exit!")
                Console.ReadKey()
                isMenuTerminated = True
            Else 'Invalid Response
                Console.WriteLine("Invalid Response. Select either A, B, C or D.")
                Console.WriteLine("Press any key to return to main menu.")
                Console.ReadKey()
                ThreeLines()
            End If
        Loop
    End Sub
    Sub Instructions()
        'Program
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("Accident Stimulator is a roleplay game.")
        Console.WriteLine("You are a police officer and your job is to respond to a collision.")
        Console.WriteLine("As a cop, you will investigate the accident and clear the scene.")
        Console.WriteLine("For right decisions you will gain points.")
        Console.WriteLine("For wrong decisions you might lose points. You can also get fired.")
        Console.WriteLine("Try to earn the most points that you can.")
        Console.WriteLine("--------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("Press any key to return to the main menu.")
        Console.ReadKey() 'Waits for user to respond

        ThreeLines() 'To skip three lines
    End Sub

    Sub Credits() 'Displays Credits
        'Program
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("Accident Stimulator")
        Console.WriteLine("Designer/Programmer: Varsan Jeyakkumar")
        Console.WriteLine("Release Date: June 17th 2023")
        Console.WriteLine("Version: 1.0.0")
        Console.WriteLine("Created For: Jonathan Ryu")
        Console.WriteLine("Course Code: TEJ201-2")
        Console.WriteLine("--------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("Press any key to return to the main menu.")
        Console.ReadKey() 'Waits for user to respond

        ThreeLines() 'To skip three lines
    End Sub

    Sub ThreeLines() 'To skip three lines, for graphics/visualization
        'Module Variables
        Dim intCounter As Integer

        'Program
        For intCounter = 1 To 3 'Does action 3 times
            Console.WriteLine("") 'Skips line 3 times
        Next
    End Sub

    'Game Code
    Sub Introduction()
        'Module Variables
        Dim strResponse As String 'User response
        Dim isDecisionWrong As Boolean = True 'Punishes user for wrong decision.
        'Program
        Console.Clear() 'Clears the console of previous dialogue
        intDecisionPoints = 0 'Sets value of points
        intManagementPoints = 0
        intMaxPoints = 57
        intPointsCounter = 0

        Console.WriteLine("                       ")
        Console.WriteLine("        _[_|]__        ")
        Console.WriteLine("       //  ||\ \       ")
        Console.WriteLine(" _____//___||_\ \___   ")
        Console.WriteLine(" )  _  POLICE  _    \  ")
        Console.WriteLine(" |_/ \________/ \___|  ")
        Console.WriteLine("___\_/________\_/______")
        ThreeLines()
        Console.WriteLine("You arrive at the scene to notice a three vehicle collision blocking the two right lanes on the highway. ")
        Console.WriteLine("One vehicle is severely damaged. A person seems to be lying on the floor. ")
        Console.WriteLine("You are the first on scene. What do you do?")

        Do
            Console.WriteLine("(A) Control traffic to prevent congestion and mayhem")
            Console.WriteLine("(B) Get medical assistance for the person on the floor")
            Console.WriteLine("(C) Get a tow truck to help clear the scene of the accident faster")
            Console.ForegroundColor = ConsoleColor.Red
            strUser = Console.ReadLine() 'Reads user's input
            Console.ForegroundColor = ConsoleColor.White

            strResponse = strUser 'Sets response 
            Console.WriteLine("")

            If strResponse.ToUpper = "A" Or strResponse.ToUpper = "C" Then 'Wrong choice
                Console.WriteLine("The person on the ground unfortunately dies of negligence.")
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.WriteLine("For negligence causing death, you are FIRED from the police force")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("Press any key to return to the main menu.")
                Console.ReadKey() 'Waits for user response
                Exit Do 'Leaves responses
            ElseIf strResponse.ToUpper = "B" Then 'Right choice
                isDecisionWrong = False 'Prevents failiure option
                Console.WriteLine("An ambulance comes. Thankfully, Anne only has minor injuries. ")
                intPointsCounter += 5
                Console.WriteLine("Press any key to proceed!")
                Console.ReadKey()
                Exit Do 'Leaves responses
            Else
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.WriteLine("INVALID RESPONSE")
                ThreeLines() 'To skip three lines
                Console.ForegroundColor = ConsoleColor.White
            End If
        Loop

        If isDecisionWrong = False Then
            ThreeLines()
            Questionning() 'Moves onto the next stage
        End If

    End Sub

    Sub Questionning()
        'Module Variables
        Dim strFirstQ, strSecondQ, strThirdQ, strFourthQ As String
        Dim intCorrectGuesses As Integer = 0
        'Program
        Console.Clear() 'Clears the console of previous dialogue
        Console.WriteLine("Anne is alright and she can remain at the scene.") 'Context and instructions
        Console.WriteLine("The three drivers involved in the collision were Anne, Ben and Charlie.")
        Console.WriteLine("Now, your job is to question the drivers to get their accounts.")
        Console.WriteLine("Choose the order of questions to ask!")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("A] Do you have anything else to add?")
        Console.WriteLine("B] Tell me what happenned at the accident?")
        Console.WriteLine("C] Are you okay? Do you require medical assistance?")
        Console.WriteLine("D] Were any drivers speeding or driving carelessly?")
        Console.WriteLine("--------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("What is question 1 to ask?") 'Asks first question
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strFirstQ = strUser

        Console.WriteLine("What is question 2 to ask?") 'Asks second question
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strSecondQ = strUser

        Console.WriteLine("What is question 3 to ask?") 'Asks third question
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strThirdQ = strUser

        Console.WriteLine("What is question 4 to ask?") 'Asks fourth question
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strFourthQ = strUser

        If strFirstQ.ToUpper = "C" Then 'If first question correct
            intPointsCounter += 3 'Gives 3 points
            intCorrectGuesses += 1 'Adds 1 correct guess for output
        End If

        If strSecondQ.ToUpper = "B" Then 'If second question correct
            intPointsCounter += 3 'Gives 3 points
            intCorrectGuesses += 1 'Adds 1 correct guess for output
        End If

        If strThirdQ.ToUpper = "D" Then 'If third question correct
            intPointsCounter += 3 'Gives 3 points
            intCorrectGuesses += 1 'Adds 1 correct guess for output
        End If

        If strFourthQ.ToUpper = "A" Then 'If fourth question correct
            intPointsCounter += 3 'Gives 3 points
            intCorrectGuesses += 1 'Adds 1 correct guess for output
        End If

        Console.WriteLine("You got " & intCorrectGuesses & " questions in the correct order.") 'Tells user number q's correct
        Console.WriteLine((4 - intCorrectGuesses) & " questions were placed in the wrong order.") 'Tells user number q's incorrect
        Console.WriteLine("Press any key to proceed!")

        Console.ReadKey() 'Waits to proceed
        ThreeLines()
        Documentation()
    End Sub

    Sub Documentation()
        'Module Variables
        Dim strResponse As String
        Dim isLicense, isRegisteration, isInsurance As Boolean
        Dim intIncorrectGuesses As Integer = 0
        Dim intCorrectGuessses As Integer = 0
        Dim dblChanceTicket As Double
        Dim intExpiredTicket As Integer
        'Program
        Console.Clear() 'Clears the console of previous dialogue
        isLicense = False
        isRegisteration = False
        isInsurance = False
        Console.WriteLine("After questionning, your next task is to get the necessary documentation from all drivers.") 'User instructions
        Console.WriteLine("Ask for the 3 documents all drivers are required to have. (Up To 3 Incorrect Guesses)")
        Console.WriteLine("Ask for one documentation at a time. Do not repeat documents.")
        Do While intIncorrectGuesses < 4 'Exits if too many incorrect guesses
            If isLicense = True And isRegisteration = True And isInsurance = True Then 'Exits if all documentation obtained
                Exit Do
            End If

            Console.ForegroundColor = ConsoleColor.Red
            strUser = Console.ReadLine() 'Reads user's input
            Console.ForegroundColor = ConsoleColor.White
            strResponse = strUser
            If (strResponse.ToLower = "license" Or strResponse.ToLower = "drivers license" Or strResponse.ToLower = "driver's license") And isLicense = False Then 'If license stated
                Console.WriteLine("Correct")
                isLicense = True
                intCorrectGuessses += 1
            ElseIf strResponse.ToLower = "registeration" And isRegisteration = False Then 'If registeration stated
                Console.WriteLine("Correct")
                isRegisteration = True
                intCorrectGuessses += 1
            ElseIf (strResponse.ToLower = "insurance" Or strResponse.ToLower = "proof of insurance") And isInsurance = False Then 'If insurance stated
                Console.WriteLine("Correct")
                isInsurance = True
                intCorrectGuessses += 1
            Else 'Guess incorrect
                Console.WriteLine("Incorrect")
                intIncorrectGuesses += 1
            End If
        Loop
        Console.WriteLine("You got " & intCorrectGuessses & " out of 3 correct documentation!") 'Number correct
        Console.WriteLine("You got " & intIncorrectGuesses & " incorrect guesses in total.") 'Number incorrect
        intPointsCounter = intPointsCounter + (6 - (intIncorrectGuesses * 2) + (intCorrectGuessses * 3)) 'Adds points
        Console.WriteLine(" ")

        dblChanceTicket = Rnd()
        If Rnd() >= 0.5 And isLicense Then 'Random event chance
            intMaxPoints += 5
            Console.WriteLine("You notice that Charlie's License is expired by 106 days.") 'Gives instructions
            Console.WriteLine("Pick from one of the following options.")
            Console.WriteLine("(A) Give Charlie a citation")
            Console.WriteLine("(B) Let Charlie off with a warning")
            Console.ForegroundColor = ConsoleColor.Red
            strUser = Console.ReadLine() 'Reads user's input
            Console.ForegroundColor = ConsoleColor.White
            strResponse = strUser
            If strResponse.ToUpper = "B" Then 'If warning selected
                Console.WriteLine("Wow, that typically does not happen.")
                intPointsCounter += 1 'Gives a point
            ElseIf strResponse.ToUpper = "A" Then
                Console.WriteLine("How much is the ticket in dollars for a first time offence for an expired license?")
                Console.WriteLine("Be REASONABLE!") 'Gives instructions
                Console.ForegroundColor = ConsoleColor.Red
                strUser = Console.ReadLine() 'Reads user's input
                Console.ForegroundColor = ConsoleColor.White
                If strUser.Substring(0, 1) = "$" Then 'Removes $ sign if stated
                    strUser = strUser.Substring(1, strUser.Length - 1)
                End If
                intExpiredTicket = Val(strUser)
                If intExpiredTicket < 150 Then 'If fine way too low
                    Console.WriteLine("Don't you think that's way too little.")
                    intPointsCounter += 1
                ElseIf intExpiredTicket >= 150 And intExpiredTicket < 250 Then 'If fine bit low
                    Console.WriteLine("Okay, that's still a bit low.")
                    intPointsCounter += 3
                ElseIf intExpiredTicket >= 250 And intExpiredTicket <= 350 Then 'If fine right amount
                    Console.WriteLine("That's a good ticket amount.")
                    intPointsCounter += 5
                ElseIf intExpiredTicket > 350 And intExpiredTicket <= 450 Then 'If fine bit high
                    Console.WriteLine("You seem to be in a pretty bad mood...")
                    intPointsCounter += 3
                Else 'If fine too high
                    intPointsCounter += 1
                    Console.WriteLine("That fine is way too high. Its a FIRST OFFENCE.")
                End If
            Else 'No response if response invalid
                Console.WriteLine("Invalid option selected. You just ignore the expired license.")
            End If

        End If
        Console.WriteLine("Press any key to proceed.")
        Console.ReadKey()
        ThreeLines()
        Pictures()
    End Sub

    Sub Pictures()
        'Module Variables
        Dim intCorrectAnswers, intIncorrectAnswers As Integer 'Number of right and wrong answers
        Dim strAnswer As String 'User's answer

        'Program
        Console.Clear() 'Clears the console of previous dialogue
        Console.WriteLine("Now, its time to take pictures.")
        Console.WriteLine("Each question, 2 phrases will be written with one blank. Find a word (singular) that fits the blank.")
        Console.WriteLine("You will get two correct points for each correct answer.")
        ThreeLines()

        Console.WriteLine("When I ride my __________cycle, I wear an helmet.")
        Console.WriteLine("Head of states are often transported in a __________cade.")
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnswer = strUser
        If strAnswer.ToLower = "motor" Then 'Checks if answer right
            intCorrectAnswers += 1 'Adds one to correct counter
        Else
            intIncorrectAnswers += 1 'Adds one to incorrect counter
        End If
        ThreeLines()

        Console.WriteLine("An elephant squirts water with it's __________.")
        Console.WriteLine("I store a spare tire in my car's __________.")
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnswer = strUser
        If strAnswer.ToLower = "trunk" Then 'Checks if answer right
            intCorrectAnswers += 1 'Adds one to correct counter
        Else
            intIncorrectAnswers += 1 'Adds one to incorrect counter
        End If
        ThreeLines()

        Console.WriteLine("Turn the _________knob to enter the house.")
        Console.WriteLine("I love to spend time out_________s, especially in the summer.")
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnswer = strUser
        If strAnswer.ToLower = "door" Then 'Checks if answer right
            intCorrectAnswers += 1 'Adds one to correct counter
        Else
            intIncorrectAnswers += 1 'Adds one to incorrect counter
        End If
        ThreeLines()

        Console.WriteLine("At the amusement park, my favourite ride were the _________ cars.")
        Console.WriteLine("The cars on the highway were lined up _________ to _________.")
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnswer = strUser
        If strAnswer.ToLower = "bumper" Then 'Checks if answer right
            intCorrectAnswers += 1 'Adds one to correct counter
        Else
            intIncorrectAnswers += 1 'Adds one to incorrect counter
        End If
        ThreeLines()

        Console.WriteLine("I saw the rain drips outside my _________.")
        Console.WriteLine("The operating system on my laptop is _________s 11.")
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnswer = strUser
        If strAnswer.ToLower = "window" Then 'Checks if answer right
            intCorrectAnswers += 1 'Adds one to correct counter
        Else
            intIncorrectAnswers += 1 'Adds one to incorrect counter
        End If
        ThreeLines()

        intPointsCounter = intPointsCounter + (intCorrectAnswers * 2) 'Adds correct points
        Console.WriteLine("You got " & intCorrectAnswers & " answer(s) right") 'Number answers right
        Console.WriteLine("You got " & intIncorrectAnswers & " answers wrong") 'Number answers wrong
        Console.WriteLine("Press any key to proceed.")
        Console.ReadKey() 'Waits for user to proceed
        Final()
    End Sub

    Sub Final()
        'Module Variables
        Dim strAnneDecide, strBenDecide, strCharlieDecide As String 'User decisions
        'Program
        intManagementPoints = intPointsCounter 'Totals points for investigation

        Console.Clear() 'Clears the console of previous dialogue
        Console.WriteLine("Read over your notes thoroughly. Once you are done, press any key to proceed.") 'Gives instructions
        ThreeLines()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("-------------------------------------------------------------------------------------")
        Console.WriteLine("VEHICLE MOTOR COLLISION REPORT - OFFICER OBSERVATIONS") 'Gives observations
        Console.WriteLine("ACCIDENT NUMBER: 0X54348-759642-BXYIWAQ")
        Console.WriteLine("-------------------------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("| Anne's car in both the second right and right lane, turned towards the right lane |")
        Console.WriteLine("| Anne car bumper damage, decently severe damage vehicle right side and back        |")
        Console.WriteLine("| Ben car in right lane, facing straight                                            |")
        Console.WriteLine("| Ben car right front damage                                                        |")
        Console.WriteLine("| Charlie car in second right lane, facing straight, hit Anne’s car                 |")
        Console.WriteLine("| Charlie car front pretty damaged                                                  |")
        Console.WriteLine("| Anne claims Ben was about to hit her, so she had to move right.                   |")
        Console.WriteLine("| Anne suspected DUI, alcohol breath                                                |")
        Console.WriteLine("| Ben claims he was driving normally when Anne suddenly hit her.                    |")
        Console.WriteLine("| Charlie says he could not stop his vehicle.                                       |")
        Console.WriteLine("-------------------------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.ReadKey()
        ThreeLines()
        Console.WriteLine("Now, time to make individual decisions. For each person, either...") 'Lets user makes the decisions
        Console.WriteLine("(A) Find that the person has not committed a traffic offence / No Fault")
        Console.WriteLine("(B) Find that the person has committed a minor traffic offence / Citation / Limited Fault")
        Console.WriteLine("(C) Find that the person has committed a significant traffic offence / Arrest / Main Fault")
        Console.WriteLine("")
        Console.WriteLine("(1) Anne") 'Driver Anne
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strAnneDecide = strUser.ToUpper
        If strAnneDecide = "A" Then
            intPointsCounter -= 5 'Wrong choice
        ElseIf strAnneDecide = "B" Then
            intPointsCounter -= 5 'Wrong choice
        ElseIf strAnneDecide = "C" Then
            intPointsCounter += 5 'Right choice
        Else
            intPointsCounter -= 5 'Wrong choice
            Console.WriteLine("Your input is invalid.") 'Invalid Input
            Console.WriteLine("")
        End If

        Console.WriteLine("(2) Ben") 'Driver Ben
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strBenDecide = strUser.ToUpper
        If strBenDecide = "A" Then
            intPointsCounter += 5 'Right choice
        ElseIf strBenDecide = "B" Then
            intPointsCounter -= 5 'Wrong choice
        ElseIf strBenDecide = "C" Then
            intPointsCounter -= 5 'Wrong choice
        Else
            intPointsCounter -= 5 'Wrong choice
            Console.WriteLine("Your input is invalid.") 'Invalid Input
            Console.WriteLine("")
        End If

        Console.WriteLine("(3) Charlie") 'Driver Charlie
        Console.ForegroundColor = ConsoleColor.Red
        strUser = Console.ReadLine() 'Reads user's input
        Console.ForegroundColor = ConsoleColor.White
        strCharlieDecide = strUser.ToUpper
        If strCharlieDecide = "A" Then
            intPointsCounter -= 5 'Wrong choice
        ElseIf strCharlieDecide = "B" Then
            intPointsCounter += 5 'Right choice
        ElseIf strCharlieDecide = "C" Then
            intPointsCounter -= 5 'Wrong choice
        Else
            intPointsCounter -= 5 'Wrong choice
            Console.WriteLine("Your input is invalid.") 'Invalid Input
            Console.WriteLine("")
        End If

        intDecisionPoints = intPointsCounter - intManagementPoints 'Sets decision points

        ThreeLines()
        Results()
    End Sub

    Sub Results()
        'Program
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Ben was driving his vehicle around the speed limit in the second to right lane.") 'User outcome
        Console.WriteLine("Anne’s car then crashed from the left of Ben, pushing Ben’s car into the right lane.")
        Console.WriteLine("This was caused since Anne was drunk and did not maintain her lane.")
        Console.WriteLine("Anne also lied since Ben’s car was straight.")
        Console.WriteLine("Charlie was speeding in the second to right lane and hit Anne’s vehicle.")
        Console.WriteLine("This explains severe damage where Charlie hit Anne.")
        Console.ForegroundColor = ConsoleColor.White
        ThreeLines()

        Console.WriteLine("You got a total of " & intPointsCounter & "/" & intMaxPoints & " points.") 'User game stats
        Console.WriteLine(intManagementPoints & "/" & (intMaxPoints - 15) & " points came from investigating.")
        Console.WriteLine(intDecisionPoints & "/15 points came from your decisions.")
        If intMaxPoints = intPointsCounter Then 'If best outcome
            Console.WriteLine("Good job! You earned the maximum points possible.")
        ElseIf intPointsCounter < 18 Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("For your poor police conduct, you are FIRED from the police force.")
            Console.ForegroundColor = ConsoleColor.White
        Else
            Console.WriteLine("Can you do better next time?")
        End If
        ThreeLines()

        Console.WriteLine("Press any key to go to the main menu.")
        Console.ReadKey() 'Waits for user to proceed

    End Sub

End Module