﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.HealthServices
{
    public class Drug : MedicalProduct
    {
        public string Forme { get; set; }
        public virtual Laboratory Laboratory;
    }
}