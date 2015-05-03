using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_cutter
{
    class Configuration
    {
        public double DPI { get; set; } = 300.0;
        public double TargetInches { get; set; } = 1.25;
        public double DefaultOverscan { get; set; } = 0.20;
    }
}
