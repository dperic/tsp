using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //ucitaj adrese
            Trip.getInstance().Initialize(new Address("nesto"), "addresses.txt", 1);
            //set adres distances

            //organiziraj put
            Console.ReadKey();
        }
    }
}
