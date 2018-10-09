using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Learn your squares and cubes!");

            while (true)
            {
                int number, square, cube;

                //Prompt user to enter an integer
                Console.WriteLine("Please enter an integer: " + "\n");
                bool userNumber = int.TryParse(Console.ReadLine(), out number);
                
                //Validate input to avoid negative numbers
                if (number <= 0)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }

                //Display a table of squares and cubes from 1 to the value entered

                //Column Headings
                Console.WriteLine("Number          Squared         Cubed");
                Console.WriteLine("========        ========        ========");

                //for loop that creates the table
                for (int i = 1; i <= number; i++)
                {
                    square = i * i;
                    cube = i * i * i;
                    Console.WriteLine("{0, -15:0} {1, -15:0} {2, -15:0}", i, square, cube);
                }

                //Prompt user to continue
                Console.WriteLine("Would you like to continue? Y/N");

                char userAnswer = Console.ReadKey().KeyChar;
                
                if (Char.ToUpper(userAnswer) == 'N')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
