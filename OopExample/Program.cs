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
            Bicicleta miBici = new Bicicleta();

            miCarro.MostrarInformacion();
            miCarro.Bocina();

            miMoto.MostrarInformacion();
            miMoto.Bocina();

            miBici.MostrarInformacion();

            Console.ReadLine();
        }
    }

    // Ejemplo de Abstracción
    interface IInformacion
    {
        void MostrarInformacion();
    }

    interface IConBocina
    {
        void Bocina();
    }

    // Ejemplo de Herencia y Polimorfismo
    class Carro : Vehiculo, IConBocina
    {
        public Carro()
        {
            NumeroDeAsientos = 4;
            TieneChasis = true;
            NumeroDeRuedas = 4;
            TamanoDeMotor = "mediano";
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Carro - Ruedas: {NumeroDeRuedas}, Motor: {TamanoDeMotor}");
        }

        public void Bocina()
        {
            Console.WriteLine("Piit, piit!");
        }
    }

    class Moto : Vehiculo, IConBocina
    {
        public Moto()
        {
            NumeroDeAsientos = 1;
            TieneChasis = false;
            NumeroDeRuedas = 2;
            TamanoDeMotor = "pequeño";
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Moto - Ruedas: {NumeroDeRuedas}, Motor: {TamanoDeMotor}");
        }

        public void Bocina()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Bicicleta : Vehiculo
    {
        public Bicicleta()
        {
            NumeroDeAsientos = 1;
            NumeroDeRuedas = 2;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Bici - Ruedas: {NumeroDeRuedas}, Asientos: {NumeroDeAsientos}");
        }
    }
}
