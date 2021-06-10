using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using FakeItEasy;
using System.Text;

namespace IntroductionTraining
{
    class CaluculatorTest
    {
        static void Main(string[] args)
        {
            bool CalacAgain = true;
            string a = string.Empty;
            do
            {
                do
                {
                    string input1 = "";
                    string input2 = "";
                    double num1 = 0;
                    double num2 = 0;

                    //----- Asking  user to type the first number----
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please enter a number : ");
                    Console.WriteLine(" ------------------ ");
                    Console.ResetColor();
                    input1 = Console.ReadLine();
                    double.TryParse(input1, out num1);

                    //--- repeat asking if the input is not a number------

                    while (!double.TryParse(input1, out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Not valid Number, please try again: ");
                        Console.ResetColor();
                        input1 = Console.ReadLine();
                    }

                    //------ Asking for Second number input-------------
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please enter your second number: ");
                    Console.WriteLine(" -------------------- ");
                    Console.ResetColor();
                    input2 = Console.ReadLine();
                    double.TryParse(input2, out num2);

                    //----- repeat asking if the input is not a number-------

                    while (!double.TryParse(input2, out num2))
                    {
                        Console.WriteLine("Not valid Number, please try again: ");
                        input2 = Console.ReadLine();
                    }
                    //-------------- Ask the user to choose an option.--------------

                    Console.WriteLine("Please Choose an option from the following list:");
                    Console.WriteLine(" 1 - Addition");
                    Console.WriteLine(" 2 - Subtract");
                    Console.WriteLine(" 3 - Multiply");
                    Console.WriteLine(" 4 - Divide");
                    Console.WriteLine(" ------------------ ");

                    double selection = Convert.ToDouble(Console.ReadLine());

                    //--------------if statment to give attention with Zero input----------

                    if (num2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This operation can't calculting due to Zero input as the second number.\n");
                        Console.ResetColor();
                        break;
                    }
                    //------------------Switch function--------------------------------

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine(" ");
                            Console.WriteLine("Your result is: " + Addition(num1, num2));
                            break;
                        case 2:
                            Console.WriteLine(" ");
                            Console.WriteLine("Your result is: " + Subtract(num1, num2));
                            break;
                        case 3:
                            Console.WriteLine(" ");
                            Console.WriteLine("Your result is: " + Multiply(num1, num2));
                            break;
                        case 4:
                            Console.WriteLine(" ");
                            Console.WriteLine("Your result is: " + Divide(num1, num2));
                            break;

                        default:
                            Console.WriteLine("Please input again");
                            break;
                    }
                    a = Console.ReadLine();

                } while (a == "y");

                //----------------Give Option to choose if user want calculate again---------------------------------
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to calculate again?  (y/n): ");
                Console.ResetColor();
                string ContinueOp = Console.ReadLine();

                if (ContinueOp.ToLower() == "n")
                {
                    CalacAgain = false;
                }

            } while (CalacAgain);
        }//end of Main

        //-------------start to build our method--------------------------

        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
























