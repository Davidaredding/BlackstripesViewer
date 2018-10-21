using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackStripesWeb
{
    public class BlackStripesOptions
    {
        public string OutputFile { get; set; }
        public string InputFile { get; set; }
        public string Color { get; set; } = "000000";
        public float Scale { get; set; } = 1;
        public float NibSize { get; set; } = 1f;
        public float Spacing { get; set; } = 2f;
        public int Level1 { get; set; } = 180;
        public int Level2 { get; set; } = 108;
        public int Level3 { get; set; } = 180;
        public int Level4 { get; set; } = 108;
        public int CrossedType { get; set; } = 2;
        public int SketchyLineSize { get; set; } = 1;
        public int SketchyMaxLineLength { get; set; } = 100;
    }
}
