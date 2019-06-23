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
        public Address BaseTdpAdr { get; set; }
        public Address MaxTdpAdr { get; set; }
        public Address TdpSliderAdr { get; set; }
        public Address TdpSliderSignal { get; set; }
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

        // Preset.
        public Preset BaseTdpPreset { get; set; }
        public Preset MaxTdpPreset { get; set; }
        public Preset Power1Preset { get; set; }
        public Preset Power2Preset { get; set; }
        public Preset Power3Preset { get; set; }
        public Preset TempPreset { get; set; }

        // Read "Models.config".
        public void ReadConfigFile(string embeddedPath, string generic)
        {
            var serializer = new XmlSerializer(typeof(Config));

            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream(embeddedPath))
            {
                using (var xmlReader = XmlReader.Create(stream))
                {
                    Config config = (Config)serializer.Deserialize(xmlReader);
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
            this.NameAdr = new Address(model.BiosName);
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

                this.BaseTdpAdr = new Address(model.BaseTdp);
                this.MaxTdpAdr = new Address(model.MaxTdp);
                this.TdpSliderAdr = new Address(model.TdpSlider);
                this.TdpSliderSignal = new Address
                {
                    Config = model.TdpSliderSignal
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
                    Config = model.TempSliderSignal
                };

                this.Checksum32Adr = new Address(model.Checksum32);
                this.Checksum8Adr = new Address(model.Checksum8);

                AssignPresetValues(model);
                return model.ModelName;
            }
            catch (Exception)
            {
                return "Unsupported";
            }
        }

        // Assign binary address(to be modded).
        public int AssignPresetValues(Model model)
        {
            try
            {
                this.BaseTdpPreset = new Preset(Int32.Parse(model.PresetTdpBase));
                this.MaxTdpPreset = new Preset(Int32.Parse(model.PresetTdpMax));
                this.Power1Preset = new Preset(Int32.Parse(model.PresetPower1));
                this.Power2Preset = new Preset(Int32.Parse(model.PresetPower2));
                this.Power3Preset = new Preset(Int32.Parse(model.PresetPower3));
                this.TempPreset = new Preset(Int32.Parse(model.PresetTemp));

                return 1;
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
