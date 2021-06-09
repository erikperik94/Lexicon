using System;

namespace MyFirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Continue this program press enter or quit write your name and then Enter.");
                string stopprogram = Console.ReadLine();
                if (stopprogram != "")
                {
                    break;
                }
                Console.WriteLine("By typing 1 you choose to Add two numbers");
                Console.WriteLine("By typing 2 you choose to Substract two numbers");
                Console.WriteLine("By typing 3 you choose to Divide two numbers");
                Console.WriteLine("By typing 4 you choose to Multiply two numbers ");
                int userSelection = GetNumberFromUser("menu selection");

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("You choosed Addition");
                        double Addition = GetAddition();
                        Console.WriteLine(Addition);
                        break;

                    case 2:
                        Console.WriteLine("You choosed Subtraction");
                        double Subtraction = GetSubtraction();
                        Console.WriteLine(Subtraction);
                        break;

                    case 3:
                        Console.WriteLine("You choosed Division");
                        double Division = GetDivision();
                        Console.WriteLine(Division);
                        break;

                    case 4:
                        Console.WriteLine("You choosed Multiplication");
                        double Multiplication = GetMultiplication();
                        Console.WriteLine(Multiplication);
                        break;

                    default:
                        Console.WriteLine("Not in the menu");
                        break;
                }
            }

    }//end of Main


        static int GetNumberFromUser(string forWhat)
        {
            Console.Write("Enter " + forWhat + " number: ");
            string userInput = Console.ReadLine();

            int number = 0;
            int.TryParse(userInput, out number);

            return number;
        }
        static double GetAddition()
        {
            string userInput1 = Console.ReadLine();
            double number1 = 0;
            double.TryParse(userInput1, out number1);

            string userInput2 = Console.ReadLine();
            double number2 = 0;
            double.TryParse(userInput2, out number2);

            double result = 0;

            result = number1 + number2;

            return result;
        }
        static double GetSubtraction()
        {
            string userInput1 = Console.ReadLine();
            double number1 = 0;
            double.TryParse(userInput1, out number1);

            string userInput2 = Console.ReadLine();
            double number2 = 0;
            double.TryParse(userInput2, out number2);
            double result = 0;

            result = number1 - number2;

            return result;
        }
        static double GetDivision()
        {

            string userInput1 = Console.ReadLine();
            double number1 = 0;
            double.TryParse(userInput1, out number1);

            string userInput2 = Console.ReadLine();
            double number2 = 0;
            double.TryParse(userInput2, out number2);
            while (number2 == 0)
            {
                Console.WriteLine("Invalid number 0 for division, ");
                string userInput3 = Console.ReadLine();
                double.TryParse(userInput3, out number2);
                if (number2 != 0)
                {
                    break;
                }
            }
            

                double result = 0;

            result = number1 / number2;

            return result;
        }
        static double GetMultiplication()
        {

            string userInput1 = Console.ReadLine();
            double number1 = 0;
            double.TryParse(userInput1, out number1);

            string userInput2 = Console.ReadLine();
            double number2 = 0;
            double.TryParse(userInput2, out number2);

            double result = 0;

            result = number1 * number2;

            return result;
        }
    }
}
