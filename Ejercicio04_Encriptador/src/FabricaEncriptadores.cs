using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    internal class FabricaEncriptadores
    {

        //FIELDS
        private static FabricaEncriptadores _instance;

        //CONSTRUCTOR
        private FabricaEncriptadores() {}


        //METHODS
        /// <summary>
        /// Devuelve la instancia de la clase
        /// </summary>
        /// <returns>Instancia de la clase.</returns>
        static public FabricaEncriptadores GetInstance()
        {
            if (_instance == null) { _instance = new FabricaEncriptadores(); }

            return _instance;
        }

        /// <summary>
        /// Devuelve un encriptador del tipo pasado como parámetro.
        /// </summary>
        /// <param name="pTipoEncriptador">Tipo de encriptador pasado como parámetro: <br></br>
        /// AES: Advanced Encription Standard. <br></br>
        /// CESAR: Cesar Encription. <br></br>
        /// Cualquier otro tipo pasado como parámetro devuelve un encriptador nulo.
        /// </param>
        /// <returns></returns>
        public Encriptador GetEncriptador(string pTipoEncriptador)
        {

            if (pTipoEncriptador.ToUpper() == "CESAR") { return new EncriptadorCesar(); }
            else if (pTipoEncriptador.ToUpper() == "AES") { return new EncriptadorAES(); }
            else { return new EncriptadorNulo(); }
        }
    }
}
