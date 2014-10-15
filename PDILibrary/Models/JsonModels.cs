using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Model
{
    public class Login
    {
        public string email { get; set; }
        public string password { get; set; }
        //public string deviceToken { get; set; }
        //public string deviceOS { get; set; }
    }

    public class form
    {
        [DataMember(Name = "meta")]
        public meta meta { get; set; }
    }

    public class signin
    {
        [DataMember(Name = "meta")]
        public meta meta { get; set; }

        [DataMember(Name = "items")]
        public List<item> items { get; set; }
    }

    public class retrieve
    {
        [DataMember(Name = "meta")]
        public meta meta { get; set; }

        [DataMember(Name = "items")]
        public List<retrieveItem> items { get; set; }
    }

    public class meta
    {
        [DataMember(Name = "status")]
        public string status { get; set; }

        [DataMember(Name = "resultSize")]
        public int resultSize { get; set; }

        [DataMember(Name = "request")]
        public string request { get; set; }

        [DataMember(Name = "responseTime")]
        public int responseTime { get; set; }
    }

    public class item
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "businessEntity")]
        public businessEntity businessEntity { get; set; }

        [DataMember(Name = "typeCode")]
        public string typeCode { get; set; }

        [DataMember(Name = "roles")]
        public List<roles> roles { get; set; }

        [DataMember(Name = "isActive")]
        public bool isActive { get; set; }

        [DataMember(Name = "locale")]
        public locale locale { get; set; }

        [DataMember(Name = "timezone")]
        public string timezone { get; set; }

        [DataMember(Name = "tenant")]
        public tenant tenant { get; set; }
    }

    public class businessEntity
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "typeCode")]
        public string typeCode { get; set; }

        [DataMember(Name = "logo")]
        public string logo { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name="addresses")]
        public List<addresses> addresses { get; set; }

        [DataMember(Name = "intl")]
        public List<intl> intl { get; set; }

        [DataMember(Name = "beBrand")]
        public List<beBrand> beBrand { get; set; }
    }

    public class addresses
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "entityAddress")]
        public entityAddress entityAddress { get; set; }
    }

    public class entityAddress
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "type")]
        public string Shipping { get; set; }

        [DataMember(Name = "address1")]
        public string address1 { get; set; }

        [DataMember(Name = "address2")]
        public string address2 { get; set; }

        [DataMember(Name = "zip")]
        public string zip { get; set; }

        [DataMember(Name = "city")]
        public string city { get; set; }

        [DataMember(Name = "country")]
        public country country { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }
    }

    public class country
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "code3")]
        public string code3 { get; set; }
    }

    public class intl
    {
        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "description")]
        public string description { get; set; }
    }

    public class beBrand
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "brand")]
        public brand brand { get; set; }
    }

    public class brand
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "department")]
        public string department { get; set; }

        [DataMember(Name = "website")]
        public string website { get; set; }

        [DataMember(Name = "registered")]
        public string registered { get; set; }

        [DataMember(Name = "brandName")]
        public string brandName { get; set; }

        [DataMember(Name = "brandId")]
        public string brandId { get; set; }
    }

    public class roles
    { 
        [DataMember(Name = "createdDate")]
        public DateTime createdDate { get; set; }
        
        [DataMember(Name = "updatedDate")]
        public DateTime updatedDate { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "description")]
        public string description { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "active")]
        public string active { get; set; }
    }

    public class locale
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "isActive")]
        public string isActive { get; set; }

        [DataMember(Name = "languageCode")]
        public string languageCode { get; set; }

        [DataMember(Name = "countryCode")]
        public string countryCode { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }
    }

    public class tenant
    {
        [DataMember(Name = "createdDate")]
        public DateTime createdDate { get; set; }

        [DataMember(Name = "updatedDate")]
        public DateTime updatedDate { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "typeCode")]
        public string typeCode { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "currencyCode")]
        public string currencyCode { get; set; }

        [DataMember(Name = "addresses")]
        public List<addresses> addresses { get; set; }

        [DataMember(Name = "intl")]
        public List<intl> intl { get; set; }
    }

    public class searchResults
    {
        [DataMember(Name = "entityName")]
        public string entityName { get; set; }
    }

    public class retrieveItem
    {
        [DataMember(Name = "createdDate")]
        public DateTime createdDate { get; set; }

        [DataMember(Name = "updatedDate")]
        public DateTime updatedDate { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "inspectionCode")]
        public string inspectionCode { get; set; }

        [DataMember(Name = "inspectionType")]
        public string inspectionType { get; set; }

        [DataMember(Name = "inspectionStatus")]
        public string inspectionStatus { get; set; }

        [DataMember(Name = "inspectionDate")]
        public DateTime inspectionDate { get; set; }

        [DataMember(Name = "number")]
        public string number { get; set; }

        [DataMember(Name = "formInstance")]
        public formInstance formInstance { get; set; }
    }

    public class formInstance
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "formDefinition")]
        public formDefinition formDefinition { get; set; }
    }

    public class formDefinition
    {
        [DataMember(Name = "createdDate")]
        public DateTime createdDate { get; set; }

        [DataMember(Name = "updatedDate")]
        public DateTime updatedDate { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "tenant")]
        public retrieveTenant tenant { get; set; }

        [DataMember(Name = "formCode")]
        public string formCode { get; set; }

        [DataMember(Name = "versionNumber")]
        public string versionNumber { get; set; }

        [DataMember(Name = "statusCode")]
        public string statusCode { get; set; }

        [DataMember(Name = "isActive")]
        public string isActive { get; set; }

        [DataMember(Name = "startDate")]
        public DateTime startDate { get; set; }

        [DataMember(Name = "endDate")]
        public DateTime endDate { get; set; }

        [DataMember(Name = "form")]
        public SectionForm form { get; set; }
    }

    public class retrieveTenant
    {
        [DataMember(Name = "createdDate")]
        public DateTime createdDate { get; set; }

        [DataMember(Name = "updatedDate")]
        public DateTime updatedDate { get; set; }
        
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "typeCode")]
        public string typeCode { get; set; }

        [DataMember(Name = "currencyCode")]
        public string currencyCode { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "addresses")]
        public List<addresses> addresses { get; set; }

        [DataMember(Name = "intl")]
        public List<intl> intl { get; set; }

        [DataMember(Name = "beBrand")]
        public List<beBrand> beBrand { get; set; }

        [DataMember(Name = "formCode")]
        public string formCode { get; set; }

        [DataMember(Name = "versionNumber")]
        public string versionNumber { get; set; }

        [DataMember(Name = "statusCode")]
        public string statusCode { get; set; }
    }

    public class formDefinitionData
    {
        [DataMember(Name = "formDefname")]
        public string formDefname { get; set; }

        [DataMember(Name = "sectiongroups")]
        public List<sectiongroups> sectiongroups { get; set; }
    }

    public class sectiongroups
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "label")]
        public label label { get; set; }

        [DataMember(Name = "sections")]
        public List<sections> sections { get; set; }
    }

    public class sections
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "label")]
        public label label { get; set; }

        [DataMember(Name = "fields")]
        public List<fields> fields { get; set; }
    }

    public class fields
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "field_number")]
        public string field_number { get; set; }

        [DataMember(Name = "fieldType")]
        public string fieldType { get; set; }

        [DataMember(Name = "fieldLabel")]
        public string fieldLabel { get; set; }

        [DataMember(Name = "sameRow")]
        public string sameRow { get; set; }

        [DataMember(Name = "required")]
        public bool required { get; set; }

        [DataMember(Name = "fieldValue")]
        public string fieldValue { get; set; }

        [DataMember(Name = "fieldNotes")]
        public string fieldNotes { get; set; }

        [DataMember(Name = "placeHolder")]
        public string placeHolder { get; set; }
    }

    public class SectionForm
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "label")]
        public label label { get; set; }

        [DataMember(Name = "sectionGroups")]
        public List<sectiongroups> sectionGroups { get; set; }
    }

    public class label
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "code")]
        public string code { get; set; }

        [DataMember(Name = "intl")]
        public List<intl> intl { get; set; }
    }

}
