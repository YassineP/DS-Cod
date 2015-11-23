using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using D_Sante.Models.HealthServices;

namespace D_Sante.Models.Persistance
{
    public class DBContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
       
    }
}