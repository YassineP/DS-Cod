﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.HealthServices
{
    public abstract class MedicalEstablishment : HealthService
    {
        public string Town { get; set; }
        public string Address { get; set; }

    }
}