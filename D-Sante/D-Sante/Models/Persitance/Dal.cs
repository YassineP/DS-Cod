using D_Sante.Models.HealthServices;
using D_Sante.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Sante.Models.Persitance
{

    public class Dal : IDal
    {
        private IDbContext Db;

        public Dal()
        {
            Db = new IDbContext();
        }

        public List<Medicament> ReadMedicaments()
        {
            return Db.Medicaments.ToList();
        }
        public void CreateMedicament(Dictionary<string, string> Attrs)
        {
            Db.Medicaments.Add(new Medicament { Nom = Attrs['Nom'], Telephone = telephone });
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}