using System.Xml.Serialization;

namespace PascalTDPTweaker.Models.Reader
{
    public class Model
    {
        [XmlAttribute("code")]
        // Config name.
        public string Code { get; set; }
        public string ModelName { get; set; }

        // Basic info.
        public string Starter { get; set; }
        public string Date { get; set; }
        public string BiosName { get; set; }
        public string Version { get; set; }
        public string Board { get; set; }
        public string DeviceID { get; set; }


        // To be Modded.
        public string BaseTdp { get; set; }
        public string MaxTdp { get; set; }
        public string TdpSlider { get; set; }
        public string TdpSliderSignal { get; set; }

        public string Power1Base { get; set; }
        public string Power1Max { get; set; }
        public string Power2Base { get; set; }
        public string Power2Max { get; set; }
        public string Power3Base { get; set; }
        public string Power3Max { get; set; }

        public string Temp1Min { get; set; }
        public string Temp1Base { get; set; }
        public string Temp1Max { get; set; }
        public string Temp2Min { get; set; }
        public string Temp2Base { get; set; }
        public string Temp2Max { get; set; }
        public string TempSlider { get; set; }
        public string TempSliderSignal { get; set; }
        public string Checksum8 { get; set; }
        public string Checksum32 { get; set; }

        // Preset.
        public string PresetTdpBase { get; set; }
        public string PresetTdpMax { get; set; }
        public string PresetPower1 { get; set; }
        public string PresetPower2 { get; set; }
        public string PresetPower3 { get; set; }
        public string PresetTdpSlider { get; set; }
        public string PresetTemp { get; set; }
    }
}
