using System;

namespace SwapNumbers
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

            double newFirstNumber = firstNumber;
            double secondNumber;
            bool successTwo = double.TryParse(Console.ReadLine(), out secondNumber);
            if (successTwo)
            {
                Console.WriteLine($"You have entered number {secondNumber} as your second number");
                firstNumber = secondNumber;
                Console.WriteLine($"The first number after swaping is {firstNumber}");
                
                secondNumber = newFirstNumber;
                Console.WriteLine($"The second number after swaping is {secondNumber}");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }
        
                  
        }
    }
}
