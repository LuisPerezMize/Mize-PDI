using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PDILibrary.Engine
{
    class GetJsonString
    {
        public string GetLoginJsonPost(string Email, string Password)
        {
            var LoginObject = new Model.Login();

            LoginObject.email = Email;
            LoginObject.password = Password;
            //LoginObject.deviceToken = "WindowsNotificationChannel";
            //LoginObject.deviceOS = "android";

            return Newtonsoft.Json.JsonConvert.SerializeObject(LoginObject);
        }

        public string GetSearchJsonPost()
        {
            var SearchObject = new Models.searchPost();

            SearchObject.entityName = "InspectionForm";
            SearchObject.pageIndex = "0";
            SearchObject.pageSize = "10";
            SearchObject.attributes = new List<Models.attributesRoot>();
            SearchObject.attributes.Add(new Models.attributesRoot()
                {
                    condition = "CONTAINS",
                    value = string.Empty,
                });

            var Attributes = new List<Models.attributes>();

            Attributes.Add(new Models.attributes()
            {
                //name = "master_InspectionNumber",
                name = "master_InspectionCode",
                type = "STRING",
                label ="Inspection #",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_NO"
            });

            Attributes.Add(new Models.attributes()
            {
                //name = "master_BeCode",
                name = "master_RequestorCode",
                type = "STRING",
                label = "Inspection Location #",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_LOC"
            });

            Attributes.Add(new Models.attributes()
            {
                //name = "master_LinkTypeName",
                name = "master_InspectionTypeName",
                type = "STRING",
                label = "Inspection type",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_TYP"
            });

            Attributes.Add(new Models.attributes()
            {
                name = "master_FormDefinition_Name",
                type = "STRING",
                label = "Form Name",
                hidden = "N",
                alignment = "left",
                labelCode = "FM_NM"
            });

            Attributes.Add(new Models.attributes()
            {
                //name = "master_Model",
                name = "equipment_equipmentModel",
                type = "STRING",
                label = "Model",
                hidden = "N",
                alignment = "left",
                labelCode = "MDL"
            });

            Attributes.Add(new Models.attributes()
            {
                //name = "master_ProdSerialNumber",
                name = "equipment_equipmentSerial",
                type = "STRING",
                label = "Product Serial #",
                hidden = "N",
                alignment = "left",
                labelCode = "PRD_SRL_NO"
            });

            Attributes.Add(new Models.attributes()
            {
                //name = "master_StatusCodeName",
                name = "master_InspectionStatusName",
                type = "STRING",
                label = "Status",
                hidden = "N",
                alignment = "left",
                labelCode = "STS"
            });

            Attributes.Add(new Models.attributes()
            {
                name = "master_InspectionDate",
                type = "DATE",
                label = "Inspection Date",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_DT"
            });

            Attributes.Add(new Models.attributes()
            {
                name = "master_UpdatedByName",
                type = "DATE",
                label = "Inspection Date",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_DT"
            });

            Attributes.Add(new Models.attributes()
            {
                name = "master_UpdatedDate",
                type = "DATE",
                label = "Inspection Date",
                hidden = "N",
                alignment = "left",
                labelCode = "INSP_DT"
            });

            SearchObject.resultDefn = new Models.resultDefn();
            SearchObject.resultDefn.attributes = Attributes;

            SearchObject.sortAttributes = null;

            return Newtonsoft.Json.JsonConvert.SerializeObject(SearchObject);
        }
    }
}
