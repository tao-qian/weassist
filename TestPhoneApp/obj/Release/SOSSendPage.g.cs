﻿#pragma checksum "E:\Projects\Visual Studio Projects\Windows Phone\TestPhoneApp\TestPhoneApp\SOSSendPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "207C14B44360004F396611DFFDF8E251"
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
    
    
    public partial class SOSSendPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock CharCount;
        
        internal System.Windows.Controls.TextBox SOSMessage;
        
        internal System.Windows.Controls.Image AddPhotoImage;
        
        internal System.Windows.Controls.Image DeletePhotoImage;
        
        internal System.Windows.Controls.CheckBox ShareRequestCheck;
        
        internal System.Windows.Controls.StackPanel ShareSettingsPanel;
        
        internal System.Windows.Controls.CheckBox ShareNameCheck;
        
        internal System.Windows.Controls.CheckBox ShareEmailCheck;
        
        internal System.Windows.Controls.CheckBox SharePhoneCheck;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CitySafe;component/SOSSendPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CharCount = ((System.Windows.Controls.TextBlock)(this.FindName("CharCount")));
            this.SOSMessage = ((System.Windows.Controls.TextBox)(this.FindName("SOSMessage")));
            this.AddPhotoImage = ((System.Windows.Controls.Image)(this.FindName("AddPhotoImage")));
            this.DeletePhotoImage = ((System.Windows.Controls.Image)(this.FindName("DeletePhotoImage")));
            this.ShareRequestCheck = ((System.Windows.Controls.CheckBox)(this.FindName("ShareRequestCheck")));
            this.ShareSettingsPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ShareSettingsPanel")));
            this.ShareNameCheck = ((System.Windows.Controls.CheckBox)(this.FindName("ShareNameCheck")));
            this.ShareEmailCheck = ((System.Windows.Controls.CheckBox)(this.FindName("ShareEmailCheck")));
            this.SharePhoneCheck = ((System.Windows.Controls.CheckBox)(this.FindName("SharePhoneCheck")));
        }
    }
}

