using System;
using System.Collections.Generic;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers
                List<int> numbersList = new List<int> { 8, 18, 26, 34, 48, 56, 64, 72, 88, 92 };

                // Ask the user for a number to divide each number in the list by
                Console.WriteLine("Enter a number to be divided: ");
                double userInput = Convert.ToDouble(Console.ReadLine());

                // Loop through each integer in the list, divide it by the user's input, and display the result
                foreach (int number in numbersList)
                {
                    double result = number / userInput;
                    Console.WriteLine(number + " divided by " + userInput + " is equal to " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                // Display error message for division by zero
                Console.WriteLine("Please, don't divide by zero.");
            }
            catch (FormatException ex)
            {
                // Display error message for invalid input format
                Console.WriteLine("Please, type a whole number.");
            }
            finally
            {
                // Print a message to indicate that the program has emerged from the try/catch block
                Console.WriteLine("\nAll done, thanks for use it! :)");
            }

            // This line is outside the try/catch block and will be executed regardless of exceptions
            Console.ReadLine();

        }
    }
}













//try
//{
//    Console.WriteLine("Pick a number.");
//    int numberOne = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Pick a second number.");
//    int numberTwo = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("dividing the two...");
//    int numberThree = numberOne / numberTwo;
//    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
//    Console.ReadLine();
//}
//catch(FormatException ex)
//{
//    Console.WriteLine("Please, type a whole number.");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("Please, don't divide by zero.");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.ReadLine();
//}