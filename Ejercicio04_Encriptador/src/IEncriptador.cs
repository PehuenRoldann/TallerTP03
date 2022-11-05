using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    public interface IEncriptador
    {
        /// <summary>
        /// Encripta una cadena de caracteres pasada como parámetro.
        /// </summary>
        /// <param name="pCadenaNoEncriptada">Cadena sin encriptar.</param>
        /// <returns>Cadena encriptada</returns>
        public string Encriptar( string pCadenaNoEncriptada);

        /// <summary>
        /// Desencripta una cadena de caracteres pasada como parámetro.
        /// </summary>
        /// <param name="pCadenaEncriptada">Cadena encriptada.</param>
        /// <returns>Cadena desencriptada.</returns>
        public string Desencriptar (string pCadenaEncriptada);

    }
}
