using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExample
{
    public class Tarjeta
    {
        public int Id { get; set; }

        public string NumeroDeTarjeta { get; set; }

        public string NombreEnLaTarjeta { get; set; }

        public DateTime FechaDeExpedicion { get; set; }

        public DateTime FechaDeVencimiento { get; set; }
    }
}
