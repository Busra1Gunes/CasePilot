﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ApplicationType:Entity //Basvuru Türü
    {
        public int CaseTypeID { get; set; } 
        public string Name { get; set; } 
       
    }
}
