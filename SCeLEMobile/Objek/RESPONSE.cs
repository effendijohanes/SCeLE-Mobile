using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;

namespace SCeLEMobile.Objek
{
    public class RESPONSE
    {
        [XmlElement("MULTIPLE")]
        public MULTIPLE multiple { get; set; }

        [XmlElement("SINGLE")]
        public List<SINGLE> single = new List<SINGLE>();
   
    }
}
