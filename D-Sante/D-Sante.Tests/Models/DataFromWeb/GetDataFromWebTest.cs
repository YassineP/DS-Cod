using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using D_Sante.Models.HealthServices;
using D_Sante.Models.DataFromWeb;

namespace D_Sante.Tests.Models.DataFromWeb
{
    [TestClass]
    public class GetDataFromWebTest
    {
        [TestMethod]
        public void GetMedicaments()
        {
            GetDataFromWeb datafw = new GetDataFromWeb();
            List<Medicament> list = datafw.GetMedicaments();
            Assert.IsNotNull(list);
            Assert.AreEqual(list.Count, 1);
        }
    }
}
