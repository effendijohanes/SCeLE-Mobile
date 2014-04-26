using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DeserializeXML.Objek
{
    public class MULTIPLE
    {
        [XmlElement("SINGLE")]
        public List<SINGLE> single = new List<SINGLE>();
    }
}
