﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Comment
    {

        public int Id { get; set; }

        public string Text { get; set; }

        

        public virtual Review Review { get; set; }

        


    }
}
