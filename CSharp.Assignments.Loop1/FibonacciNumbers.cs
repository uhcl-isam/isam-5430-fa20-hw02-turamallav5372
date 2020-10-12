using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
            int end = int.Parse(Console.ReadLine());
           

                int input , first = 0, second = 1, third = 0;
                Console.Write("Enter a number : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("First {0} Fibonacci numbers {1} {2} ", input , first, second);

                for (int i = 3; i <= input; i++)
                {
                    third = first + second;
                    Console.Write("{0} ", third);
                    first = second;
                    second = third;
                }


            }

        }
    }

