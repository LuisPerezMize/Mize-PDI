using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PDILibrary.Models
{
    public class JsonSearchResult
    {
        public class meta
        {
            [DataMember(Name = "status")]
            public string status { get; set; }

            [DataMember(Name = "resultSize")]
            public int resultSize { get; set; }

            [DataMember(Name = "totalRecords")]
            public int totalRecords { get; set; }

            [DataMember(Name = "pageNumber")]
            public int pageNumber { get; set; }

            [DataMember(Name = "totalPages")]
            public int totalPages { get; set; }

            [DataMember(Name = "request")]
            public string request { get; set; }

            [DataMember(Name = "pageSize")]
            public int pageSize { get; set; }

            [DataMember(Name = "responseTime")]
            public int responseTime { get; set; }

            [DataMember(Name = "items")]
            public List<items> items { get; set; }
        }

        public class items
        {
            [DataMember(Name = "attributes")]
            public List<attributes> attributes { get; set; }
        }

        public class attributes
        {
            [DataMember(Name = "name")]
            public string name { get; set; }

            [DataMember(Name = "value")]
            public string value { get; set; }
        }
    }
}
