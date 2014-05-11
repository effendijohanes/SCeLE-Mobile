using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SCeLEMobile.Objek;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using SCeLEMobile.Model;
using Windows.Storage;
using System.IO;

namespace SCeLEMobile
{
    public partial class DaftarBerkasMK : PhoneApplicationPage
    {
        String temp = "";
        ObservableCollection<ModuleContent> mcList;
        public DaftarBerkasMK()
        {
            InitializeComponent();

            DataContext = mcList;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ModuleMK k = PhoneApplicationService.Current.State["module"] as ModuleMK;
            mcList = k.Contents;
            listBerkas.ItemsSource = mcList;
            listBerkas.DataContext = mcList;
        }



        async void client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            byte[] buffer = new byte[e.Result.Length];
            await e.Result.ReadAsync(buffer, 0, buffer.Length);

            using (IsolatedStorageFile storageFile = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storageFile.OpenFile(temp, FileMode.OpenOrCreate))
                {
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                }
            }

            // Access the file.
            StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile fileTarget = await local.GetFileAsync(temp);

            // Launch the pdf file.
            await Windows.System.Launcher.LaunchFileAsync(fileTarget);
            //progressBar.Visibility = Visibility.Collapsed;
        }

        private void listBerkas_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ListBox lb = sender as ListBox;
            //ListBoxItem lbi = lb.SelectedItem as ListBoxItem;
            ModuleContent mc = lb.SelectedItem as ModuleContent;
            temp = mc.FileName;
            
            WebClient client = new WebClient();
            client.OpenReadCompleted += client_OpenReadCompleted;
            client.OpenReadAsync(new Uri(mc.FileURL + "&token=" + ParentModel.GetTokenFromIsolatedStorage()));
        }

    }
}