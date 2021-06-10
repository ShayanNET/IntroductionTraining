using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionTraining
{
    class WeightConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your you weight? ");

            string input1 = Console.ReadLine();
            double Result;
            bool TGPA = double.TryParse(input1, out Result);

            while (TGPA == false)
            {
                Console.WriteLine("{0} is not a valid number, dont please try again", input1);
                input1 = Console.ReadLine();
                TGPA = double.TryParse(input1, out  Result);
            }

            Console.WriteLine("Please enter your unit (k) kg , (L)bs? ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "k")
            {
                double kilo = Result / 0.453;
                Console.WriteLine("Your weight in lbs is " + kilo);

            }
            else if (answer.ToLower() == "l")
            {
                double kilo = Result * 0.453;
                Console.WriteLine("Your weight in kg is " + kilo);
            }
            Console.ReadLine();

            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();

        }
    }
}
