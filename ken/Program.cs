using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string questionText = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: ";

            while (true)
            {
                int rnr1 = random.Next(0, 11);
                int rnr2 = random.Next(0, 11);
                bool answer = false;

                Console.Write(questionText);
                string chosenType = Console.ReadLine();

                if (chosenType == "+")
                {
                    int randomSum = rnr1 + rnr2;
                    string question = "Vad blir summan av " + rnr1 + " + " + rnr2 + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string kalle = Console.ReadLine();

                        if (kalle == Convert.ToString(randomSum))
                        {
                            Console.WriteLine("Korrekt!");
                            answer = true;
                        }
                        else
                            Console.WriteLine("Försök en gång till. " + question);
                    }
                }
                else if (chosenType == "-")
                {
                    int randomSum = rnr1 - rnr2;
                    string question = "Vad blir summan av " + rnr1 + " - " + rnr2 + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string kalle = Console.ReadLine();

                        if (kalle == Convert.ToString(randomSum))
                        {
                            Console.WriteLine("dixies");
                            answer = true;
                        }
                        else
                            Console.WriteLine("Försök en gång till. " + question);
                    }
                }
                else if (chosenType == "*")
                {
                    int randomSum = rnr1 * rnr2;
                    string question = "Vad blir summan av " + rnr1 + " * " + rnr2 + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string kalle = Console.ReadLine();

                        if (kalle == Convert.ToString(randomSum))
                        {
                            Console.WriteLine("dixies");
                            answer = true;
                        }
                        else
                            Console.WriteLine("Försök en gång till. " + question);
                    }
                }
                else if (chosenType == "/")
                {
                    int randomSum = rnr1 / rnr2;
                    string question = "Vad blir summan av " + rnr1 + " / " + rnr2 + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string kalle = Console.ReadLine();

                        if (kalle == Convert.ToString(randomSum))
                        {
                            Console.WriteLine("dixies");
                            answer = true;
                        }
                        else
                            Console.WriteLine("Försök en gång till. " + question);
                    }
                }
                else if (chosenType == "q")
                {
                    break;
                }
            }
        }
    }
}
