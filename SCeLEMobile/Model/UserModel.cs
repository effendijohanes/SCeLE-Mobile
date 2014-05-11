using RestSharp;
using SCeLEMobile.Objek;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SCeLEMobile.Model
{
    class UserModel : ParentModel
    {
        public readonly string GET_USERINFO_URL = "/webservice/rest/server.php?wstoken={token}&wsfunction=core_webservice_get_site_info";

        public SiteInfo GetCurrentUser()
        {
            if (base.IsLoggedIn())
            {
                /*
                string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=core_webservice_get_site_info", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage());
                Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
                string xml = await xmlTask;
                return xml;
                */
                /*
                RestClient client = new RestClient(SceleURL);
                RestRequest request = new RestRequest(GET_USERINFO_URL, Method.GET);
                request.AddUrlSegment("token", IsolatedStorageAdapter.Read("token"));
                client.ExecuteAsync(request, response =>
                {
                    xml = response.Content;
                });
                */
                /*
                RestClient client = new RestClient("http://152.118.148.91");
                RestRequest request = new RestRequest("/webservice/rest/server.php?wstoken={token}&wsfunction={func}", Method.GET);
                request.AddUrlSegment("token", "71327281da7eba5caaa103bc064dbb8d");
                request.AddUrlSegment("func", "core_webservice_get_site_info");
                client.ExecuteAsync(request, response =>
                {
                    xml = response.Content;
                    System.Diagnostics.Debug.WriteLine(response.Content);
                    if (xml != null)
                    {
                        XmlReader reader = XmlReader.Create(new StringReader(xml));
                        XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
                        RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;
                    }
                });
                 */


                return null;
            }
            else
            {
                return null;
            }
        }

        

        public string hasil { get; set; }
    }
}
