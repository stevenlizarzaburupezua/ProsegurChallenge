using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Seedwork
{
    public class Filter<T>
    {
        public Pager Pagination { get; set; }

        public List<Func<T, bool>> Conditions { get; set; }

 
    }
}
