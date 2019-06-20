using System.Xml.Serialization;

namespace PascalTDPTweaker.Models.Bios
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
        public string BIOSName { get; set; }
        public string Version { get; set; }
        public string Board { get; set; }


        // To be Modded.
        public string BaseTDP { get; set; }
        public string MaxTDP { get; set; }
        public string TDPSlider { get; set; }
        public string TDPSliderSignal { get; set; }

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
        public string PresetTDP1 { get; set; }
        public string PresetTDP2 { get; set; }
        public string PresetPower1 { get; set; }
        public string PresetPower2 { get; set; }
        public string PresetPower3 { get; set; }
        public string PresetTDPSlider { get; set; }
        public string PresetTempT { get; set; }
    }
}
