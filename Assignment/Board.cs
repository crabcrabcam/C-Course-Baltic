using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Board
    {
        public Seat[,] board = new Seat[,] {    { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                                { new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), new Seat(), },
                                            };

        /// <summary>
        /// Shows the seats how they should be shown
        /// </summary>
        public void ShowSeats()
        {  
            //Loops through the first stage of the array
            for (int yIndex = 0; yIndex <= 9; yIndex++)
            {
                //Row with number 10 doesn't get an extra space
                if (yIndex == 9)
                {
                    Console.Write(yIndex + 1);
                }
                else
                {
                    Console.Write(" " + (yIndex + 1));
                }
                
                //Loops through the second stage of the array
                for (int xIndex = 0; xIndex <= 5; xIndex++)
                {
                    //Puts the tab in the middle
                    if (xIndex == 3)
                    {
                        Console.Write("   ");
                    }

                    //Checks if the seat is already taken
                    if (!board[yIndex, xIndex].taken)
                    {
                        Console.Write(" " + IntToLetter(xIndex));
                    }
                    else
                    {
                        Console.Write(" X");
                    }
                }
                Console.WriteLine(""); //Blank line for line breaks
            }
        }


        /// <summary>
        /// How the user picks the seat they want
        /// </summary>
        public void PickSeat()
        {
            while (true)
            {
                //Get the index of the seat
                int yIndex = Input.GetRowNumber("Please enter a row or 99 to quit");
                int xIndex = Input.GetColumnNumber("Please enter a column or 99 to quit");

                //If seat isn't taken
                if (!board[yIndex, xIndex].taken)
                {
                    //Book the seat to a name that gets input here
                    string name = Input.GetName();
                    board[yIndex, xIndex].BookSeat(name);
                    break;
                }
                else
                {
                    //Tells the user the seat is taken and asks if they want to know who has it
                    //Maybe they want to go give them a nobbing for "That's my seat"
                    Console.WriteLine("That seat is taken, would you like to see who has it? (y/n)");
                    string answer = Console.ReadLine();
                    //If it's not yes then it's no
                    if (answer.ToLower() != "y")
                    {
                        break;
                    }
                    else
                    {
                        //Tell the user who owns the seat
                        Console.WriteLine(board[yIndex, xIndex].ToString() + " owns this seat.");
                    }
                    //If it gets here then it loops
                    continue;
                }
            }
            
        }

        /// <summary>
        /// Convert a number to the placement of it in the alphabet using 0 as a base for A
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        string IntToLetter(int number)
        {
            switch (number)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                case 5:
                    return "F";
                case 6:
                    return "G";
                case 7:
                    return "H";
                case 8:
                    return "I";
                case 9:
                    return "J";
                    //Defaults to error if it's not between 0-9
                default:
                    return "error";
            }
        }

    }
}
