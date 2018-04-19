using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace logistic_controlnaya
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        //public int SenderId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime RecievingDate { get; set; }
        public string Info { get; set; }

        //-----------------------------------------------------------------------------------------------
        public int? SenderId { get; set; }
        public Companies Companies { get; set; }
        //-----------------------------------------------------------------------------------------------
        public int? RecieverId { get; set; }
        
        //-----------------------------------------------------------------------------------------------
        public int? LogisticCompId { get; set; }

        //-----------------------------------------------------------------------------------------------
        public int? CarId { get; set; }
        public Cars Cars { get; set; }
        //-----------------------------------------------------------------------------------------------
        public int? GoodsId { get; set; }
        public Good Good { get; set; }
        //-----------------------------------------------------------------------------------------------

        public void ShowDetails()
        {
            string sender = 
        }
    }
}
