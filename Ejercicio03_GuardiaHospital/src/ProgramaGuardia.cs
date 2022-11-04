using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    internal class ProgramaGuardia
    {
        //ATRIBUTOS
        public static AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
        public static FachadaGuardia fachada = new FachadaGuardia();

        //METODOS
        public static void Main(string[] args)
        {
            fachada.InicializarSistema();
            char tecla = '1';
            //Clase para facilitar la creación de la interfaz:
            //AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
            string[,] datosSalas = fachada.GetDatosSalas();
            do
            {
                Console.Clear();
                asistenteDeInterfaz.MostrarTitulo("GESTION DE SALAS DE GUARDIA");
                asistenteDeInterfaz.MostrarSubTitulo("MENÚ PRINCIPAL");

                for (int i = 0; i < datosSalas.GetLength(0); i++)
                {
                    Console.WriteLine($"SALA N°: {datosSalas[i,0]}; TIPO: {datosSalas[i,1]}");
                }
                //Separamos los datos de las salas de las opciones
                asistenteDeInterfaz.ImprimirCaracter('-', 10);
                //Lista de opciones para el usuario
                asistenteDeInterfaz.MostrarListaOpciones(new string[] {"SALIR","CONSULTA TURNO ACTUAL"});
                tecla = asistenteDeInterfaz.SolicitarEntradaTecla("Presione la tecla correspondiente a la opción deseada...");

                if (tecla != '0')
                {
                    //Comprobamos la opción elegída:
                    switch (tecla)
                    {
                        case '1':
                            ConsultarTurnoActual();
                            break;
                        default:
                            asistenteDeInterfaz.MensajeError("La opción elegída no es válida.", "Presione cualquier tecla para volver a intentar...");
                            Console.ReadKey();
                            break;
                    }
                }
                

            } while (tecla != '0');
        }

        private static void ConsultarTurnoActual()
        {
            char tecla = '1';
            //Clase para facilitar la creación de la interfaz:
            //AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
            string[,] datosSalas = fachada.GetDatosSalas();
            do
            {
                Console.Clear();
                asistenteDeInterfaz.MostrarTitulo("GESTION DE SALAS DE GUARDIA");
                asistenteDeInterfaz.MostrarSubTitulo("TURNO ACTUAL");

                for (int i = 0; i < datosSalas.GetLength(0); i++)
                {
                    Console.WriteLine($"SALA N°: {datosSalas[i, 0]}; TIPO: {datosSalas[i, 1]}");
                }
                //Separamos los datos de las salas de las opciones
                asistenteDeInterfaz.ImprimirCaracter('-', 10);
                //Lista de opciones para el usuario
                asistenteDeInterfaz.MostrarListaOpciones(new string[] { "CANCELAR", "INGRESAR NÚMERO DE SALA" });
                tecla = asistenteDeInterfaz.SolicitarEntradaTecla("Presione la tecla correspondiente a la opción deseada...");

                if (tecla != '0')
                {
                    switch (tecla)
                    {
                        case '1':
                            string numSalaStr = asistenteDeInterfaz.SolicitarEntradaTexto("Ingrese el número de la sala: ");
                            if ( int.TryParse(numSalaStr, out int numSala) )
                            {
                                string[]? datosTurno = fachada.TurnoActual(numSala);
                                if (datosTurno != null)
                                {
                                    asistenteDeInterfaz.ImprimirCaracter('-', 10);
                                    MostrarDatosTurno(datosTurno);
                                    asistenteDeInterfaz.ImprimirCaracter('-', 10);
                                    asistenteDeInterfaz.MensajeExito("Turno encontrado", "Presione cualquier tecla para volver a intentar");
                                    Console.ReadKey();
                                } else
                                {
                                    asistenteDeInterfaz.MensajeError("Turno no encontrado", "Presione cualquier tecla para volver a intentar");
                                    Console.ReadKey();
                                }
                            } else
                            {
                                asistenteDeInterfaz.MensajeError("El número ingresado no es válido.", "Presione cualquier tecla para volver a intentar");
                                Console.ReadKey();
                            }
                            break;

                        default:
                            asistenteDeInterfaz.MensajeError("La opción elegída no es válida.", "Presione cualquier tecla para volver a intentar");
                            Console.ReadKey();
                            break;
                    }
                }


            } while (tecla != '0');
        }

        private static void MostrarDatosTurno(string[] datosTurno)
        {
            Console.WriteLine($"PACIENTE: {datosTurno[0]}");
            Console.WriteLine($"FECHA: {datosTurno[1]}");
            Console.WriteLine($"PRIORIDAD: {datosTurno[2]}");
        }
    }

    

}
