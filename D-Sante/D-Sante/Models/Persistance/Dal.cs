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
        public void CreateHospital(Hospital hospital)
        {
            Db.Hospitals.Add(hospital);
            Db.SaveChanges();
        }
        public void UpdateHospital(Hospital hospital)
        {
            Db.Hospitals.SqlQuery(@"UPDATE Hospital SET Name=@name, Description=@desc,
            Town=@town, Addesse=@adress WHERE Id=@id", hospital.Name, hospital.Description
                                  , hospital.Town, hospital.Address, hospital.Id);
            Db.SaveChanges();

        }

        public Hospital SelectHospitalById(int Id)
        {
            return Db.Hospitals.Find(Id);
        }



        public void DeleteHospital(Hospital hospital)
        {
            Db.Hospitals.Remove(hospital);
            Db.SaveChanges();
        }

        public void DeleteHospitalById(int Id)
        {
            Db.Hospitals.Remove(Db.Hospitals.Find(Id));
            Db.SaveChanges();
        }

        public List<Hospital> ReadHospitals()
        {
            return Db.Hospitals.ToList();
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}