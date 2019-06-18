using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PascalTDPTweaker
{
    class Parser
    {
        // List to store read config file.
        private List<Model> models;
        private bool HasRead;
        private readonly string GENERIC = "Generic";

        // Basic info address(location in BIOS).
        public byte[] StartAdr { get; set; }
        public byte[] DateAdr { get; set; }
        public byte[] NameAdr { get; set; }
        public byte[] VerAdr { get; set; }
        public byte[] BoardAdr { get; set; }

        // To be modded address.
        public byte[] TDPAdr { get; set; }
        public byte[] TDPSliderAdr { get; set; }
        public string TDPSliderSignal { get; set; }
        public byte[] Power1Adr { get; set; }
        public byte[] Power2Adr { get; set; }
        public byte[] Power3Adr { get; set; }
        public byte[] Temp1Adr { get; set; }
        public byte[] Temp2Adr { get; set; }
        public string TempSliderSignal { get; set; }
        public byte[] Checksum32Adr { get; set; }
        public byte[] Checksum8Adr { get; set; }

        // Read "Models.config".
        public void ReadConfigFile(string embeddedPath)
        {
            if (HasRead != true)
            {
                var serializer = new XmlSerializer(typeof(BiosConfig));

                using (Stream stream = this.GetType().Assembly.GetManifestResourceStream(embeddedPath))
                {
                    using (var reader = XmlReader.Create(stream))
                    {
                        BiosConfig config = (BiosConfig)serializer.Deserialize(reader);
                        this.models = config.Models;
                        this.HasRead = true;
                    }
                }
            }
        }

        // Assign basic info address.
        public void AssignInfoAddress()
        {
            this.StartAdr = Helper.HexToDecString(this.models.Find(item => item.Code == GENERIC).Starter);
            this.DateAdr = Helper.HexToDecString(this.models.Find(item => item.Code == GENERIC).Date);
            this.NameAdr = Helper.HexToDecString(this.models.Find(item => item.Code == GENERIC).BIOSName);
            this.VerAdr = Helper.HexToDecString(this.models.Find(item => item.Code == GENERIC).Version);
            this.BoardAdr = Helper.HexToDecString(this.models.Find(item => item.Code == GENERIC).Board);
        }

        // Assign binary address(to be modded).
        public string AssignDecAddress(string codeName)
        {
            try
            {
                this.TDPAdr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).TDP);
                this.TDPSliderAdr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).TDPSlider);
                this.TDPSliderSignal = this.models.Find(item => item.Code == codeName).TDPSliderSignal;
                this.Power1Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Power1);
                this.Power2Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Power2);
                this.Power3Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Power3);
                this.Temp1Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Temp1);
                this.Temp2Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Temp2);
                this.TempSliderSignal = this.models.Find(item => item.Code == codeName).TempSliderSignal;
                this.Checksum32Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Checksum32);
                this.Checksum8Adr = Helper.HexToDecString(this.models.Find(item => item.Code == codeName).Checksum8);

                return this.models.Find(item => item.Code == codeName).ModelName;
            }
            catch (Exception)
            {
                return "Unsupported";
            }
        }

        // Assign binary address(to be modded).
        public int AssignPresetValues(string modelName, int numericNum)
        {
            if (numericNum == 1)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetTDP1);
            else if (numericNum == 2)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetTDP2);
            else if (numericNum == 7 || numericNum == 8)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetPower1);
            else if (numericNum == 9 || numericNum == 10)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetPower2);
            else if (numericNum == 11 || numericNum == 12)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetPower3);
            else if (numericNum == 5)
                return Int32.Parse(this.models.Find(item => item.ModelName == modelName).PresetTempT);
            else return -1;
        }

        // Read BIOS's name and determine model.
        public string ReadModel(string name)
        {
            name = name.Length > 18 ? name.Substring(0, 18) : "";
            return AssignDecAddress(name);
        }
    }

    public static class Helper
    {
        public static byte[] HexToDecString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }

            byte[] sb = new byte[hexString.Length / 2];
            int j = 0;

            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = byte.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                sb[j] = hexChar;
                j++;
            }
            return sb;
        }

        public static string HexToString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }

            var sb = new StringBuilder();

            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        public static string ReverseTDP(string s)
        {
            string tdp = s.Substring(6, 2) + s.Substring(4, 2) + s.Substring(2, 2) + s.Substring(0, 2);
            return tdp;
        }

        public static string Spacing(string s)
        {
            string x = s.Substring(0, 2) + " " + s.Substring(2, 2) + " " + s.Substring(4, 2) + " " + s.Substring(6, 2);
            return x;
        }

        public static string ReverseTemp(string s)
        {
            string temp = s.Substring(2, 2) + s.Substring(0, 2);
            return temp;
        }
    }
}
