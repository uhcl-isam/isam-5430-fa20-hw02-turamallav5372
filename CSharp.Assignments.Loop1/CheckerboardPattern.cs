﻿using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app that requires two inputs:
    /// the number of rows/columns and the fill character (char).
    /// The app will then provide output statements to display the
    /// checkerboard pattern that follows. A Console.WriteLine method
    /// call with no arguments outputs a single newline character. 
    /// [Hint: Iteration statements are required.]
    /// <example>
    /// For 8 rows and a fill character of '*', the app will produce
    ///  an 8 by 8 checkerboard as follows:
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// </example>
    /// </summary>
    public class CheckerboardPattern
    {
        public static void Main()
        {
            Console.Write("Enter the number of rows: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fill character: ");
            char fillChar = Char.Parse(Console.ReadLine());
            char space = ' ';
            int index = 1;
            int counter = 1;

            while (index <=8)
            {
                if (index % 2 != 0)
                {
                    while(counter <= 8)
                    {
                        Console.Write(fillChar);
                        counter++;
                    }
                }
                else
                {
                    Console.Write(space);
                    while (counter <= 8)
                    {
                        Console.Write(fillChar);
                        counter++;
                    }
                }
                counter = 1;
                index++;
                Console.WriteLine();
            }
            Console.ReadLine();

            // Write your codes here.
        }
    }
}
