﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSixCSharp
{
    interface IFileParser
    {
        string[] Read(string path);
    }
}
