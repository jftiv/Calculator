using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a calculation (i.e. \"2 + 2\"): ");
                string userString = Console.ReadLine();
                string[] words = userString.Split(' ');

                int firstNum = Convert.ToInt32(words[0]);
                int secondNum = Convert.ToInt32(words[2]);

                NewCalc basicCalculations = new NewCalc();
                AdvCalc advCalculations = new AdvCalc();

                switch (words[1])
                {
                    case "+":
                        Console.WriteLine("{0}", basicCalculations.Add(firstNum, secondNum));
                        break;
                    case "-":
                        Console.WriteLine("{0}", basicCalculations.Sub(firstNum, secondNum));
                        break;
                    case "*":
                        Console.WriteLine("{0}", basicCalculations.Mult(firstNum, secondNum));
                        break;
                    case "/":
                        Console.WriteLine("{0}", basicCalculations.Div(firstNum, secondNum));
                        break;
                    case "^":
                        Console.WriteLine("{0}", advCalculations.Pow(firstNum, secondNum));
                        break;
                    case "abs":
                        Console.WriteLine("{0}", advCalculations.Abs(firstNum, 0));
                        break;
                    default:
                        Console.WriteLine("No operator was passed.");
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured");
                Console.ReadLine();
                throw;
            }
        }
    }
}
