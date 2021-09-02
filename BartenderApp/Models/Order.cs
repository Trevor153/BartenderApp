using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BartenderApp.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public String CustomerName { get; set; }
        public int ItemID { get; set; }
        public bool? IsFulfilled { get; set; }
    }//end class
}//end namespace
