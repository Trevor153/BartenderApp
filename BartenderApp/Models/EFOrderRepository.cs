using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Order> OrderQueue => context.OrderQueue;
        public void SaveOrder(Order order)
        {
            if (order.ID == 0)
            {
                context.OrderQueue.Add(order);
            }
            else
            {
                Order dbEntry = context.OrderQueue
                .FirstOrDefault(o => o.ID == order.ID);
                if (dbEntry != null)
                {
                    dbEntry.CustomerName = order.CustomerName;
                    dbEntry.ItemID = order.ItemID;
                    dbEntry.IsFulfilled = false;
                }
            }
            context.SaveChanges();
        }
    }
}
