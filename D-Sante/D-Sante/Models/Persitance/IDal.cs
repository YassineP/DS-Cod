using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sante.Models.Persistance
{
    interface IDal<T> : IDisposable
    {
        void Create();
    }
}