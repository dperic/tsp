using GoogleMapsApi.Entities.DistanceMatrix.Request;
using GoogleMapsApi.Entities.DistanceMatrix.Response;
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
        
        public static int RequestDistance(string origin, string destination) 
        {
            DistanceMatrixRequest request = new DistanceMatrixRequest()
            {
                Origins = new string[] {origin},
                Destinations = new string[] {destination}
            };
            DistanceMatrixResponse response = GoogleMapsApi.GoogleMaps.DistanceMatrix.Query(request);
            int distance = response.Rows.ElementAt(0).Elements.ElementAt(0).Distance.Value;
            return distance;
        }
        
    }
}
