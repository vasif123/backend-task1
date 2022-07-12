using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_6.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
