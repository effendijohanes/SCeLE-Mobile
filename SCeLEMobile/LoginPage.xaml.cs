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

namespace SCeLEMobile
{
    public partial class LoginPage : PhoneApplicationPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (IsolatedStorageAdapter.Read("token").Length == 32)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }

        private void btnLogin_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            btnLogin_Tap1(sender, e);
        }

        private async Task btnLogin_Tap1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            progressBar.Visibility = Visibility.Visible;
            Task<string> tokenTask = ParentModel.Login(txbUsername.Text, txbPassword.Password);
            String hasil = await tokenTask;
            if (hasil.Equals("ERROR"))
            {
                Dispatcher.BeginInvoke(() =>
                {
                    progressBar.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Login Gagal, periksa kembali Username dan Password Anda");
                });
            }
            else
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }


    }
}