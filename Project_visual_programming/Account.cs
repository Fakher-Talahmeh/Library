using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Visual_programming
{
    public class Account
    {
        public int NoBorrowedBooks { get; set; }
        public int NoReservedBooks { get; set; }
        public int NoReturnedBooks { get; set; }
        public int NoLostBooks { get; set; }
        public double FineAmount { get; set; }

        public void CalculateFine()
        {
        }
    }
}
