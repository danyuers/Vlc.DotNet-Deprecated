﻿using System;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;

namespace Vlc.DotNet.Silverlight.SampleApplication.Views
{
    public partial class InstallView : UserControl
    {
        public InstallView()
        {
            InitializeComponent();
        }

        private void OnBtnInstallClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Install();
        }
    }
}
