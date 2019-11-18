using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class CharacterRemover
    {
        public string RemoveCharacter(string collectionCatalog, string text)
        {
            StringBuilder builder = new StringBuilder(text);
            foreach (var item in collectionCatalog)
            {
                builder.Replace(item + "", "");
            }
            return builder.ToString();
        }
    }
}
