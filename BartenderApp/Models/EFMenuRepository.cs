using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BartenderApp.Models
{
    public class EFMenuRepository : IMenuRepository
    {
        private ApplicationDbContext context;
        public EFMenuRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<MenuItem> Menu => context.Menu;
    }
}