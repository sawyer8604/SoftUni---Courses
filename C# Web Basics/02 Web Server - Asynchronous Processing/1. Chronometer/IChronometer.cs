﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronometer
{
    public interface IChronometer
    {
       
        List<string> Laps { get; }

        void Start();
        void Stop();
        string Lap();

        void Reset();
    }
}
