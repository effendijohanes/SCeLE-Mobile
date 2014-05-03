using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SCeLEMobile.Model;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using SCeLEMobile.Objek;
using System.Collections.ObjectModel;

namespace SCeLEMobile
{
    public partial class MataKuliahDetails : PhoneApplicationPage
    {
        List<PivotItem> pivotItems = new List<PivotItem>();
        ObservableCollection<SectionMataKuliah> mkSections = new ObservableCollection<SectionMataKuliah>();
        public MataKuliahDetails()
        {
            InitializeComponent();

            DataContext = mkSections;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string id = NavigationContext.QueryString["id"];

            getMataKuliahDetailsHelper(id);
        }

        private async void getMataKuliahDetailsHelper(string id)
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=core_course_get_contents&courseid={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), id);
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
            string hasil = await xmlTask;
            deserializeXMLMKDetails(hasil);
        }

        private void deserializeXMLMKDetails(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;

            foreach (SINGLE s in f.multiple.single)
            {
                mkSections.Add(new SectionMataKuliah(s));
            }

            foreach (SectionMataKuliah smk in mkSections)
            {
                PivotItem pvtSection = new PivotItem();
                pvtSection.DataContext = smk;
                pivotItems.Add(pvtSection);
            }

            pvtMataKuliah.ItemsSource = pivotItems;

            this.LayoutRoot.UpdateLayout();
            

        }
    }
}