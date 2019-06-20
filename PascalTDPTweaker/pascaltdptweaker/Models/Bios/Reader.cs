using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PascalTDPTweaker.Models.Bios
{
    class Reader
    {
        // List to store read config file.
        private List<Model> models;

        // Basic info address(location in BIOS).
        public Address StartAdr { get; set; }
        public Address DateAdr { get; set; }
        public Address NameAdr { get; set; }
        public Address VerAdr { get; set; }
        public Address BoardAdr { get; set; }

        // To be modded address.
        // Power.
        public Address BaseTDPAdr { get; set; }
        public Address MaxTDPAdr { get; set; }
        public Address TDPSliderAdr { get; set; }
        public Address TDPSliderSignal { get; set; }
        public Address Power1BaseAdr { get; set; }
        public Address Power1MaxAdr { get; set; }
        public Address Power2BaseAdr { get; set; }
        public Address Power2MaxAdr { get; set; }
        public Address Power3BaseAdr { get; set; }
        public Address Power3MaxAdr { get; set; }

        // Temperature.
        public Address Temp1MinAdr { get; set; }
        public Address Temp1BaseAdr { get; set; }
        public Address Temp1MaxAdr { get; set; }
        public Address Temp2MinAdr { get; set; }
        public Address Temp2BaseAdr { get; set; }
        public Address Temp2MaxAdr { get; set; }
        public Address TempSliderAdr { get; set; }
        public Address TempSliderSignal { get; set; }

        // Checksum.
        public Address Checksum32Adr { get; set; }
        public Address Checksum8Adr { get; set; }

        // Read "Models.config".
        public void ReadConfigFile(string embeddedPath, string generic)
        {
            var serializer = new XmlSerializer(typeof(BiosConfig));

            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream(embeddedPath))
            {
                using (var reader = XmlReader.Create(stream))
                {
                    BiosConfig config = (BiosConfig)serializer.Deserialize(reader);
                    this.models = config.Models;
                    this.AssignInfoAddress(generic);
                    this.AssignDecAddress(generic);
                }
            }
        }

        // Assign basic info address.
        public void AssignInfoAddress(string codeName)
        {
            Model model = this.models.Find(item => item.Code == codeName);

            this.StartAdr = new Address(model.Starter);
            this.DateAdr = new Address(model.Date);
            this.NameAdr = new Address(model.BIOSName);
            this.VerAdr = new Address(model.Version);
            this.BoardAdr= new Address(model.Board);
        }

        // Assign binary address(to be modded).
        public string AssignDecAddress(string codeName)
        {
            try
            {
                Model model = this.models.Find(item => item.Code == codeName);

                // Re-read the board since model could have been changed.
                this.BoardAdr = new Address(model.Board);

                this.BaseTDPAdr = new Address(model.BaseTDP);
                this.MaxTDPAdr = new Address(model.MaxTDP);
                this.TDPSliderAdr = new Address(model.TDPSlider);
                this.TDPSliderSignal = new Address
                {
                    Code = model.TDPSliderSignal
                };
                this.Power1BaseAdr = new Address(model.Power1Base);
                this.Power1MaxAdr = new Address(model.Power1Max);
                this.Power2BaseAdr = new Address(model.Power2Base);
                this.Power2MaxAdr = new Address(model.Power2Max);
                this.Power3BaseAdr = new Address(model.Power3Base);
                this.Power3MaxAdr = new Address(model.Power3Max);


                this.Temp1MinAdr = new Address(model.Temp1Min);
                this.Temp1BaseAdr = new Address(model.Temp1Base);
                this.Temp1MaxAdr = new Address(model.Temp1Max);
                this.Temp2MinAdr = new Address(model.Temp2Min);
                this.Temp2BaseAdr = new Address(model.Temp2Base);
                this.Temp2MaxAdr = new Address(model.Temp2Max);
                this.TempSliderAdr = new Address(model.TempSlider);
                this.TempSliderSignal = new Address
                {
                    Code = model.TempSliderSignal
                };

                this.Checksum32Adr = new Address(model.Checksum32);
                this.Checksum8Adr = new Address(model.Checksum8);

                return model.ModelName;
            }
            catch (Exception)
            {
                return "Unsupported";
            }
        }

        // Assign binary address(to be modded).
        public int AssignPresetValues(string modelName, int numericNum)
        {
            Model model = this.models.Find(item => item.ModelName == modelName);
            try
            {
                if (numericNum == 1)
                    return Int32.Parse(model.PresetTDP1);
                else if (numericNum == 2)
                    return Int32.Parse(model.PresetTDP2);
                else if (numericNum == 7 || numericNum == 8)
                    return Int32.Parse(model.PresetPower1);
                else if (numericNum == 9 || numericNum == 10)
                    return Int32.Parse(model.PresetPower2);
                else if (numericNum == 11 || numericNum == 12)
                    return Int32.Parse(model.PresetPower3);
                else if (numericNum == 5)
                    return Int32.Parse(model.PresetTempT);
                else return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        // Read BIOS's name and determine model.
        public string ReadModel(string name)
        {
            name = name.Length > 12 ? name.Substring(0, 12) : "";
            return AssignDecAddress(name);
        }
    }
}
