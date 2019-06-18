using System.Collections.Generic;
using System.Xml.Serialization;

namespace PascalTDPTweaker
{
    [XmlRoot("configuration")]
    public class BiosConfig
    {
        [XmlArray("Models")]
        [XmlArrayItem("Model")]
        public List<Model> Models { get; set; }
    }

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
        public string TDP { get; set; }
        public string TDPSlider { get; set; }
        public string TDPSliderSignal { get; set; }

        public string Power1 { get; set; }
        public string Power2 { get; set; }
        public string Power3 { get; set; }

        /*
        // To be added for desktop cards
        public string Power4 { get; set; }
        public string Power5 { get; set; }
        public string Power6 { get; set; }
        */

        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
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
