﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.HealthServices
{
    public abstract class MedicalProduct : HealthService
    {
        public float Price { get; set; }
       
    }
}