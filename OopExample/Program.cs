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
            Carro miCarro = new Carro();
            Moto miMoto = new Moto();

            miCarro.Bocina();
            miMoto.Bocina();

            Console.ReadLine();
        }
    }

    // Ejemplo de Abstracción
    interface IVehiculo
    {
        void Bocina();
    }

    // Ejemplo de Herencia y Polimorfismo
    class Carro : Vehiculo, IVehiculo
    {
        public Carro()
        {
            NumeroDeAsientos = 4;
            TieneChasis = true;
            NumeroDeRuedas = 4;
            TamanoDeMotor = "mediano";
        }

        public void Bocina()
        {
            Console.WriteLine("Piit, piit!");
        }
    }

    class Moto : Vehiculo, IVehiculo
    {
        public Moto()
        {
            NumeroDeAsientos = 1;
            TieneChasis = false;
            NumeroDeRuedas = 2;
            TamanoDeMotor = "pequeño";
        }

        public void Bocina()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
