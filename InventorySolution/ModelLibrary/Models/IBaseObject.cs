﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public interface IBaseObject
    {
        int Id { get; set; }

        string Name { get; set; }

        void Print();
    }
}
