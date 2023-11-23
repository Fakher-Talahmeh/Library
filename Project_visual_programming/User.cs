using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Visual_programming
{
    public class User
    {
        public string name { get; set; }
        public string ID { get; set; }
        public bool VerifyUser(User user)
        {
            return false;
        }

        public bool CheckAccount(Account account)
        {
            return false;
        }

        public Book GetBookInfo(Book book)
        {
            return book; ;
        }
    }
}
