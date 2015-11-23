﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_Sante.Models.HealthServices;

namespace D_Sante.Models.DataFromWeb
{
    interface IGetData
    {
        List<Medicament> GetMedicaments();
        List<Hospital> GetHospitals();
    }
}
