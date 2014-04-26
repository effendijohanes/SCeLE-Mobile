using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SCeLEMobile.Model
{
    class CalendarModel : ParentModel
    {
        

        public void tehe()
        {
            XmlSerializer x = new XmlSerializer(typeof (Object.CalenderItem));
            //x.Deserialize()
        }
    }
}
