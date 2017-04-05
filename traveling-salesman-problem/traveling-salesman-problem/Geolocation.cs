using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{

    class Geolocation
    {

        public Geolocation(float latitude, float longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public float Latitude { get; }
        public float Longitude { get; }

    }


}
