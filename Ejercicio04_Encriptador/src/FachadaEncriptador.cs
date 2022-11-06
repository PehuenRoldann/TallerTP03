using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    internal class FachadaEncriptador
    {
        //METHODS
        /// <summary>
        /// Encripta una cadena pasada como parámetro.
        /// </summary>
        /// <param name="pCadenaSinEncriptar">Cadena de caracteres que se quiere encriptar.</param>
        /// <param name="pTipoEncriptador">Tipo de encriptador pasado como parámetro: <br></br>
        /// AES: Advanced Encriptation Standard. <br></br>
        /// CESAR: Cesar Encriptation. <br></br>
        /// Cualquier otro tipo pasado como parámetro devuelve un encriptador nulo.</param>
        /// <returns></returns>
        public string EncriptarCadena(string pCadenaSinEncriptar, string pTipoEncriptador)
        {
            FabricaEncriptadores fabricaEncriptadores = FabricaEncriptadores.GetInstance();

            Encriptador encriptador = fabricaEncriptadores.GetEncriptador(pTipoEncriptador);

            return encriptador.Encriptar(pCadenaSinEncriptar);
        }

        /// <summary>
        /// Desencripta una cadena pasada como parámetro.
        /// </summary>
        /// <param name="pCadenaSinEncriptar">Cadena de caracteres que se quiere desencriptar.</param>
        /// <param name="pTipoEncriptador">Tipo de encriptador pasado como parámetro: <br></br>
        /// AES: Advanced Encriptation Standard. <br></br>
        /// CESAR: Cesar Encriptation. <br></br>
        /// Cualquier otro tipo pasado como parámetro devuelve un encriptador nulo.</param>
        /// <returns></returns>
        public string DesencriptarCadena(string pCadenaEncriptada, string pTipoEncriptador)
        {
            FabricaEncriptadores fabricaEncriptadores = FabricaEncriptadores.GetInstance();

            Encriptador encriptador = fabricaEncriptadores.GetEncriptador(pTipoEncriptador);

            return encriptador.Desencriptar(pCadenaEncriptada);
        }

    }
}
