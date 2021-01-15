using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_RGB.Internals
{
    public class Presets
    {
        public Presets() { }

        public Presets(string name, int R, int G, int B)
        {
            Name = name;
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public string Name = string.Empty;
        public int R = 0;
        public int G = 0;
        public int B = 0;
    }
}
