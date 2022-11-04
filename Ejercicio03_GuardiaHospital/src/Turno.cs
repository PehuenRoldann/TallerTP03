using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public class Turno
    {
        //CAMPOS
        private string _nombre;
        private bool _finalizado;
        private DateTime _fecha;
        private Nivel _nivelPrioridad;
        private int _idSala;

        //CONSTRUCTOR
        /// <summary>
        /// Crea una nueva instancia de la clase Turno.
        /// </summary>
        /// <param name="pNombre">Nombre del paciente.</param>
        /// <param name="pFecha">Fecha del turno</param>
        /// <param name="pIdSala">Numero de sala</param>
        /// <param name="pPrioridad">Valor númerico de prioridad</param>
        /// <param name="pDescripcion">Descripcion de la prioridad</param>
        public Turno(string pNombre, DateTime pFecha, int pIdSala, int pPrioridad, string pDescripcion)
        {
            _nombre = pNombre;
            _fecha = pFecha;
            _idSala = pIdSala;
            _finalizado = false;
            _nivelPrioridad = new Nivel(pPrioridad, pDescripcion);
        }

        //PROPIEDADES
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Finalizado { get => _finalizado; set => _finalizado = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public Nivel NivelPrioridad { get => _nivelPrioridad; set => _nivelPrioridad = value; }
        public int IdSala { get => _idSala; set => _idSala = value; }

        //MÉTODO

        /// <summary>
        /// Finaliza el turno actual.
        /// </summary>
        public void Finalizar()
        {
            this.Finalizado = true;
        }


    }
}
