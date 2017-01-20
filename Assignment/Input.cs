using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Input
    {
        /// <summary>
        /// Gets a valid row number
        /// </summary>
        /// <param name="message"></param>
        /// <returns>RowNumber as an index (-1 on input number)</returns>
        public static int GetRowNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string row = Console.ReadLine();

                //Quit on 99
                if (row == "99")
                {
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                }
                else
                //Actually run the code
                {
                    int rowNumber;
                    if (Int32.TryParse(row, out rowNumber))
                    {
                        if (rowNumber > 10 || rowNumber < 0)
                        {
                            Console.WriteLine("Please enter a valid number");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Correct Number");
                            //Returns the row number as an index (starting from 0, so knock 1 off)
                            return rowNumber - 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                        continue;
                    }
                }

                
            }
        }

        /// <summary>
        /// Gets a column number from a text input
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int GetColumnNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string column = Console.ReadLine();

                switch (column.ToLower())
                {
                    case "a":
                        return 0;
                    case "b":
                        return 1;
                    case "c":
                        return 2;
                    case "d":
                        return 3;
                    case "e":
                        return 4;
                    case "f":
                        return 5;
                    case "99":
                        Console.WriteLine("Bye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid column");
                        continue;
                        
                }
            }
        }

        public static string GetName()
        {
            while (true)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                //Check if name is valid
                if (name.Replace(" ", String.Empty) != "")
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Please enter something in the name box");
                    continue;
                }
            }
            
            
        }
    }
}
