using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.HealthServices
{
    public abstract class HealthService
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}