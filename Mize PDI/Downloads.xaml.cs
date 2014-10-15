using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Mize_PDI
{
    public partial class Downloads : PhoneApplicationPage
    {
        public Downloads()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (InformationListSelector.ItemsSource == null)
                GetSearch();
        }

        private async void GetSearch()
        {
            BusyIndicatorLoading.IsRunning = true;
            var data = await new PDILibrary.Network.NetworkCalls().GetDownloads();
            BusyIndicatorLoading.IsRunning = false;
            var ListValues = new Engine.DownloadsEngine().GetDownloadsList(data);
            InformationListSelector.ItemsSource = ListValues;
        }

        private void InformationListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InformationListSelector.SelectedItem != null)
            {
                var Data = InformationListSelector.SelectedItem as Models.SearchModel;

                NavigationService.Navigate(new Uri(string.Format("/Sections.xaml?id={0}", Data.MasterID), UriKind.Relative));
                InformationListSelector.SelectedItem = null;
            }
        }
    }
}