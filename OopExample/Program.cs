using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de tarjeta: ");
            Console.WriteLine("1. Tarjeta de Crédito");
            Console.WriteLine("2. Tarjeta de Débito");
            int opcion = int.Parse(Console.ReadLine());

            // Ingresa la información
            Console.WriteLine("\nIngrese el número de tarjeta:");
            string numeroDeTarjeta = Console.ReadLine();

            Console.WriteLine("\nIngrese el nombre en la tarjeta:");
            string nombreEnLaTarjeta = Console.ReadLine();

            DateTime fechaExpedicion = FechaTarjeta.FechaExpedicionTarjeta();
            DateTime fechaVencimiento = FechaTarjeta.FechaVencimientoTarjeta(fechaExpedicion);

            Tarjeta tarjeta;

            if (opcion == 1)
            {
                tarjeta = new TarjetaCredito(numeroDeTarjeta, nombreEnLaTarjeta, fechaExpedicion, fechaVencimiento);
            }
            else if (opcion == 2)
            {
                tarjeta = new TarjetaDebito(numeroDeTarjeta, nombreEnLaTarjeta, fechaExpedicion, fechaVencimiento);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            // Display card details
            Console.WriteLine($"\nTipo de Tarjeta: {(tarjeta is TarjetaCredito ? "Crédito" : "Débito")}");
            Console.WriteLine($"Número de Tarjeta: {tarjeta.NumeroDeTarjeta}");
            Console.WriteLine($"Nombre en la Tarjeta: {tarjeta.NombreEnLaTarjeta}");
            Console.WriteLine($"Fecha de Expedición: {tarjeta.FechaDeExpedicion.ToShortDateString()}");
            Console.WriteLine($"Fecha de Vencimiento: {tarjeta.FechaDeVencimiento.ToShortDateString()}");

            Console.ReadLine();
        }
    }

    class TarjetaCredito:Tarjeta
    {
        public TarjetaCredito(string numeroDeTarjeta, string nombreEnLaTarjeta, DateTime fechaExpedicion, DateTime fechaVencimiento)
        {
            NumeroDeTarjeta = numeroDeTarjeta;
            NombreEnLaTarjeta = nombreEnLaTarjeta;
            FechaDeExpedicion = fechaExpedicion;
            FechaDeVencimiento = fechaVencimiento;
        }
    }

    class TarjetaDebito:Tarjeta
    {
        public TarjetaDebito(string numeroDeTarjeta, string nombreEnLaTarjeta, DateTime fechaExpedicion, DateTime fechaVencimiento)
        {
            NumeroDeTarjeta = numeroDeTarjeta;
            NombreEnLaTarjeta = nombreEnLaTarjeta;
            FechaDeExpedicion = fechaExpedicion;
            FechaDeVencimiento = fechaVencimiento;
        }
    }
}
