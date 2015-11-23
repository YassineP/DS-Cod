using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.HealthServices
{
    public class Medicament : MedicalProduct
    {
        public string Form { get; set; }
        public string Composition { get; set; }
        public string Presentation { get; set; }
        //public virtual Laboratory Laboratory;
    }
}