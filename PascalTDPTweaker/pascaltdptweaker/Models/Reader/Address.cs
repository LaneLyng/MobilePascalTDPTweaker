using System;


namespace PascalTDPTweaker.Models.Reader
{
    class Address
    {
        /* Address to store location information. */
        public Address()
        {
            ;
        }
        public Address(String address)
        {
            String[] tokens = address.Split(',');
            ID = Helper.HexToDecString(tokens[0]);
            Low = Int32.Parse(tokens[1]);
            High = Int32.Parse(tokens[2]);
        }

        public byte[] ID { get; set; }

        public string Config { get; set; }

        public int Low { get; set; }

        public int High { get; set; }
    }
}
