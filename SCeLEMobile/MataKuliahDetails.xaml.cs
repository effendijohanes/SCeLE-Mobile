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
using System.Windows.Media.Imaging;
using SCeLEMobile.ViewModels;
using System.IO.IsolatedStorage;
using Windows.Storage;

namespace SCeLEMobile
{
    public partial class MataKuliahDetails : PhoneApplicationPage
    {
        List<PivotItem> pivotItems = new List<PivotItem>();
        ObservableCollection<SectionMataKuliah> mkSections = new ObservableCollection<SectionMataKuliah>();
        ObservableCollection<ForumByCourse> mkForums = new ObservableCollection<ForumByCourse>();

        public string myDescription = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.";
        public string myTitle = " Articleku ";
        public string temp = "";
        public MataKuliahDetails()
        {
            InitializeComponent();

            DataContext = mkSections;
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pivotItems = new List<PivotItem>();
            mkSections = new ObservableCollection<SectionMataKuliah>();
            string id = NavigationContext.QueryString["id"];
            getMataKuliahDetailsHelper(id);
            getForumInCourse(id);
        }

        private async void getForumInCourse(string id)
        {
            string url = String.Format("{0}/webservice/rest/server.php?wstoken={1}&wsfunction=mod_forum_get_forums_by_courses&courseids[]={2}", ParentModel.SceleURL, ParentModel.GetTokenFromIsolatedStorage(), id);
            Task<string> xmlTask = ParentModel.DownloadXML(new Uri(url));
            string hasil = await xmlTask;
            deserializeForumInCourse(hasil);
        }

        private void deserializeForumInCourse(string hasil)
        {
            XmlReader reader = XmlReader.Create(new StringReader(hasil));
            XmlSerializer mySerializer = new XmlSerializer(typeof(RESPONSE));
            RESPONSE f = mySerializer.Deserialize(reader) as RESPONSE;

            foreach (SINGLE s in f.multiple.single)
            {
                mkForums.Add(new ForumByCourse(s));
            }
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

            for (int i = 0; i < mkSections.Count; i++)
            {
                if (mkSections[i].Visible.Equals("0"))
                {
                    mkSections.RemoveAt(i);
                    i--;
                }
            }

                try
                {
                    //make a loop 

                    for (int i = 0; i < mkSections.Count; i++)
                    {
                        //add on the fly pivots
                        PivotItem myNewPivotItem = new PivotItem();
                        myNewPivotItem.Name = "piv_" + i;
                        //ID of the pivot 
                        myNewPivotItem.Header = mkSections[i].Name;
                        //title of the pivot to be shown in app

                        //add grids also 
                        Grid myNewGrid = new Grid();
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri("ApplicationIcon.png", UriKind.Relative));

                        img.MaxWidth = 170;
                        img.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
                        img.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                        TextBlock wdrTitle = new TextBlock();
                        wdrTitle.FontSize = 50;
                        wdrTitle.Text = mkSections[i].Name;

                        /*
                        TextBlock wdrDescr = new TextBlock();
                        wdrDescr.FontSize = 21;
                        wdrDescr.TextWrapping = TextWrapping.Wrap;
                    
                        wdrDescr.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                        wdrDescr.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

                        wdrDescr.Text = mkSections[i].Summary;
                         */

                        ListBox lb = new ListBox();
                        foreach (ModuleMK mmk in mkSections[i].Modules)
                        {
                            ListBoxItem lbi = new ListBoxItem();
                            ControlTemplate ct = Application.Current.Resources["ModuleMKTemplate"] as ControlTemplate;

                            lbi.Content = mmk;
                            lbi.DataContext = mmk;
                            lbi.Template = ct;
                            lbi.Tap += lbi_Tap;

                            lb.Items.Add(lbi);
                        }

                        myNewGrid.Children.Add(img);
                        myNewGrid.Children.Add(lb);
                        myNewPivotItem.Content = myNewGrid;

                        myNewGrid.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                        myNewGrid.Width = 410;
                        myNewGrid.Height = 425;

                        //add pivot to main list
                        pivotMainList.Items.Add(myNewPivotItem);

                        //shorten the text for front display
                        string shortDescr = i + " descr. " + myDescription;
                        if (shortDescr.Length > 70)
                        {
                            shortDescr = shortDescr.Substring(0, 62) + "..";
                        }
                        //TOC -  add short descr with title on the main item from the list -
                        lstItemsToList.Items.Add(new ItemViewModel
                        {
                            LineOne = mkSections[i].Name,
                            LineTwo = mkSections[i].Summary,
                            LineThree = "ApplicationIcon.png"
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

        }

        void lbi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ListBoxItem lbi = sender as ListBoxItem;
            ModuleMK mmk = lbi.Content as ModuleMK;

            if (mmk.ModName.Equals("resource") || mmk.ModName.Equals("folder"))
            {
                PhoneApplicationService.Current.State["module"] = mmk;
                NavigationService.Navigate(new Uri("/DaftarBerkasMK.xaml", UriKind.Relative));
            }
            else if (mmk.ModName.Equals("forum"))
            {
                string idTerpilih = null;
                
                //bandingkan, cari forum id
                foreach (ForumByCourse fbc in mkForums)
                {
                    if (mmk.Id.Equals(fbc.CMID))
                    {
                        idTerpilih = fbc.ID;
                    }
                }

                if (idTerpilih != null && !idTerpilih.Equals(""))
                {
                    NavigationService.Navigate(new Uri("/DaftarThread.xaml?id=" + idTerpilih + "&namaforum=" + mmk.Name, UriKind.Relative));
                }

            }
        }

        private void lstItemsToList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //handle navigation from TOC to pivots
            pivotMainList.SelectedIndex = lstItemsToList.SelectedIndex + 1;
        }
    }
}