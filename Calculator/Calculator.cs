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
                string ab = Console.ReadLine();
                string[] words = ab.Split(' ');

                int aw = Convert.ToInt32(words[0]);
                int bw = Convert.ToInt32(words[2]);

                newCalc jc = new newCalc();
                advCalc adc = new advCalc();

                switch (words[1])
                {
                    case ("+"):
                        Console.WriteLine("{0}", jc.Add(aw, bw));
                        break;
                    case ("-"):
                        Console.WriteLine("{0}", jc.Sub(aw, bw));
                        break;
                    case ("*"):
                        Console.WriteLine("{0}", jc.Mult(aw, bw));
                        break;
                    case ("/"):
                        Console.WriteLine("{0}", jc.Div(aw, bw));
                        break;
                    case ("^"):
                        Console.WriteLine("{0}", adc.Pow(aw, bw));
                        break;
                    case ("abs"):
                        Console.WriteLine("{0}", adc.Abs(aw, 0));
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
