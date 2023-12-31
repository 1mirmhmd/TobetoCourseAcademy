﻿using Entities.Abstracts;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Descrption { get; set; }
        public List<Course> Courses { get; set; }
        public List<Product> Products{ get; set; }
    }
}
