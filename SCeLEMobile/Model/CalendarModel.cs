using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Model
{
    class CalendarModel : Model
    {
        public void FetchCalendar()
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;

            if(base.IsLoggedIn()){
                string token = base._Token;
                client.DownloadStringAsync(new Uri("http://" + base._SceleURL + "/webservice/rest/server.php?wstoken=" + token + "&wsfunction=core_calendar_get_calendar_events"));
            }else{
                //login
            }
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string hasil = e.Result;
            
        }
    }
}
