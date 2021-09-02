using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IMenuRepository
    {
        IEnumerable<MenuItem> Menu { get; }
    }
}
