﻿#pragma checksum "E:\Projects\Visual Studio Projects\Windows Phone\TestPhoneApp\TestPhoneApp\TrackPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC9EC3DD0D40FA051628C7441CE38699"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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


namespace CitySafe {
    
    
    public partial class TrackPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot TrackPivot;
        
        internal Microsoft.Phone.Controls.LongListSelector TrackingList;
        
        internal Microsoft.Phone.Controls.LongListSelector TrackedList;
        
        internal System.Windows.Controls.TextBox TrackAddTextBox;
        
        internal System.Windows.Controls.Button TrackListAddButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CitySafe;component/TrackPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TrackPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("TrackPivot")));
            this.TrackingList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("TrackingList")));
            this.TrackedList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("TrackedList")));
            this.TrackAddTextBox = ((System.Windows.Controls.TextBox)(this.FindName("TrackAddTextBox")));
            this.TrackListAddButton = ((System.Windows.Controls.Button)(this.FindName("TrackListAddButton")));
        }
    }
}

