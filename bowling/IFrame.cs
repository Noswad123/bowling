﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    interface IFrame
    {
        Throw FirstThrow { get; set; }
        Throw SecondThrow { get; set; }
        bool isSpare();
    }
}
