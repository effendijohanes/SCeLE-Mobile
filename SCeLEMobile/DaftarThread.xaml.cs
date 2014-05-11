using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;
using SCeLEMobile.Model;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using SCeLEMobile.Objek;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace SCeLEMobile
{
    public partial class DaftarThread : PhoneApplicationPage
    {
        ObservableCollection<ThreadMK> mkThreads = new ObservableCollection<ThreadMK>();
        List<string> usersID = new List<string>();
        IDictionary<string, User> users = new Dictionary<string, User>();

        public DaftarThread()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string id = NavigationContext.QueryString["id"];
            getThreadsinForum(id);
        }

        private async void getThreadsinForum(string id)
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=mod_forum_get_forum_discussions&forumids[]={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), id);
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
            string hasil = await xmlTask;
            deserialize(hasil);
        }

        private void deserialize(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;

            foreach (SINGLE s in f.multiple.single)
            {
                mkThreads.Add(new ThreadMK(s));
            }

            foreach (ThreadMK tmk in mkThreads)
            {
                usersID.Add(tmk.UserID);
            }

            getUsers();

            lstThread.ItemsSource = mkThreads;
        }

        private async void getUsers()
        {
            string query = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=core_user_get_users_by_field&field={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), "id");
            for (int i = 0; i < usersID.Count; i++)
            {
                query = query + "&values[" + i + "]=" + usersID[i];
            }
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(query));
            string hasil = await xmlTask;
            deserializeUsers(hasil);
        }

        private void deserializeUsers(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;

            foreach (SINGLE s in f.multiple.single)
            {
                User u = new User(s);
                users[u.ID] = u;
            }

            foreach (ThreadMK tmk in mkThreads)
            {
                tmk.Image = new BitmapImage(new Uri(users[tmk.UserID].ProfileImageURL));
            }
        }

        private void list_Thread_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
    }
}