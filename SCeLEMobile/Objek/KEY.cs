using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DeserializeXML.Objek
{
    public class KEY
    {
        [XmlElement("VALUE")]
        public string VALUE { get; set; }

        [XmlAttribute("name")]
        public string name { get; set; }
    }
}
