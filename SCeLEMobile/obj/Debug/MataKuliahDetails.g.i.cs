﻿#pragma checksum "C:\Users\AriefR\Documents\GitHub\SCeLE-Mobile\SCeLEMobile\MataKuliahDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0908827AAE2EA9754BDB371B0D9516B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SCeLEMobile {
    
    
    public partial class MataKuliahDetails : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivotMainList;
        
        internal Microsoft.Phone.Controls.PivotItem titleToday;
        
        internal System.Windows.Controls.ListBox lstItemsToList;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SCeLEMobile;component/MataKuliahDetails.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivotMainList = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivotMainList")));
            this.titleToday = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("titleToday")));
            this.lstItemsToList = ((System.Windows.Controls.ListBox)(this.FindName("lstItemsToList")));
        }
    }
}

