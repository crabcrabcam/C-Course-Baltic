using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate a new board of seats
            Board board = new Board();

            //The looping console app
            while (true)
            {
                Console.WriteLine("The seat layout is:");
                board.ShowSeats();
                board.PickSeat();
            }
            
        }
    }
}
