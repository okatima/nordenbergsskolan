# coding=utf-8+
from random import randrange
questionText = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: "
chosenType = input(questionText)

while chosenType != "q":
    if chosenType == "+":
        number1 = randrange(0, 11)
        number2 = randrange(0, 11)
        randomSum = number1 + number2
        answer = False
        question = "Vad blir summan av " + str(number1) + " + " + str(number2) + "? "
        while answer == False:
            userSum = input(question)
            #print(userSumum)
            #print(answer)
            if int(userSum) == randomSum:
                print("Rätt - bra jobbat!")
                answer = True
            else:
                print("Försök en gång till. " + question)
    else:
        chosenType = input(questionText)
    chosenType = input(questionText)