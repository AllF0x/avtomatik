using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSigmaAutomat
{
    internal class Coffee: Drink
    {
        public double water { private get; set; }
        public double coffee { private get; set; }
        public double milk { private get; set; }
        public double sugar { private get; set; }
    }
}
