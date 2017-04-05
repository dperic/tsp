using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class Route : HasDistance
    {
        public List<Address> DestinationList { get; }
        public Address LastDestination
        {
            get
            {
                if (DestinationList.Count > 0) return DestinationList.Last();
                else return null;
            }
        }
        public void AddDestination(Address destination)
        {
            DestinationList.Add(destination);
        }


        public Route(Address origin)
        {
            DestinationList = new List<Address>();
            DestinationList.Add(origin);
        }

        public int GetDistance()
        {
            int totalDistance = 0;

            //dodaj udaljenost za svaku sljedecu adresu
            for(int i = 0; i<DestinationList.Count; i++)
            {
                Address currentDestination = DestinationList.ElementAt(i);
                int priorDestinationIndex;
                if(i == 0)
                {
                    //povezi ishodiste i posljednju destinaciju
                    priorDestinationIndex = DestinationList.Count -1;                         
                }else
                {
                    //sve destinacije (osim ishodisne) povezi sa njihovim prethodnicima
                    priorDestinationIndex = i - 1;
                }
                Address priorDestination = DestinationList.ElementAt(priorDestinationIndex);
                totalDistance += currentDestination.GetDistance(priorDestination.Name);
            }
            return totalDistance;
        }
    }
}
