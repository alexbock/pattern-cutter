using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_cutter
{
    public class Configuration
    {
        public double DPI { get; set; } = 300.0;
        public double TargetInches { get; set; } = 1.25;
        public double DefaultOverscan { get; set; } = 0.20;
        public double PaperWidthInches { get; set; } = 8.5;
        public double PaperHeightInches { get; set; } = 11.0;
    }
}
