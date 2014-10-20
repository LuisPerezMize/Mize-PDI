using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Mize_PDI.Models
{
    class RenderModel
    {
        public string QuestionText { get; set; }
        public Visibility ComboBoxGrid { get; set; }
        public Visibility CheckBoxGrid { get; set; }
        public Visibility NoteGrid { get; set; }
        public Visibility CommentGrid { get; set; }
        public Visibility TimeGrid { get; set; }
        public Visibility DateGrid { get; set; }
        public Visibility FileGrid { get; set; }
        public Visibility LabelGrid { get; set; }
        public Visibility DisplaySameRow { get; set; }
        public string FileNameTextBlock { get; set; }
        public DateTime TimeValue { get; set; }
        public DateTime DateValue { get; set; }
        public List<string> ListPickerItemSource { get; set; }
        public string CommentTitle { get; set; }
        public string CheckBoxContent { get; set; }
    }

    public class SearchModel
    {
        public string MainField { get; set; }
        public string Status { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string FormType { get; set; }
        public string Form { get; set; }
        public string Modify { get; set; }
        public string ModifyDate { get; set; }
        public string ModifyTime { get; set; }
        public string FormDays { get; set; }
        public string Time { get; set; }
        public string InspectionNumber { get; set; }
        public string MasterID { get; set; }
        public SolidColorBrush StatusColor { get; set; }
    }

    public class ExpanderModel
    {
        public string Category { get; set; }
        public string TotalSubCategory { get; set; }
    }

    public class InsiderExpanderModel
    {
        public string SubCategory { get; set; }
        public int ID { get; set; }
        public List<PDILibrary.Model.fields> Fields { get; set; }
    }
}
