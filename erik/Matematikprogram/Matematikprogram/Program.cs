using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            string questionText = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: ";
            
            while (true)
            {
                bool answer = false;
                Console.WriteLine(questionText);
                string chosenType = Console.ReadLine();

                int rnr1 = random.Next(0, 11);
                int rnr2 = random.Next(0, 11);
                if (chosenType == "+")
                {
                    int sum = rnr1 + rnr2;
                    string question = "Vad blir summan av " + (rnr1) + " + " + (rnr2) + "? ";

                    while(answer == false)
                    { 
                    Console.Write(question);
                    string blatte = Console.ReadLine();

                        if (blatte == Convert.ToString(sum))
                        {
                            Console.WriteLine("Korrekt svar!");
                            answer = true;
                        }
                        

                    }

                }
                if (chosenType == "-")
                {
                    int sum = rnr1 - rnr2;
                    string question = "Vad blir summan av " + (rnr1) + " - " + (rnr2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string blatte = Console.ReadLine();

                        if (blatte == Convert.ToString(sum))
                        {
                            Console.WriteLine("Korrekt svar!");
                            answer = true;
                        }


                    }

                }
                if (chosenType == "*")
                {
                    int sum = rnr1 * rnr2;
                    string question = "Vad blir summan av " + (rnr1) + " * " + (rnr2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string blatte = Console.ReadLine();

                        if (blatte == Convert.ToString(sum))
                        {
                            Console.WriteLine("Korrekt svar!");
                            answer = true;
                        }


                    }

                }
                if (chosenType == "/")
                {
                    int sum = rnr1 / rnr2;
                    string question = "Vad blir summan av " + (rnr1) + " / " + (rnr2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string blatte = Console.ReadLine();

                        if (blatte == Convert.ToString(sum))
                        {
                            Console.WriteLine("Korrekt svar!");
                            answer = true;
                        }


                    }

                } if (chosenType == "q")
                {
                    break;
                }
                
            }
        }

    }
}
