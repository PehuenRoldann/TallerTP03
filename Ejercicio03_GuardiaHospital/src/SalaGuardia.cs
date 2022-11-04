using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public class SalaGuardia
    {   
        //FIELDS
        private ISala _Sala;
        private int _Id;

        //CONSTRUCTOR
        /// <summary>
        /// Crea una nueva instancia de la clase SalaGuardia.
        /// </summary>
        /// <param name="pId">Id de la sala.</param>
        /// <param name="pSala">Estrategia de la sala.</param>
        public SalaGuardia(int pId)
        {
            _Id = pId;
        }

        //PROPERTYS
        public int Id { get => _Id; set => _Id = value; }

        //METHODS
        /// <summary>
        /// Establece el tipo de sala de la instancia.
        /// </summary>
        /// <param name="pSala">Instancia de una sala</param>
        public void SetSalaType(ISala pSala)
        {
            _Sala = pSala;
        }

        /// <summary>
        /// Optiene el proximo turno de la sala
        /// </summary>
        /// <returns>Devuelve un Array de strings con los datos del turno en el siguiente orden:<br></br>
        /// 0 = nombre del paciente
        /// 1 = horario
        /// 2 = prioridad <br></br> Devuelve null si no hay turnos para la sala el día de hoy.
        /// </returns>
        public string[]? ProximoTurno()
        {
            if (_Sala == null) {return null;}

            Repository repository = new Repository();
            Turno[] arrayTurnosHoy = repository.GetTurnosBetweenDates(_Id, DateTime.Today, DateTime.Today.AddDays(1));
            //Comprobamos que haya turnos para buscar
            if (arrayTurnosHoy.Length == 0) {return null;}

            Turno turnoActual = _Sala.TurnoActual(arrayTurnosHoy);
            return new string[] {turnoActual.Nombre, turnoActual.Fecha.ToString(),
                                 turnoActual.NivelPrioridad.Descripcion};
        }

        /// <summary>
        /// Devuelve una lista con datos de los turnos en un array de strings.
        /// </summary>
        /// <returns>Si hay turnos: Array de strings con los datos de los turnos. <br></br> Si no hay turnos: null.</returns>
        public string[]? Turnos()
        {
            Repository repository = new Repository();
            Turno[] arrayTurnosHoy = repository.GetTurnosBetweenDates(_Id, DateTime.Today, DateTime.Today.AddDays(1));
            //Comprobamos que haya turnos para buscar
            if (arrayTurnosHoy.Length == 0) { return null; }

            string[] turnosResultado = new string[arrayTurnosHoy.Length];
            int i = 0;
            foreach(Turno turno in arrayTurnosHoy.OrderBy(turno => turno.Fecha))
            {
                turnosResultado[i] = $"HORARIO: {turno.Fecha.ToString()}; PACIENTE: {turno.Nombre}; PRIORIDAD: {turno.NivelPrioridad.Descripcion}";
            }

            return turnosResultado;


        }
    }
}
