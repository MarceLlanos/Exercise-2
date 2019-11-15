using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class CatalogString : IAddToCatalog, IIsInCatalog
    {
        public CatalogString()
        {
            AddToCatalog();
        }
        public List<string> AddToCatalog()
        {
            List<string> catalog = new List<string>();
            catalog.Add("a");
            catalog.Add("e");
            catalog.Add("i");
            catalog.Add("o");
            catalog.Add("u");
            catalog.Add("A");
            catalog.Add("E");
            catalog.Add("I");
            catalog.Add("O");
            catalog.Add("U");
            return catalog;
        }

        public bool IsInCatalog(string text)
        {
            return AddToCatalog().Contains(text);
        }
    }
}
