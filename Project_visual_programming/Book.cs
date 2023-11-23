using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Visual_programming
{
    public class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime Publication { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Title} - {Author} - {ISBN} - {Publication}";
        }
    }
}
