﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
   public abstract class Patient : Person
    {
        public int PatientID { get; set; }
    }
}
