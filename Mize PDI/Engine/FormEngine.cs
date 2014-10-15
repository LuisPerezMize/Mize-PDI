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
            int Counter = 0;
            var result = new List<Models.RenderModel>();

            foreach (var item in fields)
            {
                
                switch (item.fieldType)
                {
                    case "text":
                        Counter++;
                        result.Add(new Models.RenderModel()
                            {
                                QuestionText = string.Format("{0} Question", Counter),
                                CommentGrid = System.Windows.Visibility.Visible,
                                CheckBoxGrid = System.Windows.Visibility.Collapsed,
                                DateGrid = System.Windows.Visibility.Collapsed,
                                FileGrid = System.Windows.Visibility.Collapsed,
                                FileNameTextBlock = string.Empty,
                                NoteGrid = System.Windows.Visibility.Collapsed,
                                ComboBoxGrid = System.Windows.Visibility.Collapsed,
                                ListPickerItemSource = new List<string>(),
                                TimeGrid = System.Windows.Visibility.Collapsed,
                                CommentTitle = item.fieldLabel,
                            });

                        break;

                    case "numeric":
                        break;

                    case "alphaNumeric":
                        Counter++;
                        result.Add(new Models.RenderModel()
                        {
                            QuestionText = string.Format("{0} Question", Counter),
                            CommentGrid = System.Windows.Visibility.Visible,
                            CheckBoxGrid = System.Windows.Visibility.Collapsed,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Collapsed,
                            FileNameTextBlock = string.Empty,
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Collapsed,
                            ListPickerItemSource = new List<string>(),
                            TimeGrid = System.Windows.Visibility.Collapsed,
                            CommentTitle = item.fieldLabel,
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
                        Counter++;
                        result.Add(new Models.RenderModel()
                        {
                            QuestionText = string.Format("{0} Question", Counter),
                            CommentGrid = System.Windows.Visibility.Collapsed,
                            CheckBoxGrid = System.Windows.Visibility.Visible,
                            DateGrid = System.Windows.Visibility.Collapsed,
                            FileGrid = System.Windows.Visibility.Collapsed,
                            FileNameTextBlock = string.Empty,
                            NoteGrid = System.Windows.Visibility.Collapsed,
                            ComboBoxGrid = System.Windows.Visibility.Collapsed,
                            ListPickerItemSource = new List<string>(),
                            TimeGrid = System.Windows.Visibility.Collapsed,
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
    }
}
