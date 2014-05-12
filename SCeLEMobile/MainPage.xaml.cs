using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SCeLEMobile.Model;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SCeLEMobile.Objek;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace SCeLEMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        public ObservableCollection<EnrolledMK> listEnrolledMK = new ObservableCollection<EnrolledMK>();

        ObservableCollection<ThreadMK> mkThreads = new ObservableCollection<ThreadMK>();
        List<string> usersID = new List<string>();
        IDictionary<string, User> users = new Dictionary<string, User>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Set the data context of the listbox control to the sample data
            DataContext = listEnrolledMK;
            userInfoXMLHelper();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            getThreadsinForum(""+1);
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

        private async void userInfoXMLHelper()
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=core_webservice_get_site_info", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage());
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
            string hasil = await xmlTask;
            deserializeXMLUser(hasil);
        }

        private void deserializeXMLUser(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;
            SiteInfo u = new SiteInfo(f);
            u.token = UserModel.GetTokenFromIsolatedStorage();

            getEnrolledClasses(u);
        }

        private async void getEnrolledClasses(SiteInfo u)
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=core_enrol_get_users_courses&userid={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), u.userid);
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
            string hasil = await xmlTask;
            deserializeXMLEnrolledMK(hasil);
        }

        private void deserializeXMLEnrolledMK(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;
            MULTIPLE m = f.multiple;
            foreach (SINGLE s in m.single)
            {
                listEnrolledMK.Add(new EnrolledMK(s));
            }

            longListEnrolledMK.ItemsSource = listEnrolledMK;
            this.LayoutRoot.UpdateLayout();

            Console.WriteLine("haha");
        }

        private void longListEnrolledMK_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            LongListSelector lls = sender as LongListSelector;
            EnrolledMK emk = lls.SelectedItem as EnrolledMK;

            NavigationService.Navigate(new Uri("/MataKuliahDetails.xaml?id=" + emk.Id, UriKind.Relative));
        }

        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NotifikasiKalender.xaml", UriKind.Relative));
        }
    }
}