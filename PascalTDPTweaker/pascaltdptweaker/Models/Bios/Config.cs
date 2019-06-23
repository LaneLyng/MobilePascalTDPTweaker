using System.Collections.Generic;
using System.Xml.Serialization;

namespace PascalTDPTweaker.Models.Bios
{
    [XmlRoot("configuration")]
    public class Config
    {
        [XmlArray("Models")]
        [XmlArrayItem("Model")]
        public List<Model> Models { get; set; }
    }
}
