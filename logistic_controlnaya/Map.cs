using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_controlnaya
{
    public class Map
    {
        public ICollection<Marker> Markers { get; set; }
        public ICollection<Route> Routes { get; set; }
        public Map()
        {
            Markers = new List<Marker>();
            Routes = new List<Route>();
        }

        public void AddMarker(Marker marker)
        {
            Markers.Add(marker);
        }

        public void AddRoute(Route route)
        {
            Routes.Add(route);
        }
    }
}
