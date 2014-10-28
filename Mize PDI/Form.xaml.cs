using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Telerik.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Mize_PDI
{
    public partial class Form : PhoneApplicationPage
    {
        PhotoChooserTask camera = new PhotoChooserTask();
        RadImageButton PlaceHolderButton = new RadImageButton();

        public Form()
        {
            InitializeComponent();

            camera.ShowCamera = true;
            camera.Completed += camera_Completed;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var info = App.SelectedSection;

            if (FormListSelector.ItemsSource == null)
            {
                TextBlockTitle.Text = string.Format("Inspection # {0}",  info.ID.ToString());
                FormListSelector.ItemsSource = await new Engine.FormEngine().GetRenderData(info.Fields);
            }
        }

        void camera_Completed(object sender, PhotoResult e)
        {
            var bmp = new BitmapImage();
            bmp.SetSource(e.ChosenPhoto);
            PlaceHolderButton.RestStateImageSource = bmp;
            PlaceHolderButton.Tag = "Set";
        }

        private void AttachFileImageButton_Click(object sender, RoutedEventArgs e)
        {
            PlaceHolderButton = sender as RadImageButton;

            if (string.Equals(PlaceHolderButton.Tag, "Set"))
                NavigationService.Navigate(new Uri("/PreviewPhoto.xaml", UriKind.Relative));
            else
                camera.Show();
        }

        private async void RadImageButtonRight_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (App.SelectedIndex < (App.FormID.Count - 1))
            {
                App.SelectedIndex++;
                FormListSelector.ItemsSource = null;
                TextBlockTitle.Text = App.FormID[App.SelectedIndex].id.ToString();
                FormListSelector.ItemsSource = await new Engine.FormEngine().GetRenderData(App.FormID[App.SelectedIndex].fields);
            }
        }

        private async void RadImageButtonLeft_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (App.SelectedIndex > 0)
            {
                App.SelectedIndex--;
                FormListSelector.ItemsSource = null;
                TextBlockTitle.Text = App.FormID[App.SelectedIndex].id.ToString();
                FormListSelector.ItemsSource = await new Engine.FormEngine().GetRenderData(App.FormID[App.SelectedIndex].fields);
            }
        }
    }
}