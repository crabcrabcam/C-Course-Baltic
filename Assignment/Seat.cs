using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Seat
    {
        private string owner = "";
        public bool taken;

        ///Returns the name of the person who occupies the seat
        public override string ToString()
        {
            return owner;
        }

        /// <summary>
        /// Sets the owner name, and the taken value to true
        /// This books the seat
        /// </summary>
        /// <param name="name"></param>
        public void BookSeat(string name)
        {
            taken = true;
            owner = name;
        }
    }
}
