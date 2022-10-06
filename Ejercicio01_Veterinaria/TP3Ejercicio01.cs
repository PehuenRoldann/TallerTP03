using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Veterinaria
{
    internal class TP3Ejercicio01
    {
        public static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();
            Animal[] animales = new Animal[2];

            animales[0] = new Gato();
            animales[1] = new Perro();

            veterinaria.AceptarAnimales(animales);
            Console.ReadKey();
        }
    }
}
