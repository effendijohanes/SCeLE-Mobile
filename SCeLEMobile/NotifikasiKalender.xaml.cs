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

namespace SCeLEMobile
{
    public partial class NotifikasiKalender : PhoneApplicationPage
    {
        public ObservableCollection<EnrolledMK> listEnrolledMK = new ObservableCollection<EnrolledMK>();

        public NotifikasiKalender()
        {
            InitializeComponent();
            DataContext = listEnrolledMK;

            listNotifikasiKalender.ItemsSource = listEnrolledMK;
            this.LayoutRoot.UpdateLayout();
        }

    }
}