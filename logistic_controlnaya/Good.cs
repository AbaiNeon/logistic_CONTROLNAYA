using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace logistic_controlnaya
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Good()
        {
            Orders = new List<Order>();
        }
    }
}
