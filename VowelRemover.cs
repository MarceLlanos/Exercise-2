using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class VowelRemover: IAddToCatalog
    {
        Catalog catalogN = new Catalog();


        public string GetCatalog()
        {
            return "aeiouAEIUO";
        }

        public string RemoveNEsp(string text)
        {
            StringBuilder builder = new StringBuilder(text);
            var n = catalogN.GetCatalog();
            foreach (var item in n)
            {
                builder.Replace(item + "", "");
            }

            return builder.ToString();
        }

        public string RemoveVowels(string text)
        {
            StringBuilder builder = new StringBuilder(text);
            var catalog = GetCatalog();


            foreach (var item in catalog)
            {
                builder.Replace(item + "", "");
            }

            return builder.ToString();
        }
    }
}
