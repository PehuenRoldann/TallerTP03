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
        private byte _nivelPrioridad;
        private int _idSala;

        //CONSTRUCTOR
        public Turno(string pNombre, DateTime pFecha, int pIdSala, byte pNivelPrioridad)
        {
            _nombre = pNombre;
            _fecha = pFecha;
            _idSala = pIdSala;
            _finalizado = false;
        }

        //PROPIEDADES
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Finalizado { get => _finalizado; set => _finalizado = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public byte NivelPrioridad { get => _nivelPrioridad; set => _nivelPrioridad = value; }
        public int IdSala { get => _idSala; set => _idSala = value; }

        //MÉTODO

        /// <summary>
        /// Método que comprueba si el turno actual sucede antes de otro turno.
        /// </summary>
        /// <param name="pOtroTurno">Turno para comparar</param>
        /// <returns>
        /// True si el turno actual es antes.<br></br> False si es después del otro turno.
        /// </returns>
        public bool AntesDe(Turno pOtroTurno)
        {
            if (this.Fecha.CompareTo(pOtroTurno.Fecha) < 0) { return true; }
            else { return false; }
        }


    }
}
