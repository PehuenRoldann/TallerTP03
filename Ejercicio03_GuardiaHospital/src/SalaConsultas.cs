using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public class SalaConsultas : ISala
    {
       
        /// <summary>
        /// Devuelve el proximo turno a ser atendido de un array que contiene instancias de la clase Turno. <br></br>
        /// El turno se obtiene por orden de llegada.
        /// </summary>
        /// <param name="pArrayTurnos">Lista de turnos.</param>
        /// <returns>El turno actual a ser atendido. <br></br> StackOverflowException si no hay turnos en el array.</returns>
        /// <exception cref="StackOverflowException"></exception>
        public Turno TurnoActual(Turno[] pArrayTurnos)
        {
            //Ordenamos los turnos por fecha de llegada y devolvemos el primero
            return pArrayTurnos.OrderBy(turno => turno.Fecha).First();
        }
    }
}
