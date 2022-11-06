using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    public class EncriptadorCesar : Encriptador
    {
        //FIELDS
        private char[] _Caracteres = { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
            'H', 'I', 'J', 'K',
            'L', 'M', 'N', ' ', 'Ñ', 'O', 'P', 'Q', 'R', 'S',
            'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1' };

        private readonly int _code = 15;//Paso para cambiar una letra por otra

        //CONSTRUCTOR
        public EncriptadorCesar() : base("Cesar") { }

        //METHODS
        public override string Desencriptar(string pCadenaEncriptada)
        {
            return this.Encriptar(pCadenaEncriptada);
        }

        public override string Encriptar(string pCadenaNoEncriptada)
        {
            //Si la cadena del parámetro está vacía, devolvemso la cadena vacía:
            if (pCadenaNoEncriptada.Length == 0) { return ""; }

            //Encriptación:
            string cadenaEnMayus = pCadenaNoEncriptada.ToUpper();
            string cadenaEncriptada = "";

            for (int i = 0; i < cadenaEnMayus.Length; i++) 
            {
                for (int j = 0; j < _Caracteres.Length; j++)
                {
                    if (cadenaEnMayus[i] == _Caracteres[j])
                    {
                        if (j + _code > _Caracteres.Length - 1) 
                        { cadenaEncriptada += _Caracteres[j - _code]; } 
                        else { cadenaEncriptada += _Caracteres[j + _code]; }

                        break;
                    }
                }
            }

            return cadenaEncriptada;

        }
    }
}
