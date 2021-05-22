using System;

namespace Insight.Database.Benchmarks.Postgres.Models
{
    public class PostJson
    {
        public int Id { get; set; }

        [Column(SerializationMode = SerializationMode.Json)]
        public ChildJson Child { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastChangeDate { get; set; }
    }

    public class ChildJson
    {
        public string Text { get; set; }
    }
}
