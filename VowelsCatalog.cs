﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class VowelsCatalog : ICatalog
    {
        public string GetCatalog()
        {
            return "aeiouAEIOU";
        }
    }
}