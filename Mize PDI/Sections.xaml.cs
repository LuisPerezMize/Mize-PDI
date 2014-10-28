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
    public partial class Sections : PhoneApplicationPage
    {
        public Sections()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string ID = NavigationContext.QueryString["id"].ToString();

            GetData(ID);
        }

        private async void GetData(string ID)
        {
            ExpanderListstackPanel.Children.Clear();
            App.InspectionData = await new PDILibrary.Network.NetworkCalls().GetInspection(ID);

            if (App.InspectionData != null)
            {
                App.FormID = new List<PDILibrary.Model.sections>();
                int Count = 0;

                if (App.InspectionData.items.Count > 0)
                foreach (var item in App.InspectionData.items[0].formInstance.formDefinition.form.sectionGroups)
                {
                    Count++;
                    var ExpanderData = GetExpander(item, Count, App.InspectionData.items[0].formInstance.formDefinition.form.sectionGroups.Count);
                    ExpanderListstackPanel.Children.Add(ExpanderData);

                    foreach (var Data in item.sections)
                        App.FormID.Add(Data);
                }
            }
        }

        private Telerik.Windows.Controls.RadExpanderControl GetExpander(PDILibrary.Model.sectiongroups Data, int Index, int Count)
        {
            var result = new Telerik.Windows.Controls.RadExpanderControl();
            var LongListTemplate = (DataTemplate)FindName("InsideExpanderDataTemplate");
            var ExpanderTemplate = (DataTemplate)FindName("NameSectionDatatemplate");
           
            var SubSection = new LongListSelector();

            SubSection.ItemsSource = new Engine.SectionsEngine().GetInsideExpanderData(Data.sections);
            SubSection.ItemTemplate = LongListTemplate;
            SubSection.SelectionChanged += SubSection_SelectionChanged;

            result.Content = new Engine.SectionsEngine().GetExpanderData(Data, Index, Count);
            result.ContentTemplate = ExpanderTemplate;
            result.ExpandableContent = SubSection;

            return result;
        }

        void SubSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var List = sender as LongListSelector;

            if (List.SelectedItem != null)
            {
                var Item = sender as LongListSelector;
                var SelectedItem = Item.SelectedItem as Models.InsiderExpanderModel;
                
                App.SelectedSection = SelectedItem;
                App.SelectedIndex = new Engine.CommonEngine().GetIndexOfSectionCollection(SelectedItem.ID);

                NavigationService.Navigate(new Uri(string.Format("/Form.xaml?id={0}", SelectedItem.ID), UriKind.Relative));
                List.SelectedItem = null;
            }
        }
    }
}