using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTDPTweaker.Models.Reader
{
    class Preset
    {
        public Preset(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
    }
}
