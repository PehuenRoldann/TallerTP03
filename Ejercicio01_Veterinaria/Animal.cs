using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Veterinaria
{
    internal abstract class Animal
    {
        public void Correr() { Console.WriteLine("corriendo"); }

        public void Saltar() { Console.WriteLine("saltando"); }

        public abstract void HacerRuido();
    }
}
