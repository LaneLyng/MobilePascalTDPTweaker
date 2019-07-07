using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTDPTweaker.Models.Firmware
{
    /* Indices to store addresses to be modded. */
    public class IndexCollector
    {
        public IndexCollector()
        {
            DateIndex = -1;
            DeviceIndex = -1;
            VersionIndex = -1;
            BoardIndex = -1;

            BaseTdpIndex = -1;
            MaxTdpIndex = -1;

            P1BaseTdpIndex = -1;
            P1MaxTdpIndex = -1;

            P2BaseTdpIndex = -1;
            P2MaxTdpIndex = -1;

            P3BaseTdpIndex = -1;
            P3MaxTdpIndex = -1;

            TdpSliderIndex = -1;
            TempSliderIndex = -1;

            T1MinTempIndex = -1;
            T1BaseTempIndex = -1;
            T1MaxTempIndex = -1;

            T2MinTempIndex = -1;
            T2BaseTempIndex = -1;
            T2MaxTempIndex = -1;

            CheckSum8Index = -1;
            CheckSum32Index = -1;
            BlackSreenIndex = -1;
        }
        public int DateIndex { get; set; }

        public int VersionIndex { get; set; }

        public int BoardIndex { get; set; }

        public int DeviceIndex { get; set; }

        public int BaseTdpIndex { get; set; }

        public int MaxTdpIndex { get; set; }

        public int P1BaseTdpIndex { get; set; }

        public int P1MaxTdpIndex { get; set; }

        public int P2BaseTdpIndex { get; set; }

        public int P2MaxTdpIndex { get; set; }

        public int P3BaseTdpIndex { get; set; }

        public int P3MaxTdpIndex { get; set; }

        public int TdpSliderIndex { get; set; }

        public int TempSliderIndex { get; set; }

        public int T1MinTempIndex { get; set; }

        public int T1BaseTempIndex { get; set; }

        public int T1MaxTempIndex { get; set; }

        public int T2MinTempIndex { get; set; }

        public int T2BaseTempIndex { get; set; }

        public int T2MaxTempIndex { get; set; }

        public int CheckSum8Index { get; set; }

        public int CheckSum32Index { get; set; }

        public int BlackSreenIndex { get; set; }
    }
}
