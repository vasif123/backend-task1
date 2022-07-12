﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_6.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
