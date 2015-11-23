using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D_Sante.Models.Persistance;
using System.Collections.Generic;
using D_Sante.Models.HealthServices;

namespace D_Sante.Tests.Models.Persistance
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void CreateMedicament_ReadMedicaments_GetTheCreatedMedicament_DeleteMedicament()
        {
            using (IDal dal = new Dal())
            {
                //Create

                Dictionary<string, string> Attrs = new Dictionary<string, string>();
                Attrs["Name"] = "Doliprane";
                Attrs["Price"] = "20";
                Attrs["Form"] = "Injectable";
                Attrs["Description"] = "bla bla bla bla";
                Medicament M = new Medicament { Name = Attrs["Name"], Price = float.Parse(Attrs["Price"]), Description = Attrs["Description"], Form = Attrs["Form"] };
                dal.CreateMedicament(M);
                //Read
                List<Medicament> Ms = dal.ReadMedicaments();
                Assert.IsNotNull(Ms);
                Assert.AreEqual(1, Ms.Count);
                Assert.AreEqual("Doliprane", Ms[0].Name);
                Assert.AreEqual(20, Ms[0].Price);
                Assert.AreEqual("Injectable", Ms[0].Form);
                Assert.AreEqual("bla bla bla bla", Ms[0].Description);

                //Delete
                dal.DeleteMedicament(M.Id);
                Assert.IsNotNull(Ms);
                //Read
                Ms = dal.ReadMedicaments();
                Assert.AreEqual(0, Ms.Count);
            }
        }
        [TestMethod]
        public void CreateMedicament_ReadMedicaments_UpdateMedicament_ReadMedicament_DeleteMedicament()
        {
            using (IDal dal = new Dal())
            {
                //Create

                Dictionary<string, string> Attrs = new Dictionary<string, string>();
                Attrs["Name"] = "Doliprane";
                Attrs["Price"] = "20";
                Attrs["Form"] = "Injectable";
                Attrs["Description"] = "bla bla bla bla";
                Medicament M = new Medicament { Name = Attrs["Name"], Price = float.Parse(Attrs["Price"]), Description = Attrs["Description"], Form = Attrs["Form"] };
                dal.CreateMedicament(M);
                //Read
                List<Medicament> Ms = dal.ReadMedicaments();
                Assert.IsNotNull(Ms);
                Assert.AreEqual(1, Ms.Count);
                Assert.AreEqual("Doliprane", Ms[0].Name);
                Assert.AreEqual(20, Ms[0].Price);
                Assert.AreEqual("Injectable", Ms[0].Form);
                Assert.AreEqual("bla bla bla bla", Ms[0].Description);
                //Update
                int LId=M.Id;
                Attrs["Name"] = "Doliprane";
                Attrs["Price"] = "90";
                Attrs["Form"] = "Injectable";
                Attrs["Description"] = "bla bla bla bla";
                M = new Medicament {Id=LId,Name = Attrs["Name"], Price = float.Parse(Attrs["Price"]), Description = Attrs["Description"], Form = Attrs["Form"] };
                dal.UpdateMedicament(M);
                //Read
                Ms = dal.ReadMedicaments();
                Assert.IsNotNull(Ms);
                Assert.AreEqual(LId, Ms[0].Id);
                //Assert.AreEqual("Doliprane", Ms[0].Name);
                Assert.AreEqual(90, Ms[0].Price);
                //Assert.AreEqual("Injectable", Ms[0].Form);
                //Assert.AreEqual("bla bla bla bla", Ms[0].Description);
                
                
                //Delete
                dal.DeleteMedicament(M.Id);
                Assert.IsNotNull(Ms);
                //Read
                Ms = dal.ReadMedicaments();
                Assert.AreEqual(0, Ms.Count);
            }
        }
    }
}
