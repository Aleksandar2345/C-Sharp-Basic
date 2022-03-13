using System;

namespace Homework_class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number");
            int firstNumber;
            bool success = int.TryParse(Console.ReadLine(), out firstNumber);
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
            int secondNumber;
            bool successSecond = int.TryParse(Console.ReadLine(), out secondNumber);
            if (successSecond) 
            {
                Console.WriteLine($"You have entered number {secondNumber} as your second number");
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Please enter the operation you would like to be done ( +, - , * , / ) ");
            string arithmeticOperator = Console.ReadLine();
            double result;
            bool successThird = arithmeticOperator == "*" || arithmeticOperator == "/" || arithmeticOperator == "+" || arithmeticOperator == "-";
            if (successThird)
            {
                Console.WriteLine($"You have entered artithmetical operator {arithmeticOperator} as your operator");

                if (arithmeticOperator == "+")
                {
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"The result of {firstNumber} {arithmeticOperator} {secondNumber} is {result}");
                }
                else if (arithmeticOperator == "-")
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"The result of {firstNumber} {arithmeticOperator} {secondNumber} is {result}");
                }
                else if (arithmeticOperator == "*")
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The result of {firstNumber} {arithmeticOperator} {secondNumber} is {result}");
                }
                else if (arithmeticOperator == "/")
                {
                    result = (firstNumber + 0.00) / secondNumber;
                    Console.WriteLine($"The result of {firstNumber} {arithmeticOperator} {secondNumber} is {result}");
                }

            }
            else
            {
                Console.WriteLine("Please enter an operator");
                return;
            }
                       
        }
    }
}
