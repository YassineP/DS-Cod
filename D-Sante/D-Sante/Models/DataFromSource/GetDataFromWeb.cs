using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using D_Sante.Models.HealthServices;
using HtmlAgilityPack;

namespace D_Sante.Models.DataFromSource
{
    public class GetDataFromWeb : IGetData
    {
         private HtmlWeb getHtmlWeb;
        public List<Medicament> GetMedicaments()
        {
            List<Medicament> list = new List<Medicament>();
            string url = "http://medicament.ma/listing-des-medicaments/";
            string xpathString = "//div[@class='pages catalogue']/ul/li/a";
            getHtmlWeb = new HtmlWeb();
            try
            {
                Console.WriteLine("Search for drugs begening ");
                Console.WriteLine("----------------------------------------------");
                HtmlDocument htmlDoc = getHtmlWeb.Load(url);
                HtmlDocument drugInfo = null;
                Medicament medicament = null;
                int i;
                string[] attrs = new string[4];
                foreach (var item in htmlDoc.DocumentNode.SelectNodes(xpathString))
                {
                    i = 0;
                    drugInfo = getHtmlWeb.Load(item.GetAttributeValue("href", ""));
                    medicament = new Medicament();
                    medicament.Name =  drugInfo.DocumentNode.SelectSingleNode("//legend").InnerText;
                    foreach (var info in drugInfo.DocumentNode.SelectNodes("//table/tr/td[@class='value']"))
                    {
                        attrs[i++] = info.InnerText;
                    }
                    medicament.Presentation = attrs[0];
                    medicament.Composition = attrs[2];
                    //medicament.Price = float.Parse()
                    list.Add(medicament);
                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Search is end");
            return list;
        }
<<<<<<< HEAD:D-Sante/D-Sante/Models/DataFromWeb/GetDataFromWeb.cs
        public void GetHospitals()
        {

=======

        public  List<Hospital> GetHospitals()
        {
            return null;
>>>>>>> origin/master:D-Sante/D-Sante/Models/DataFromSource/GetDataFromWeb.cs
        }
    }
}