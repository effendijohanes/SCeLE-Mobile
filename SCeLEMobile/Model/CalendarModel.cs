using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SCeLEMobile.Model
{
    class CalendarModel : Model
    {
        public Task<String> getCalendarString()
        {
            base.Login();
            
            var tcs = new TaskCompletionSource<string>();

            var client = new WebClient();
            client.DownloadStringCompleted += (s, e) =>
            {
                if (e.Error == null)
                {
                    tcs.SetResult(e.Result);
                }
                else
                {
                    tcs.SetException(e.Error);
                }
            };

            client.DownloadStringAsync(new Uri("http://" + base._SceleURL + "/webservice/rest/server.php?wstoken=" + base._Token + "&wsfunction=core_calendar_get_calendar_events"));
            return tcs.Task;
        }

        public void tehe()
        {
            XmlSerializer x = new XmlSerializer(typeof (Object.CalenderItem));
            //x.Deserialize()
        }
    }
}
