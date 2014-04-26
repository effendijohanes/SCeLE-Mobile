using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Model
{
    class ParentModel
    {
        public static readonly string Service = "scele_mobile_app";
        public static readonly string SceleURL = "http://152.118.148.91";
        
        protected static string Token;

        public ParentModel() { }

        public static Task<string> Login(string username, string password){
            //lakukan koneksi disini
            var tcs = new TaskCompletionSource<string>();
            WebClient client = new WebClient();
            
            
            string tokenURL = SceleURL+"/login/token.php?username="+username+"&password="+password+"&service="+Service;
            client.DownloadStringCompleted += (s, e) =>
            {
                if (e.Error != null)
                {
                    tcs.TrySetException(e.Error);
                }
                else if (e.Cancelled)
                {
                    tcs.TrySetCanceled();
                }
                else
                {
                    string hasil = e.Result;

                    if (hasil.Substring(2, 5).Equals("token"))
                    {
                        hasil = hasil.Substring(10);
                        char[] del = new char[1];
                        del[0] = '}';
                        Token = hasil.Replace("\"}", "");
                        tcs.TrySetResult(Token);
                    }
                    else
                    {
                        tcs.TrySetResult("ERROR");
                    }

                    //tulis token ke Isolated Storage
                    IsolatedStorageAdapter.Write("token", Token);
                }
            };
            client.DownloadStringAsync(new Uri(tokenURL));
            return tcs.Task;
        }

        
        public static Task<string> DownloadXML(Uri uri)
        {
            var tcs = new TaskCompletionSource<string>();
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (s, e) =>
            {
                if (e.Error != null)
                {
                    tcs.TrySetException(e.Error);
                }
                else if (e.Cancelled)
                {
                    tcs.TrySetCanceled();
                }
                else
                {
                    string hasil = e.Result;
                    tcs.TrySetResult(hasil);
                }
            };
            client.DownloadStringAsync(uri);
            return tcs.Task;
        }
        

        public bool IsLoggedIn()
        {
            if (IsolatedStorageAdapter.Read("token").Length == 32)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LogOut(){
            Token = null;
        }

        public static string GetTokenFromIsolatedStorage()
        {
            return IsolatedStorageAdapter.Read("token");
        }
        
    }
}
