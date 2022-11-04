using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public class Repository
    {

        //METHODS
        /// <summary>
        /// Busca la una sala por ID en la base de datos
        /// </summary>
        /// <param name="pIdSala">Id de la sala</param>
        /// <returns>La sala si se encuentra en la base de datos <br></br> null si no se encuentra</returns>
        public SalaGuardia? GetSalaById(int pIdSala)
        {
            if (Datos.Salas.Length > 0 )
            {
                foreach (SalaGuardia sala in Datos.Salas)
                {
                    if (sala.Id == pIdSala) { return sala; }
                }
            }


            return null;
        }

        /// <summary>
        /// Retorna un Array con los turnos de la sala.
        /// </summary>
        /// <param name="pIdSala">Id de la sala.</param>
        /// <returns>Array inicializado con los turnos. <br></br> Si no hay turnos en la base de datos para esa sala, devuelve null.</returns>
        public Turno[] GetTurnosBetweenDates(int pIdSala, DateTime pFechaInicio, DateTime pFechaFin)
        {
            return Datos.Turnos.Where(turno => ((turno != null) 
                                      && (turno.IdSala == pIdSala)
                                      && (turno.Fecha > pFechaInicio)
                                      && (turno.Fecha < pFechaFin)
                                      )).ToArray();
        }

        /// <summary>
        /// Agenda un turno al Array de turnos.
        /// </summary>
        /// <param name="pTurno">Turno a agendar</param>
        /// <returns>True si se agendó correctamente. False en caso contrario.</returns>
        public bool AddTurno(Turno pTurno)
        {

            for (int i = 0; i < Datos.Turnos.Length; i++)
            {
                if (Datos.Turnos[i] == null)
                {
                    Datos.Turnos[i] = pTurno;
                    return true;//El turno se agendó
                }
            }

            return false;//El turno no fue agendado
        }

        /// <summary>
        /// Guarda una instancia de SalaGuardia en la DB.
        /// </summary>
        /// <param name="pSala">Instancia a guardar.</param>
        /// <returns>True si se guardó correctamente. <br></br> False si no se guardó correctamente.</returns>
        public bool AddSala(SalaGuardia pSala)
        {
            for (int i = 0; i < Datos.Salas.Length; i++)
            {
                if (Datos.Salas[i] == null)
                {
                    Datos.Salas[i] = pSala;
                    return true;//El turno se agendó
                }
            }

            return false;//El turno no fue agendado
        }

        public SalaGuardia[] GetSalas()
        {
            return Datos.Salas;
        }

    }
}
