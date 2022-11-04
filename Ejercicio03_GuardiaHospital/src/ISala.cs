using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public interface ISala
    {
        /// <summary>
        /// Obtiene el turno actual de la sala.
        /// </summary>
        /// <param name="listaTurnos">Array de turnos de la sala</param>
        /// <returns>Turno actual de la sala</returns>
        public Turno TurnoActual(Turno[] pArrayTurnos);

        /// <summary>
        /// Devuelve un string que contiene el nombre de la estrategia implementada.
        /// </summary>
        /// <returns>String</returns>
        public string GetTipoDeSala();

    }
}
