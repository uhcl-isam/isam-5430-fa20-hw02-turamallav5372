using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {

        public static void Main()
        {
           

            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());
        }

            const string STAR = "*";
            const string SPACE = " ";
            const int COUNTER = 10;

            static void Main(string[] args)
            {
                DisplayA();
                DisplayB();
                DisplayC();
                DisplayD();

                Console.ReadLine();
            }

            static public void DisplayA()
            {
                int index = 0;
                int c = 0;
                for (index = 0; index < COUNTER; index++)
                {
                    for (c = 0; c <= index; c++)
                        Console.Write(STAR);

                    Console.WriteLine();    //new line after each row
                }
                Console.WriteLine();    //new line after pattern
            }

            static public void DisplayB()
            {
                int index = 0;
                int c = 0;

                for (index = 0; index < COUNTER; index++)
                {
                    for (c = 0; c < index; c++)
                        Console.Write(SPACE);

                    for (c = 0; c < COUNTER - index; c++)
                        Console.Write(STAR);

                    Console.WriteLine();    //new line after each row
                }
                Console.WriteLine();    //new line after pattern

            }

            static public void DisplayC()
            {

                int index = 0;
                int c = 0;
                for (index = COUNTER; index > 0; index--)
                {
                    for (c = 0; c < index; c++)
                        Console.Write(STAR);

                    Console.WriteLine();    //new line after each row
                }
                Console.WriteLine();    //new line after pattern
            }

            static public void DisplayD()
            {
                int index = 0;
                int c = 0;

                for (index = COUNTER; index >= 0; index--)
                {
                    for (c = 0; c < index; c++)
                        Console.Write(SPACE);

                    for (c = 0; c < COUNTER - index; c++)
                        Console.Write(STAR);

                    Console.WriteLine();    //new line after each row
                }
                Console.WriteLine();    //new line after pattern
            }

        }
    }

    // Write your codes here.
    
        
    