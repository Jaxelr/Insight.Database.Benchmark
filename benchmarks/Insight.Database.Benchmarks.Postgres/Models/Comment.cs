﻿namespace Insight.Database.Benchmarks.Postgres.Models
{
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string CommentText { get; set; }
    }
}
