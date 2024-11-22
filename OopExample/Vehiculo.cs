using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExample
{
    // Ejemplo de Encapsulación
    public abstract class Vehiculo
    {
        public int NumeroDeAsientos { get; set; }
        public bool TieneChasis { get; set; }
        public int NumeroDeRuedas { get; set; }
        public string TamanoDeMotor { get; set; }

        public abstract void MostrarInformacion();
    }
}
