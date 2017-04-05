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
            //ucitaj adrese i pripadajuce međusobne udaljenosti
            Address origin = new Address("Karlovac");
            Trip.GetInstance().Initialize(origin, "addresses.txt", 3);
            //organiziraj put
            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());
            //ispisi plan puta
            Console.WriteLine(Trip.GetInstance().Plan.ToString());
            
            Console.ReadKey();
        }

    }


}
