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
using RestSharp;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SCeLEMobile.Objek;
using System.IO;
using System.Collections.ObjectModel;

namespace SCeLEMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        public ObservableCollection<EnrolledMK> listEnrolledMK = new ObservableCollection<EnrolledMK>();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //kahsdgjahsgdjas
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
            User u = new User(f);
            u.token = UserModel.GetTokenFromIsolatedStorage();

            getEnrolledClasses(u);
        }

        private async void getEnrolledClasses(User u)
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
    }
}