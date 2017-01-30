package se.nordenberg.application.math;

import java.util.Random;
import java.util.Scanner;

/**
 * Copyright OKATIMA - 2017
 * File created 25 jan. 2017
 * Author: Magnus Goransson
 * info@okatima.se
 * 
 */

public class MathematicTrainer
{
  private final String MENUE_TEXT = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: ";
  private final String SELECT_LEVEL = "Välj nivå - lätt, medel, utmaning, grymt!";
  private final String CORRECT_ANSWER_TEXT = "Rätt - bra jobbat!";
  private final String WRONG_ANSWER_TEXT = "Försök en gång till. ";
  
  //Constructor
  public MathematicTrainer()
  {
  }
  
  public void startMainApplication()
  {
    System.out.println(MENUE_TEXT);
    Scanner scanner = new Scanner(System.in);
    String chosenType = scanner.next();
    
    while(!chosenType.equals("q"))
    {
      System.out.println(SELECT_LEVEL);
      String chosenLevel = scanner.next();
      int level = matchLevel(chosenLevel);
      while(level > 0)
      {
        int number1 = generateRandom(level);
        int number2 = generateRandom(level);
        String question = generateQuestion(Integer.toString(number1), Integer.toString(number2), chosenType);
        while(level > 0)
        {
          System.out.println(question);
          String answer = scanner.next();
          try
          {
            int intAnswer = Integer.parseInt(answer);
            if(checkAnswer(number1, number2, intAnswer, chosenType))
            {
              System.out.println(CORRECT_ANSWER_TEXT);
              System.out.println(MENUE_TEXT);
              chosenType = scanner.next();
              level = 0;
            }
            else
              System.out.println(WRONG_ANSWER_TEXT);
          }
          catch(Exception e)
          {
            System.out.println("Du skrev in ett felaktigt tecken");
          }
        }
      }
    }
    scanner.close();
  }
  
  //Match the level to int
  private int matchLevel(String level)
  {
    int intLevel = 0;
    switch (level)
    {
      case "lätt":
        intLevel = 1;
        break;
      //...
      default:
        intLevel = 0;
        break;
    }
    return intLevel;
  }
  
  //Check if the answer is correct
  private boolean checkAnswer(int number1, int number2, int answer, String arithmeticType)
  {
    switch (arithmeticType)
    {
      case "+":
        return addition(number1, number2, answer);
  
      //...

      default:
        return false;
    }
  }
  
  //Generate random
  private int generateRandom(int level)
  {
    Random rand = new Random();
    int max = 0;
    switch (level)
    {
      case 1:
        max = 10;
        break;
      case 2:
        max = 25;
        break;
      //...
      default:
        max = 0;
        break;
    }
    int random = rand.nextInt(max); 
    return random;
  }
  
  //Concatenate the text for question
  private String generateQuestion(String number1, String number2, String arithmeticType)
  {
    String type = "";
    switch (arithmeticType)
    {
      case "+":
        type = " summan ";
        break;
      //...
      default:
        break;
    }
    return "Vad blir" + type + "av " + number1 + " " + arithmeticType + " " + number2;
  }
  
  //Method handling addition
  private boolean addition(int number1, int number2, int response)
  {
    try
    {
      if(number1 + number2 == response)
        return true;
      else
        return false;
    }
    catch(Exception e)
    {
      return false;
    }
  }
  
  //Main method
  public static void main(String[] args)
  {
    MathematicTrainer mathematicTrainer = new MathematicTrainer();
    mathematicTrainer.startMainApplication();
  }
}
