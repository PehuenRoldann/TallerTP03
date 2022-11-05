using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    public struct Datos
    {
        //BASES DE DATOS
        static private SalaGuardia[] _Salas = new SalaGuardia[2];
        static private Turno[] _Turnos = new Turno[20];

        static public Turno[] Turnos { get => _Turnos; set => _Turnos = value; }
        static public SalaGuardia[] Salas { get => _Salas; set => _Salas = value; }


    }
}
