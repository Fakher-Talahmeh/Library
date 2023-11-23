using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Visual_programming
{
    public class Librarian
    {
        public string name { get; set; }
        public string ID { get; set; }
        public string password { get; set; }
        public string searchString { get; set; }
        public bool VerifyLibrarian(Librarian librarian)
        {
            return false;
        }
        public string Search() {
            return searchString;
        }
    }
}
