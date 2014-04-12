using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Model
{
    class Model
    {
        protected readonly string _Service = "moodle_mobile_app";
        protected readonly string _SceleURL = "152.118.148.91";
        
        protected string _Token;
        protected string _Username;
        protected string _Password;

        public Model(string Username, string Password)
        {
            this._Username = Username;
            this._Password = Password;
        }


        
        public void Login(){
            //lakukan koneksi disini
            WebClient client = new WebClient();
            string tokenURL = "http://"+_SceleURL+"/login/token.php?username="+_Username+"&password="+_Password+"&service="+_Service;
            client.DownloadStringCompleted+=client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri(tokenURL));
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            _Token = e.Result;
        }

        public bool IsLoggedIn()
        {
            if (_Token == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LogOut(){
            _Token = null;
        }
    }
}
