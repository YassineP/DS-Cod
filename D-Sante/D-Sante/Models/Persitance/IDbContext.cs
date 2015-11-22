using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using D_Sante.Models.HealthServices;
namespace D_Sante.Models.Persitance
{
    public class IDbContext : DbContext
    {
        public DbSet<Drug> Medicaments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
    }
}