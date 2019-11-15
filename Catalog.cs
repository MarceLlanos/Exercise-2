using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Catalog : IAddToCatalog
    {
        public string GetCatalog()
        {
            return "n ";
        }
    }
}
