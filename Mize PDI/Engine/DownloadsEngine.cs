using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Mize_PDI.Engine
{
    class DownloadsEngine
    {
        public List<Models.SearchModel> GetDownloadsList(PDILibrary.Models.JsonSearchResult.meta Data)
        {
            var result = new List<Models.SearchModel>();

            string master_InspectionCode = string.Empty;
            string master_RequestorCode = string.Empty;
            string master_InspectionTypeName = string.Empty;
            string master_FormDefinition_Name = string.Empty;
            string equipment_equipmentModel = string.Empty;
            string equipment_equipmentSerial = string.Empty;
            string master_InspectionStatusName = string.Empty;
            string master_InspectionDate = string.Empty;
            string master_Id = string.Empty;
            string master_UpdatedDate = string.Empty;
            string master_UpdatedByName = string.Empty;
            BitmapImage CloudImage = new BitmapImage();

            foreach (var item in Data.items)
            {
                if (item.attributes != null)
                foreach (var value in item.attributes)
                {
                    if (string.Equals(value.name, "master_InspectionCode"))
                        master_InspectionCode = value.value;

                    if (string.Equals(value.name, "master_RequestorCode"))
                        master_RequestorCode = value.value;

                    if (string.Equals(value.name, "master_InspectionTypeName"))
                        master_InspectionTypeName = value.value;

                    if (string.Equals(value.name, "master_FormDefinition_Name"))
                        master_FormDefinition_Name = value.value;

                    if (string.Equals(value.name, "equipment_equipmentModel"))
                        equipment_equipmentModel = value.value;

                    if (string.Equals(value.name, "equipment_equipmentSerial"))
                        equipment_equipmentSerial = value.value;

                    if (string.Equals(value.name, "master_InspectionStatusName"))
                        master_InspectionStatusName = value.value;

                    if (string.Equals(value.name, "master_InspectionDate"))
                        master_InspectionDate = value.value;

                    if (string.Equals(value.name, "master_UpdatedByName"))
                        master_UpdatedByName = value.value;

                    if (string.Equals(value.name, "master_UpdatedDate"))
                        master_UpdatedDate = value.value;

                    if (string.Equals(value.name, "master_Id"))
                        master_Id = value.value;
                }

                if (string.Equals("draft", master_InspectionStatusName.ToLowerInvariant()))
                    CloudImage.UriSource = new Uri("/Assets/cloud-download.png", UriKind.Relative);

                if (string.Equals("completed", master_InspectionStatusName.ToLowerInvariant()))
                    CloudImage.UriSource = new Uri("/Assets/cloud-sync.png", UriKind.Relative);

                result.Add(new Models.SearchModel()
                    {
                        Model = equipment_equipmentModel,
                        SerialNumber = equipment_equipmentSerial,
                        Form = master_FormDefinition_Name,
                        FormDays = master_InspectionDate,
                        Status = master_InspectionStatusName,
                        MasterID = master_Id,
                        InspectionNumber = master_InspectionCode,
                        Modify = master_RequestorCode,
                        FormType = master_InspectionTypeName,
                        StatusColor = GetStatusColor(master_InspectionStatusName),
                        ModifyDate = master_UpdatedDate,
                        CloudIcon = CloudImage
                    });
            }

            return result;
        }

        private SolidColorBrush GetStatusColor(string Status)
        {
            var color = new Color();

            switch (Status.ToLowerInvariant())
            {
                case "completed":
                    color = Color.FromArgb(255, 33, 133, 0);
                    break;

                case "draft":
                    color = Color.FromArgb(255, 251, 184, 48);
                    break;

                case "in progress":
                    color = Color.FromArgb(255, 229, 137, 26);
                    break;

                default:
                    color = Color.FromArgb(255, 229, 137, 26);
                    break;
            }

            return new SolidColorBrush(color);
        }
    }
}