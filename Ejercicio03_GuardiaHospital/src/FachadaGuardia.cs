namespace Ejercicio03_GuardiaHospital.src
{
    internal class FachadaGuardia
    {

        public void InicializarSistema ()
        {
            this.AgregarSala(1, '1');//Sala de consultas
            this.AgregarSala(2, '2');//Sala de urgencias

            //Variable que nos ayudará a randomizar la asignación de prioridades para la sala de urgencias
            Dictionary<int, string> dict = new Dictionary<int, string> ();
            dict.Add(1, "ROJO");
            dict.Add(2, "NARANJA");
            dict.Add(3, "AMARILLO");
            dict.Add(4, "VERDE");
            dict.Add(5, "AZUL");

            Random r = new Random();

            //Agregamos 10 turnos a la sala de urgencias con prioridades aleatorias y horas que van aumentando:
            for (int i = 0; i < 10; i++)
            {
                int prioridad = r.Next(1, 6);
                int hora = r.Next(1, 24);
                int minuto = r.Next(0, 60);
                DateTime fechaHorarioTurno = DateTime.Today.AddHours(hora).AddMinutes(minuto);
                this.AgregarTurno($"Pacinte{i}", fechaHorarioTurno, 2, prioridad, dict[prioridad]);
            }

            //Agregamos 10 turnos para la sala de consultas con horarios aleatorios dentro del mismo día:
            for (int i = 0; i < 10; i++)
            {
                int hora = r.Next(1, 24);
                int minuto = r.Next(0, 60);
                DateTime fechaHorarioTurno = DateTime.Today.AddHours(hora).AddMinutes(minuto);
                this.AgregarTurno($"Paciente{i}", fechaHorarioTurno, 1, 5, "AZUL");
            }


        }
        /// <summary>
        /// Agreguega una nueva sala de consultas en la base de datos.
        /// </summary>
        /// <param name="pIdSala">Identificador de la sala a agregar.</param>
        /// <param name="pEstrategia">Estrategia de la sala: <br></br>'1' para Consultas <br></br> '2' Para urgencias.</param>
        /// <exception cref="ArgumentException">Si la estrategía no es una de las válidas.</exception>
        public void AgregarSala(int pIdSala, char pEstrategia)
        {
            SalaGuardia salaGuardia = new SalaGuardia(pIdSala);

            if (pEstrategia == '1') {
                ISala salaEstrategia = new SalaConsultas();
                salaGuardia.SetSalaType(salaEstrategia);
            }
            else if (pEstrategia == '2') { 
                ISala salaEstrategia = new SalaUrgencias();
                salaGuardia.SetSalaType(salaEstrategia);
            } else { throw new ArgumentException(); }
            Repository repository = new Repository();
            repository.AddSala(salaGuardia);
        }

        /// <summary>
        /// Agrega un nuevo turno a la base de datos.
        /// </summary>
        /// <param name="pNombre">Nombre del paciente.</param>
        /// <param name="pFechayHora">Fecha y hora del turno.</param>
        /// <param name="pIdSala">Identificador de la sala del turno.</param>
        /// <param name="pPrioridad">Prioridad el turno = 1, 2,..., 5. <br></br> 1 > 2 > ... > 5 </param>
        /// <param name="pDescrpcionPrioridad">Descripción de la prioridad: <br></br>
        /// 1 = Rojo, 2 = Narajna, 3 = Amarillo, 4 = Verde y 5 = Azul.
        /// </param>
        public void AgregarTurno(string pNombre, DateTime pFechayHora, int pIdSala, int pPrioridad, string pDescrpcionPrioridad)
        {
            Turno nuevoTurno = new Turno(pNombre, pFechayHora, pIdSala, pPrioridad, pDescrpcionPrioridad);
            Repository repository = new Repository();
            repository.AddTurno(nuevoTurno);
        }

        /// <summary>
        /// Devuelve un array con los datos del proximo turno de la sala para el día de hoy, o null si no hay un turno pendiente.
        /// </summary>
        /// <param name="pIdSala"></param>
        /// <returns></returns>
        public string[]? TurnoActual(int pIdSala)
        {
            Repository repository = new Repository();
            SalaGuardia? sala = repository.GetSalaById(pIdSala);
            if (sala == null) { return null; }
            //Buscamos entre los turnos pendientes para le día de hoy:
            else { return sala.ProximoTurno(DateTime.Today, DateTime.Today.AddDays(1));}
        }



    }
}
