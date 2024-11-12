// We will design a program using arithmetic operators and a
// “for” loop to calculate the factorial number. The program
// will ask the user to enter a number and return the factorial of the number.

// First, write the following code in the main function:
// request the user to put in a non-negative integer that
// can be used to calculate its factorial.
// Convert the user input from string to integer, validate the user input, make sure it is a non-negative integer, and call the CalculateFactorial function to perform the calculation.

using System;

namespace NumericOperatorsandRoutines
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative integar to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            // validate the input
            if (number < 0)
            {
                Console.WriteLine("Please enter a non-negative integar");
            }
            else
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"The factorial of {number} is: {factorial}");
            }
        }
        // Implement the CalculateFactorial function with a for loop and add the function below the main function. 
        static long CalculateFactorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i ++)
            {
                result *= i; // Multiply result by i, demonsrating the use ofarithmetic operator
            }   
            return result;
        }

    }
}
// Execute the code and click the triangle button from the top right. The expected output:
