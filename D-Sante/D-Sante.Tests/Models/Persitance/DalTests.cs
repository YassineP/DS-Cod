using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D_Sante.Models.Persistance;
using D_Sante.Models.HealthServices;
using System.Collections.Generic;

namespace D_Sante.Tests.Models.Persitance
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void CreateHospital_ReadHospitals_GetTheCreatedHospital()
        {
            using (IDal dal = new Dal())
            {
                dal.CreateHospital(new Hospital() { Name = "Ibno Rochd", Description = "Description", Town = "Casablanca", Address = "address" });
                List<Hospital> hospitals = dal.ReadHospitals();
                Assert.IsNotNull(hospitals);
                Assert.AreEqual("Ibno Rochd", hospitals[0].Name);
                Assert.AreEqual("Description", hospitals[0].Description);
                Assert.AreEqual("Casablanca", hospitals[0].Town);
                Assert.AreEqual("address", hospitals[0].Address);
            }
        }

         [TestMethod]
        public void RemoveHospital_ReadHospitals_GetTheCreatedHospital()
        {
            using (IDal dal = new Dal())
            {
                List<Hospital> hospitals = dal.ReadHospitals();
                Hospital hospital = hospitals[0]; // entite à supprimer
                dal.DeleteHospital(hospital);
                hospitals = dal.ReadHospitals();
                Assert.IsNotNull(hospitals);
                Assert.AreEqual(hospitals.IndexOf(hospital), -1);
            }
        }


          [TestMethod]
         public void GetHospitalById(int Id)
         {
             using (IDal dal = new Dal())
             {
                 List<Hospital> hospitals = dal.ReadHospitals();
                 Hospital hospital_1 = hospitals[0];
                 int IdEntity = hospital_1.Id;
                 Hospital hospital_2 = dal.SelectHospitalById(Id);
                 Assert.IsNotNull(hospital_2);
                 Assert.AreEqual(IdEntity, hospital_2.Id);
             }
         }


         [TestMethod]
         public void UpdateHospital()
         {
             using (IDal dal = new Dal())
             {
                 List<Hospital> hospitals = dal.ReadHospitals();
                 Hospital hospital = hospitals[0]; // entite à modifier
                 hospital.Name = "Hassan 2";
                 hospital.Town = "Rabat";
                 dal.UpdateHospital(hospital);
                 Hospital hopital_2 = dal.SelectHospitalById(hospital.Id);
                 Assert.IsNotNull(hopital_2);
                 Assert.AreEqual(hopital_2.Name, "Hassan 2");
                 Assert.AreEqual(hopital_2.Town, "Rabat");
             }
         }
    }
}
