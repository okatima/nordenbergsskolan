using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstlimit = 1;
            int secondlimit = 10;
            int firstValue = 0;
            int secondValue = 0;
            int correct = 0;
            int answer = 1;
            string stringAnswer = "";
            Random rnd = new Random();
            while (true)
            {

                Console.Write("Välj räknesätt (+, -, /, *): ");
                string Option = Console.ReadLine();

                Console.Write("Välj svårighetsgrad (easy, medium, hard): ");
                string diff = Console.ReadLine();

                Console.WriteLine("Skriv q för att återgå, skriv qqq för att avsluta helt.");
                Console.WriteLine("");

                if (diff == "easy")
                {
                    firstlimit = 1;
                    secondlimit = 11;
                }
                else if (diff == "medium")
                {
                    firstlimit = 10;
                    secondlimit = 101;
                }
                else if (diff == "hard")
                {
                    firstlimit = 100;
                    secondlimit = 1001;
                }

                if (Option == "+")
                {
                    while (true)
                    {
                        firstValue = rnd.Next(firstlimit, secondlimit);
                        secondValue = rnd.Next(firstlimit, secondlimit);
                        correct = firstValue + secondValue;
                        Console.Write(firstValue + " + " + secondValue + " = ");
                        stringAnswer = Console.ReadLine();
                        if (int.TryParse(stringAnswer, out answer))
                        {
                            if (answer == correct)
                                Console.WriteLine("Rätt svar!");
                            else
                                Console.WriteLine("Fel svar!");
                        }
                        else if (stringAnswer == "q")
                        {
                            break;
                        }
                        else if (stringAnswer == "qqq")
                        {
                            Environment.Exit(0);
                        }
                        else
                            Console.WriteLine("Fel input, Skriv endast siffror!");

                    }
                }
                else if (Option == "-")
                {
                    while (true)
                    {
                        firstValue = rnd.Next(firstlimit, secondlimit);
                        secondValue = rnd.Next(firstlimit, secondlimit);
                        correct = firstValue - secondValue;
                        Console.Write(firstValue + " - " + secondValue + " = ");
                        stringAnswer = Console.ReadLine();
                        if (int.TryParse(stringAnswer, out answer))
                        {
                            if (answer == correct)
                                Console.WriteLine("Rätt svar!");
                            else
                                Console.WriteLine("Fel svar!");
                        }
                        else if (stringAnswer == "q")
                        {
                            break;
                        }
                        else if (stringAnswer == "qqq")
                        {
                            Environment.Exit(0);
                        }
                        else
                            Console.WriteLine("Fel input, Skriv endast siffror och - !");

                    }
                }
                else if (Option == "/")
                {
                    while (true)
                    {
                        firstValue = 5;
                        secondValue = 2;
                        while (firstValue % secondValue != 0)
                        {
                            firstValue = rnd.Next(firstlimit, (secondlimit + 50));
                            secondValue = rnd.Next(firstlimit, firstValue);
                        }
                        correct = firstValue / secondValue;
                        Console.Write(firstValue + " / " + secondValue + " = ");
                        stringAnswer = Console.ReadLine();
                        if (int.TryParse(stringAnswer, out answer))
                        {
                            if (answer == correct)
                                Console.WriteLine("Rätt svar!");
                            else
                                Console.WriteLine("Fel svar!");
                        }
                        else if (stringAnswer == "q")
                        {
                            break;
                        }
                        else if (stringAnswer == "qqq")
                        {
                            Environment.Exit(0);
                        }
                        else
                            Console.WriteLine("Fel input, Skriv endast siffror!");

                    }
                }
                else if (Option == "*")
                {
                    while(true)
                    {
                        firstValue = rnd.Next(firstlimit, secondlimit);
                        secondValue = rnd.Next(firstlimit, secondlimit);
                        correct = firstValue * secondValue;
                        Console.Write(firstValue + " * " + secondValue + " = ");
                        stringAnswer = Console.ReadLine();
                        if (int.TryParse(stringAnswer, out answer))
                        {
                            if (answer == correct)
                                Console.WriteLine("Rätt svar!");
                            else
                                Console.WriteLine("Fel svar!");
                        }
                        else if(stringAnswer == "q")
                        {
                            break;
                        }
                        else if (stringAnswer == "qqq")
                        {
                            Environment.Exit(0);
                        }
                        else
                            Console.WriteLine("Fel input, Skriv endast siffror!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Fel input: " + Option + " " + diff);
                }
            }
        }
    }
}
