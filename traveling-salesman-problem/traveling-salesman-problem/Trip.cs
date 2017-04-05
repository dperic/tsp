using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class Trip
    {
        private static Trip instance = null;
        private char addressSeparator = ';';

        private Trip(){
            this.AddressList = new List<Address>();
        }

        public static Trip getInstance()
        {
            if (instance == null) instance = new Trip();
            return instance;
        }

        public Address Start { get; set; }
        public List<Address> AddressList { get; set; }
        public int VehicleCount { get; set; }

        public void Initialize(Address startAddress, string addressFile, int vehicleCount)
        {
            this.Start = startAddress;
            LoadAddresses(addressFile);
            SetAddressDistances();
            this.VehicleCount = vehicleCount;
        }

        private void LoadAddresses(string path)
        {
            //TODO: implementiraj
            Console.WriteLine("LoadAddresses()");
            string addressesRaw = TxtFileHelper.LoadText(path);
            string[] addressesString = addressesRaw.Split(this.addressSeparator);

            foreach (string address in addressesString)
            {
                if (address.Length > 0)
                {
                    //kreiraj objekt klase Address sa paremetrom naziva
                    Address a = new Address(address.Trim());
                    //dodaj novokreirani objekt u listu adresa
                    this.AddressList.Add(a);
                }
            }
            Console.WriteLine(this.AddressList.ToString());

        }
        private void SetAddressDistances()
        {
            //TODO: implementiraj
            Console.WriteLine("SetAddressDistances()");
        }
    

    }
}
