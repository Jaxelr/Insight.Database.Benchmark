using System;
using System.Collections.Generic;

namespace Insight.Database.Benchmarks.Postgres.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastChangeDate { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
