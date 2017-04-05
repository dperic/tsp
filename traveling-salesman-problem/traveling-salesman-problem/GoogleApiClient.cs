using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class GoogleDirectionApiClient
    {
        private static string apiKey = "AIzaSyCmjTMe0lOytvpcSYLkwdRi4fpQvdanG9o";
        private string api = "https://maps.googleapis.com/maps/api/directions/json";
        private string options = "?origin=Split&destination=Zagreb&key=AIzaSyBQB_fNYxPbyWHYNHpooPzllIqmOPJzVWc";
        
        public static float RequestDistance(string source, string destination)
        {
            return 10;
            
        }

        private string HttpGet(string uri)
        {
            WebClient client = new WebClient();

            return null;
        }
        
    }
}
