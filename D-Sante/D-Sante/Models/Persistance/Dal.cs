using D_Sante.Models.HealthServices;
using D_Sante.Models.Persistance;
using System;
using System.Collections.Generic;
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
        public void CreateMedicament(Dictionary<string, string> Attrs)
        {
           
        }

        public void UpdateMedicament(Dictionary<string, string> Attrs){ }

        public void DeleteMedicament(Dictionary<string, string> Attrs) { }
        //Hospitals
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