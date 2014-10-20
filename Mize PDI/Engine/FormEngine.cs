using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mize_PDI.Engine
{
    class FormEngine
    {
        public List<Models.RenderModel> GetRenderData(List<PDILibrary.Model.fields> fields)
        {
            var result = new List<Models.RenderModel>();

            foreach (var item in fields)
            {
                switch (item.type)
                {
                    case "text":
                    case "instruction":
                        result.Add(new Models.RenderModel()
                            {
                                DisplaySameRow = DisplayRow(item.sameRow),
                                LabelGrid = System.Windows.Visibility.Visible,
                                QuestionText = item.label.intl[0].name,
                                CommentGrid = System.Windows.Visibility.Collapsed,
                                CheckBoxGrid = System.Windows.Visibility.Collapsed,
                                DateGrid = System.Windows.Visibility.Collapsed,
                                FileGrid = System.Windows.Visibility.Collapsed,
                                FileNameTextBlock = string.Empty,
                                NoteGrid = System.Windows.Visibility.Collapsed,
                                ComboBoxGrid = System.Windows.Visibility.Collapsed,
                                ListPickerItemSource = new List<string>(),
                                TimeGrid = System.Windows.Visibility.Collapsed,
                                CommentTitle = item.label.intl[0].name,
                            });

                        break;

                    case "numeric":
                        break;

                    case "attachment":
                        result.Add(new Models.RenderModel()
                        {
                            DisplaySameRow = DisplayRow(item.sameRow),
                            LabelGrid = System.Windows.Visibility.Collapsed,
                            CommentGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxGrid = System.Windows.Visibility.Visible,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Visible,
                            FileNameTextBlock = GetAttachmentName(item.attachments),
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Collapsed,
                            ListPickerItemSource = new List<string>(),
                            TimeGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxContent = item.label.intl[0].name,
                        });
                        break;

                    case "catalog":
                        result.Add(new Models.RenderModel()
                        {
                            DisplaySameRow = DisplayRow(item.sameRow),
                            LabelGrid = System.Windows.Visibility.Collapsed,
                            CommentGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxGrid = System.Windows.Visibility.Visible,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Collapsed,
                            FileNameTextBlock = string.Empty,
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Visible,
                            ListPickerItemSource = new List<string>() { "Engine not working", "Low oil level", "Need repair" },
                            TimeGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxContent = item.label.intl[0].name,
                        });
                        break;

                    case "alphaNumeric":
                        result.Add(new Models.RenderModel()
                        {
                            DisplaySameRow = DisplayRow(item.sameRow),
                            LabelGrid = System.Windows.Visibility.Collapsed,
                            CommentGrid = System.Windows.Visibility.Visible,
                            CheckBoxGrid = System.Windows.Visibility.Collapsed,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Collapsed,
                            FileNameTextBlock = string.Empty,
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Collapsed,
                            ListPickerItemSource = new List<string>(),
                            TimeGrid = System.Windows.Visibility.Collapsed,
                            CommentTitle = item.label.intl[0].name,
                        });
                        break;

                    case "email":
                        break;

                    case "url":
                        break;

                    case "phone":
                        break;

                    case "date":
                        break;

                    case "textarea":
                        break;

                    case "checkbox":
                        result.Add(new Models.RenderModel()
                        {
                            DisplaySameRow = DisplayRow(item.sameRow),
                            LabelGrid = System.Windows.Visibility.Collapsed,
                            CommentGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxGrid = System.Windows.Visibility.Visible,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Collapsed,
                            FileNameTextBlock = string.Empty,
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Collapsed,
                            ListPickerItemSource = new List<string>(),
                            TimeGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxContent = item.label.intl[0].name,
                        });
                        break;

                    case "button":
                        break;

                    default:
                        break;
                }
            }

            return result;
        }

        private System.Windows.Visibility DisplayRow(string Value)
        {
            if (string.Equals(Value.ToLowerInvariant(), "y"))
                return System.Windows.Visibility.Collapsed;
            else
                return System.Windows.Visibility.Visible;
        }

        private string GetAttachmentName(List<PDILibrary.Model.attachments> attachment)
        {
            string result = string.Empty;

            if (attachment == null)
                return result;

            if (!string.IsNullOrEmpty(attachment[0].name))
                result = attachment[0].name;
            else
                result = attachment[0].url;

            return result;
        }
    }
}
