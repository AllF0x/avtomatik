﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomatik
{
    abstract class AvtomatBase
    {
        public string name;
        public int cash { get; private set; }
        public int amountSales { get; private set; }
        public int errorstatic { get; private set; }
    }
}
