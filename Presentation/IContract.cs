  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Titanium.Presentation
{
    public interface IContract
    {

        void Ejecutar(int id, string producto,decimal precioCosto, decimal precio, int existencia);

        
    }
}
