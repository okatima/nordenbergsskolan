using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mattematikprogram
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string questionText = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: ";


            while (true)
            {
                int number1 = random.Next(0, 11);
                int number2 = random.Next(0, 11);
                bool answer = false;
                Console.WriteLine(questionText);
                string chosenType = Console.ReadLine();

                if (chosenType == "+")
                {
                    int sum = number1 + number2;
                    string question = "Vad blir summan av " + (number1) + " + " + (number2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string potatis = Console.ReadLine();

                        if (potatis == Convert.ToString(sum))
                        {
                            Console.WriteLine("Bravo du har svarat rätt!");
                            answer = true;
                        }
                    }

                }
                if (chosenType == "-")
                {
                    int sum = number1 - number2;
                    string question = "Vad blir summan av " + (number1) + " - " + (number2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string potatis = Console.ReadLine();

                        if (potatis == Convert.ToString(sum))
                        {
                            Console.WriteLine("Bravo du har svarat rätt!");
                            answer = true;
                        }
                    }

                }
                if (chosenType == "*")
                {
                    int sum = number1 * number2;
                    string question = "Vad blir summan av " + (number1) + " * " + (number2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string potatis = Console.ReadLine();

                        if (potatis == Convert.ToString(sum))
                        {
                            Console.WriteLine("Bravo du har svarat rätt!");
                            answer = true;
                        }
                    }

                }
                if (chosenType == "/")
                {
                    int sum = number1 / number2;
                    string question = "Vad blir summan av " + (number1) + " / " + (number2) + "? ";

                    while (answer == false)
                    {
                        Console.Write(question);
                        string potatis = Console.ReadLine();

                        if (potatis == Convert.ToString(sum))
                        {
                            Console.WriteLine("Bravo du har svarat rätt!");
                            answer = true;
                        }
                    }

                }
                if (chosenType == "q")
                {
                    break;
                }
            }
        }
    }
}
     