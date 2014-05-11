using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using SCeLEMobile.Model;
using SCeLEMobile.Objek;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Media.Imaging;

namespace SCeLEMobile
{
    public partial class DaftarPost : PhoneApplicationPage
    {
        ObservableCollection<PostMK> mkPosts = new ObservableCollection<PostMK>();
        List<string> usersID = new List<string>();
        IDictionary<string, User> users = new Dictionary<string, User>();

        public DaftarPost()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string id = NavigationContext.QueryString["id"];
            getPostsinThread(id);
        }

        private async void getPostsinThread(string id)
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=mod_forum_get_forum_posts&discussionids[0]={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), id);
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
                mkPosts.Add(new PostMK(s));
            }

            foreach (PostMK tmk in mkPosts)
            {
                usersID.Add(tmk.UserID);
            }

            getUsers();

            lstPost.ItemsSource = mkPosts;
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

            foreach (PostMK tmk in mkPosts)
            {
                tmk.Image = new BitmapImage(new Uri(users[tmk.UserID].ProfileImageURL));
            }
        }

        private void list_Post_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
    }
}