using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public class SalaUrgencias : ISala
    {
        /// <summary>
        /// Encuentra el turno con mayor prioridad de un array con instancias de Turno.
        /// </summary>
        /// <param name="pArrayTurnos">Array con instancias de Turno</param>
        /// <returns>Turno más reciente.</returns>
        /// <exception cref="StackOverflowException">Si el array no contiene elementos.</exception>
        public Turno TurnoActual(Turno[] pArrayTurnos)
        {
            //Ordenamos por nivel de prioridad 1...5, y devolvemos el primer turno
            return pArrayTurnos.OrderBy(turno => turno.NivelPrioridad.Prioridad).First();
        }
    }
}
