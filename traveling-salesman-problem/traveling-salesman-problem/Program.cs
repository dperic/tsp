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
            Console.WriteLine("Unesite ishodišni grad: ");

            Address origin = new Address(Console.ReadLine());
            Console.WriteLine("Unesite broj vozila: ");
            Trip.GetInstance().Initialize(origin, "addresses.txt", int.Parse(Console.ReadLine()));
            //organiziraj put
            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());
            //ispisi plan puta
            Console.WriteLine(Trip.GetInstance().Plan.ToString());

            Console.ReadKey();
        }

    }


}
