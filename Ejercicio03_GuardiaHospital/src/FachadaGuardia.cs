using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    internal class FachadaGuardia
    {
        /// <summary>
        /// Agreguega una nueva sala de consultas en la base de datos.
        /// </summary>
        /// <param name="pIdSala">Identificador de la sala a agregar.</param>
        /// <param name="pEstrategia">Estrategia de la sala: <br></br>'1' para Consultas <br></br> '2' Para urgencias.</param>
        /// <exception cref="ArgumentException">Si la estrategía no es una de las válidas.</exception>
        public void AgregarSalaConsultas(int pIdSala, char pEstrategia)
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



    }
}
