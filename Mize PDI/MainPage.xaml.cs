using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Mize_PDI.Resources;
using PDILibrary.Network;

namespace Mize_PDI
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //NavigationService.Navigate(new Uri("/Form.xaml", UriKind.Relative));
        }

        #region Login

        private void DoLogin()
        {
            //if (string.IsNullOrWhiteSpace(UserNameRadTxtBox.Text) || string.IsNullOrWhiteSpace(PasswordRadTxtBox.Password))
            //    MessageBox.Show("No credentials info message", App.AppName, MessageBoxButton.OK);
            //else
                LoginCall();
        }

        private async void LoginCall()
        {
            var data = await new NetworkCalls().DoLoginCall("kcmaadmin@m-ize.com", "Abcd1234");

            //var data = await new NetworkCalls().DoLoginCall(UserNameRadTxtBox.Text, PasswordRadTxtBox.Password);

            if (data.meta != null)
            {
                NavigationService.Navigate(new Uri("/Downloads.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Invalid credentials info message", App.AppName, MessageBoxButton.OK);
            }
        }

        #endregion

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            DoLogin();
        }

        #region Login Controls
        private void UserNameRadTxtBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                PasswordRadTxtBox.Focus();
        }

        private void PasswordRadTxtBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                this.Focus();
                DoLogin();
            }
        }

        #endregion
  
    }
}