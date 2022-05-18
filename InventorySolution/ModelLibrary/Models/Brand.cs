﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Brand : DbSimpleObject, ISimpleObject
    {
        public Brand(int id, string name, string description) : base(id, name, description) { }

        public Brand(string name, string description) : base(name, description) { }
    }
}
