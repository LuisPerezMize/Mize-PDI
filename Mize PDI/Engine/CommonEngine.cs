using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mize_PDI.Engine
{
    class CommonEngine
    {
        public int GetIndexOfSectionCollection(int SelectedID)
        {
            int result = 0;

            for (int i = 0; i < App.FormID.Count; i++)
            {
                if (App.FormID[i].id == SelectedID)
                    result = i;
            }

            return result;
        }
    }
}
