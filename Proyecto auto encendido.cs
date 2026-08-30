using System;

namespace EjercicioPOO
{
    // Planos del codigo 
    {
        // ATRIBUTOS: Representan el ESTADO 
        private string marca;
        private bool motorEncendido;
        private int velocidad;

        // CONSTRUCTOR: Inicializa el objeto cuando se crea
        public Auto(string marca)
        {
            this.marca = marca;
            this.motorEncendido = false;
            this.velocidad = 0;
        }

        // MÉTODOS: Representan el COMPORTAMIENTO (acciones.)
        public void Encender()
        {
            motorEncendido = true;
            Console.WriteLine($"{marca}: Motor encendido.");
        }

        public void Acelerar(int incremento)
        {
            if (motorEncendido)
            {
                velocidad += incremento;
                Console.WriteLine($"{marca}: Acelerando a {velocidad} km/h.");
            }
            else
            {
                Console.WriteLine($"{marca}: Primero debes encender el motor.");
            }
        }

        public void Frenar()
        {
            velocidad = 0;
            Console.WriteLine($"{marca}: El auto se ha detenido.");
        }
    }

    class Program
    {
        static void Main()
        {
            // EL OBJETO: El auto físico estacionado en la calle
            Auto miAuto = new Auto("Toyota");

            // Interactuando con el objeto mediante sus métodos
            miAuto.Acelerar(20); // Fallará porque el motor está apagado
            miAuto.Encender();   // Cambia el estado del motor a encendido
            miAuto.Acelerar(50); // Cambia el estado de la velocidad a 50
            miAuto.Frenar();     // Cambia el estado de la velocidad a 0
        }
    }
}
