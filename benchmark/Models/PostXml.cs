using System;

namespace Insight.Database.Benchmark.Models
{
    public class PostXml
    {
        public int Id { get; set; }

        [Column(SerializationMode = SerializationMode.Xml)]
        public ChildXml Child { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastChangeDate { get; set; }
    }

    public class ChildXml
    {
        public string Text { get; set; }
    }
}
