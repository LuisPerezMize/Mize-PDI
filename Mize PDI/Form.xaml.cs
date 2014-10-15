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
    public partial class Form : PhoneApplicationPage
    {
        public Form()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var info = App.SelectedSection;


            //var List = new List<Models.RenderModel>();

            //List.Add(new Models.RenderModel()
            //   {
            //       CheckBoxGrid = System.Windows.Visibility.Collapsed,
            //       CommentGrid = System.Windows.Visibility.Collapsed,
            //       DateGrid = System.Windows.Visibility.Collapsed,
            //       FileGrid = System.Windows.Visibility.Collapsed,
            //       FileNameTextBlock = string.Empty,
            //       NoteGrid = System.Windows.Visibility.Collapsed,
            //       QuestionText = "1.0 Question",
            //       ComboBoxGrid = System.Windows.Visibility.Visible,
            //       ListPickerItemSource = new List<string>() { "item 1", "item 2", "item 3" },
            //       TimeGrid = System.Windows.Visibility.Collapsed,
            //   });

            //List.Add(new Models.RenderModel()
            //{
            //    CheckBoxGrid = System.Windows.Visibility.Visible,
            //    CommentGrid = System.Windows.Visibility.Collapsed,
            //    DateGrid = System.Windows.Visibility.Collapsed,
            //    FileGrid = System.Windows.Visibility.Collapsed,
            //    FileNameTextBlock = string.Empty,
            //    NoteGrid = System.Windows.Visibility.Collapsed,
            //    QuestionText = "1.1 Question",
            //    ComboBoxGrid = System.Windows.Visibility.Collapsed,
            //    ListPickerItemSource = new List<string>() { "item 1", "item 2", "item 3" },
            //    TimeGrid = System.Windows.Visibility.Collapsed,
            //});

            //List.Add(new Models.RenderModel()
            //{
            //    CheckBoxGrid = System.Windows.Visibility.Collapsed,
            //    CommentGrid = System.Windows.Visibility.Collapsed,
            //    DateGrid = System.Windows.Visibility.Visible,
            //    FileGrid = System.Windows.Visibility.Collapsed,
            //    FileNameTextBlock = string.Empty,
            //    NoteGrid = System.Windows.Visibility.Collapsed,
            //    QuestionText = "1.2 Question",
            //    ComboBoxGrid = System.Windows.Visibility.Collapsed,
            //    ListPickerItemSource = new List<string>() { "item 1", "item 2", "item 3" },
            //    TimeGrid = System.Windows.Visibility.Collapsed,
            //});

            //FormListSelector.ItemsSource = List;
        }
    }
}