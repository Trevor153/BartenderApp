using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BartenderApp.Models
{
    public class ViewModel
    {
        public IEnumerable<Order> OrderQueue { get; set; }
        public IEnumerable<MenuItem> Menu { get; set; }
        public Order NewOrder { get; set; }
        public int OrderItem { get; set; }
    }
}
