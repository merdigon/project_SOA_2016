﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Review : ResourceBase
    {
        public string Content { get; set; }
        public int Note { get; set; }
        public Movie Movie { get; set; }
    }
}
