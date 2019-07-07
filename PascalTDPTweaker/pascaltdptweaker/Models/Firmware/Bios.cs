using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTDPTweaker.Models.Firmware
{
    public class Bios
    {
        public Bios(byte[] file)
        {
            this.ByteArray = file;
            this.IndexCollection = new IndexCollector();
        }

        public byte[] ByteArray { get; set; }
        public IndexCollector IndexCollection { get; set; }

        public int Length()
        {
            return ByteArray.Length;
        }
    }
}
