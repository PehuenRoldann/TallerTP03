using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Veterinaria
{
    internal class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau!");
        }
    }

}
