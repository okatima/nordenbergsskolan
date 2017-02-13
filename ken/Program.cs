using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematics
{

    class Program
    {
        public static double Operator(string op, double x, double y)
        {
            switch (op)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: throw new Exception("invalid logic");
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                bool correct = false;
                string answer;
                double nr1 = random.Next(1, 11);
                double nr2 = random.Next(1, 11);
                double Sum;
                string questionText = "Välj räknesätt + (addition) - (subtraktion) / (division) * (multiplikation). För att avsluta skriv q: ";

                Console.Write(questionText);
                string op = Console.ReadLine();

                if (op == "+" || op == "-" || op == "*" || op == "/")
                {
                    Sum = Math.Round(Operator(op, nr1, nr2), 2);

                    while (correct == false)
                    {
                        string question = "Vad blir summan av " + nr1 + " " + op + " " + nr2 + " ?";
                        Console.WriteLine(question);
                        answer = (Console.ReadLine());

                        if (Convert.ToDouble(answer) != Sum)
                            Console.WriteLine("Försök en gång till.");

                        else
                        {
                            Console.Write("Korrekt! ");
                            while (true)
                            {
                                Console.WriteLine("En gång till? (ja/nej)");
                                string check = Console.ReadLine();

                                if (check == "nej")
                                {
                                    correct = true;
                                    break;
                                }

                                else if (check == "ja")
                                {
                                    nr1 = random.Next(1, 11);
                                    nr2 = random.Next(1, 11);
                                    Sum = Math.Round(Operator(op, nr1, nr2), 2);
                                }
                            }
                        }
                    }
                }
                else if (op == "q")
                {
                    break;
                }
            }
        }
    }
}
