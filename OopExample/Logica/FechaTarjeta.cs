using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExample
{
    public class FechaTarjeta
    {
        public static DateTime FechaExpedicionTarjeta()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual;
        }

        public static DateTime FechaVencimientoTarjeta(DateTime fechaActual)
        {
            DateTime fechaVencimiento = fechaActual.AddYears(6);
            return fechaVencimiento;
        }
    }
}
