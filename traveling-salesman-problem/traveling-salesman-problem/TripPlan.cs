using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class TripPlan : HasDistance
    {
        public List<Route> RouteList { get;  }

        public void AddRoute(Route r)
        {
            RouteList.Add(r);
        }

        public TripPlan()
        {
            RouteList = new List<Route>();
        }
        public TripPlan(List<Route> routeList)
        {
            RouteList = routeList;
        }
        public int GetDistance()
        {
            int totalDistance = 0;
            foreach(Route r in RouteList)
            {
                totalDistance += r.GetDistance();
            }
            return totalDistance;
        }

        public override string ToString()
        {
           string s = "\nTripPlan:";
           foreach(Route r in this.RouteList)
            {
                s += r.ToString();
            }
            s += "\nTotal distance= " + GetDistance();
            return s;
        }
    }
}
