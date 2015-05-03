using System;
using System.Drawing;

namespace pattern_cutter
{
    class Pattern
    {
        Pattern(String name, Bitmap source, Rectangle sourceRegion)
        {
            Name = name;
            Source = source;
            SourceRegion = sourceRegion;
        }

        public String Name { get; set; }
        public Image Source { get; set; } // original full-size source image
        public Rectangle SourceRegion { get; set; } // does NOT include overscan
        public double Overscan { get; set; } // percentage of the image size to overscan by
    }
}
