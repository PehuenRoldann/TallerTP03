using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    public abstract class Encriptador : IEncriptador
    {
        //FIELDS
        private string _Nombre;

        //CONSTRUCTOR
        /// <summary>
        /// Crea una nueva instancia de la clase.
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador.</param>
        public Encriptador (string pNombre)
        {
            _Nombre = pNombre;
        }

        //PROPERTIES
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        //METHODS
        public abstract string Desencriptar(string pCadenaEncriptada);

        public abstract string Encriptar(string pCadenaNoEncriptada);


    }
}
