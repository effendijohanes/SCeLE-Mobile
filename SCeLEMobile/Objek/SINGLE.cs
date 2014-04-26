using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DeserializeXML.Objek
{
    public class SINGLE
    {
        [XmlElement("KEY")]
        public List<KEY> key = new List<KEY>();
    }
}
