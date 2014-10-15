using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Models
{
    public class searchPost
    {
        [DataMember(Name = "entityName")]
        public string entityName { get; set; }

        [DataMember(Name = "pageIndex")]
        public string pageIndex { get; set; }

        [DataMember(Name = "pageSize")]
        public string pageSize { get; set; }

        [DataMember(Name = "attributes")]
        public List<attributesRoot> attributes { get; set; }

        [DataMember(Name = "resultDefn")]
        public resultDefn resultDefn { get; set; }

        [DataMember(Name = "sortAttributes")]
        public string sortAttributes { get; set; }
    }

    public class resultDefn
    {
        [DataMember(Name = "attributes")]
        public List<attributes> attributes { get; set; }
    }

    public class attributes
    {
        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "label")]
        public string label { get; set; }

        [DataMember(Name = "hidden")]
        public string hidden { get; set; }

        [DataMember(Name = "alignment")]
        public string alignment { get; set; }

        [DataMember(Name = "labelCode")]
        public string labelCode { get; set; }
    }

    public class attributesRoot
    {
        [DataMember(Name = "value")]
        public string value { get; set; }

        [DataMember(Name = "condition")]
        public string condition { get; set; }
    }


}
