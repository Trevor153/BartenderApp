using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BartenderApp.Models
{
    public class FakeMenuRepository : IMenuRepository
    {
        public IEnumerable<MenuItem> Menu => new List<MenuItem> {
            new MenuItem { ID = 1, ItemName = "Bud-Light", ItemDescription = "1.0", ItemPrice = 100 },
            new MenuItem { ID = 2, ItemName = "Corona", ItemDescription = "2.0", ItemPrice = 200 },
            new MenuItem { ID = 3, ItemName = "Samuel Adams", ItemDescription = "3.0", ItemPrice = 300 },
            new MenuItem { ID = 4, ItemName = "Guinness", ItemDescription = "4.0", ItemPrice = 400},
            new MenuItem { ID = 5, ItemName = "Heineken", ItemDescription = "5.0", ItemPrice = 500}
        };
    }
}