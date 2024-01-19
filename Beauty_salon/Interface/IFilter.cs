using Beauty_salon.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_salon.Interface
{
    internal interface IFilter
    {

        IEnumerable<ExtendedClient> GetFilterAndSort();
        int Count();
    }
}
