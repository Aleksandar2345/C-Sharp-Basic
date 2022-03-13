using System;

namespace _AverageNumber_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter your first number");
            double firstNumber;
            bool success = double.TryParse(Console.ReadLine(), out firstNumber);
            if (success)
            {
                Console.WriteLine($"You have entered number {firstNumber} as your first number");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Please enter your second number");
            double secondNumber;
            bool successTwo = double.TryParse(Console.ReadLine(), out secondNumber);
            if (successTwo)
            {
                Console.WriteLine($"You have entered number {secondNumber} as your second number");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Please enter your third number");
            double thirdNumber;
            bool successThree = double.TryParse(Console.ReadLine(), out thirdNumber);
            if (successThree)
            {
                Console.WriteLine($"You have entered number {thirdNumber} as your third number");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }


            Console.WriteLine("Please enter your fourth number");
            double fourthNumber;
            double result;
            bool successFour = double.TryParse(Console.ReadLine(), out fourthNumber);
            if (successFour)
            {
                Console.WriteLine($"You have entered number {fourthNumber} as your fourth number");
                result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                Console.WriteLine($"The average value from {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is {result}");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }

        }
    }
}
