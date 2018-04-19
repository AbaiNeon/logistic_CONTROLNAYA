using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace logistic_controlnaya
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Companies> Companies { get; set; }
        public City()
        {
            Companies = new List<Companies>();
        }
    }
}