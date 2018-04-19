using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace logistic_controlnaya
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Cars ()
        {
            Orders = new List<Order>();
        }
    }
}
