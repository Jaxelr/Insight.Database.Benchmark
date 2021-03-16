using System;
using System.Runtime.Serialization;

namespace Insight.Database.Benchmarks.SqlServer.Models
{
    public class PostXml
    {
        public int Id { get; set; }

        public ChildXml Child { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastChangeDate { get; set; }
    }

    [DataContract]
    public class ChildXml
    {
        [DataMember]
        public string Text { get; set; }
    }
}
