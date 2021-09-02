﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> OrderQueue { get; }
        void SaveOrder(Order order);
    }
}
