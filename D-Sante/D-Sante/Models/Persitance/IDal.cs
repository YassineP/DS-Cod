﻿using D_Sante.Models.HealthServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sante.Models.Persistance
{
    interface IDal : IDisposable
    {
        //Medicaments
        void CreateMedicament(Dictionary<string, string> Attrs);
        List<Medicament> ReadMedicaments();
        void UpdateMedicament(Dictionary<string, string> Attrs);
        void DeleteMedicament(Dictionary<string, string> Attrs);
        //Hospitals
        void CreateHospital(Dictionary<string, string> Attrs);
        List<Hospital> ReadHospitals();
        void UpdateHospital(Dictionary<string, string> Attrs);
        void DeleteHospital(Dictionary<string, string> Attrs);

    }
}