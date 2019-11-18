using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class RemoveCharacter
    {
        public string CharacterRemove(string catalogCollection, string text)
        {
            StringBuilder builder = new StringBuilder(text);
            foreach (var item in catalogCollection)
            {
                builder.Replace(item + "", "");
            }
            return builder.ToString();
        }
    }
}
