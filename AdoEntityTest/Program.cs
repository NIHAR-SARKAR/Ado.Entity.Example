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
            var result=con.AddUser();
            Console.WriteLine($"DB connection Done {result}");
            Console.Read();
        }
    }
}
