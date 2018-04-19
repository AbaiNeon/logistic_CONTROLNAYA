using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace logistic_controlnaya
{
    public class Companies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public int CityId { get; set; }
        public string Info { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Companies()
        {
            Orders = new List<Order>();
        }
    }
}
