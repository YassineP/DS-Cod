using D_Sante.Models.HealthServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sante.Models.Persistance
{
    public interface IDal : IDisposable
    {
        //Medicaments
        void CreateMedicament(Medicament M);
        List<Medicament> ReadMedicaments();
        void UpdateMedicament(Medicament M);
        void DeleteMedicament(int Id);
        //Hospitals
        //void CreateHospital(Dictionary<string, string> Attrs);
        //List<Hospital> ReadHospitals();
        //void UpdateHospital(Dictionary<string, string> Attrs);
        //void DeleteHospital(Dictionary<string, string> Attrs);

    }
}