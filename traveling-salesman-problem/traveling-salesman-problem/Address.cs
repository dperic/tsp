using System;

namespace traveling_salesman_problem
{
    class Address
    {
        private Geolocation location;
        public Address(string name)
        {
            Name = name;
            this.location = GoogleDirectionApiClient.RequestDistance(name);
        }

        public String Name { get; }
        public float Latitude
        {
            get
            {
                return this.location.Latitude;
            }
        }
        public float Longitude
        {
            get
            {
                return this.location.Longitude;
            }
        }
    }
}
