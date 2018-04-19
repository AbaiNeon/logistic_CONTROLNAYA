using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_controlnaya
{
    public class Route
    {
        public ICollection<Marker> Points { get; set; }
        public Route()
        {
            Points = new List<Marker>();
        }

        public string GetRoute()
        {
            string result = "";

            foreach (var item in Points)
            {
                result = result + item.Name + " - ";
            }

            return result;
        }
    }
}