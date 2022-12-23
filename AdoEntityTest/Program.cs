using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection con = new DbConnection();
            con.DeleteUser();
            Console.WriteLine($"DB connection Done ");
            Console.Read();
        }
    }
}
