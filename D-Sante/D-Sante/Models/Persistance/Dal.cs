using D_Sante.Models.HealthServices;
using D_Sante.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace D_Sante.Models.Persistance
{

    public class Dal : IDal
    {
        private DBContext Db;

        public Dal()
        {
            Db = new DBContext();
        }

        public List<Medicament> ReadMedicaments()
        {
            return Db.Medicaments.ToList();
        }
        public void CreateMedicament(Medicament M)
        {
            Db.Medicaments.Add(M);
            Db.SaveChanges();
        }
        public void DeleteMedicament(int Id)
        {
              
            Db.Medicaments.Remove(Db.Medicaments.Find(Id));
            Db.SaveChanges();
        }
        public void UpdateMedicament(Medicament M)
        {
            Medicament Med=Db.Medicaments.Find(M.Id);
            Med.Name = M.Name;
            Med.Price = M.Price;
            Med.Description = M.Description;
            Med.Form = M.Form;
            Db.SaveChanges();

        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}