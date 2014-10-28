using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mize_PDI.Engine
{
    class SectionsEngine
    {
        public Models.ExpanderModel GetExpanderData(PDILibrary.Model.sectiongroups Data, int Index, int Count)
        {
            var result = new Models.ExpanderModel();
           
            result.Category = Data.label.intl[0].name.ToUpperInvariant();
            result.TotalSubCategory = string.Format("{0}/{1}", 0, Data.sections.Count);

            return result;
        }

        public List<Models.InsiderExpanderModel> GetInsideExpanderData(List<PDILibrary.Model.sections> Data)
        {
            var result = new List<Models.InsiderExpanderModel>();

            foreach (var item in Data)
            {
                result.Add(new Models.InsiderExpanderModel()
                    {
                        ID = item.id,
                        SubCategory = item.label.intl[0].name,
                        Fields = item.fields
                    });
            }

            return result;
        }
    }
}
