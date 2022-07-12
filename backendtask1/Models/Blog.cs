using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_6.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string DescImage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
