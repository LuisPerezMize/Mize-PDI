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
            var InspectionData = await new PDILibrary.Network.NetworkCalls().GetInspection(ID);

            if (InspectionData != null)
            {
                int Count = 0;

                if (InspectionData.items.Count > 0)
                foreach (var item in InspectionData.items[0].formInstance.formDefinition.form.sectionGroups)
                {
                    Count++;
                    var ExpanderData = GetExpander(item, Count, InspectionData.items[0].formInstance.formDefinition.form.sectionGroups.Count);
                    ExpanderListstackPanel.Children.Add(ExpanderData);
                }
                //InspectionData.items[0].formInstance.formDefinition.form.sectionGroups[0]
                //for (int i = 0; i < ExpanderData.sectiongroups.Count; i++)
                //    ExpanderListstackPanel.Children.Add(GetExpander(ExpanderData.sectiongroups[i], (i + 1), ExpanderData.sectiongroups.Count));
                
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

                NavigationService.Navigate(new Uri(string.Format("/Form.xaml?id={0}", SelectedItem.ID), UriKind.Relative));
                List.SelectedItem = null;
            }
        }
    }
}