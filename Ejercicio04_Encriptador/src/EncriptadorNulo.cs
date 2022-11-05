using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    internal sealed class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo() : base("Null"){ }

        public override string Desencriptar(string pCadenaEncriptada)
        {
            return pCadenaEncriptada;
        }

        public override string Encriptar(string pCadenaNoEncriptada)
        {
            return pCadenaNoEncriptada;
        }
    }
}
