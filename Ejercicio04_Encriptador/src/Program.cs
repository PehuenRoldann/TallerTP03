using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_Encriptador.src
{
    public class Program
    {
        static public void Main(string[] args)
        {

            char tecla = '0';

            do
            {
                tecla = MenuPrincipal();
                ProcesarSeleccionMenuPrincipal(tecla);

            } while (tecla != '0');

        }

        private static void ProcesarSeleccionMenuPrincipal(char pTecla)
        {
            if (pTecla != '0')
            {
                switch (pTecla)
                {
                    case '1':
                        EncriptarCadena();
                        break;

                    case '2':
                        DesencriptarCadena();
                        break;

                    default:
                        AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
                        asistenteDeInterfaz.MensajeError("La opción seleccionada no es válida.",
                            "Presione cualquier boton para volver a intentar...");

                        Console.ReadKey();
                        break;
                }
            }
        }

        /// <summary>
        /// Encripta una cadena solicitada al usuario.
        /// </summary>
        private static void EncriptarCadena()
        {
            //Configuramos todo para la encriptación:
            FachadaEncriptador fachada = new FachadaEncriptador();
            string cadenaSinEncriptar = ObtenerCadena();
            string algoritmo = ObtenerAlgoritmo("Encriptar");
            AsistenteDeInterfaz interfazUsuario = new AsistenteDeInterfaz();
            interfazUsuario.ImprimirCaracter('*', 10);
            //Mostramos por pantalla el resultado:
            Console.WriteLine($"Se ha encriptado la cadena: {cadenaSinEncriptar}, " +
                $"usando el algoritmo: {algoritmo}");
            Console.WriteLine("RESULTADO: " + 
                fachada.EncriptarCadena(cadenaSinEncriptar, algoritmo));
            interfazUsuario.ImprimirCaracter('*', 10);
            //Volvemos al menú:
            Console.WriteLine("Presine cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }

        /// <summary>
        /// Desencripta una cadena.
        /// </summary>
        private static void DesencriptarCadena()
        {
            //Configuramos todo para la desencriptación:
            FachadaEncriptador fachada = new FachadaEncriptador();
            string cadenaEncriptada = ObtenerCadena();
            string algoritmo = ObtenerAlgoritmo("Desencriptar");
            AsistenteDeInterfaz interfazUsuario = new AsistenteDeInterfaz();
            interfazUsuario.ImprimirCaracter('*', 10);
            //Mostramos por pantalla el resultado:
            Console.WriteLine($"Se ha desencriptado la cadena: {cadenaEncriptada}, " +
                $"usando el algoritmo: {algoritmo}");
            Console.WriteLine("RESULTADO: " + 
                fachada.DesencriptarCadena(cadenaEncriptada, algoritmo));
            interfazUsuario.ImprimirCaracter('*', 10);
            //Volvemos al menú:
            Console.WriteLine("Presine cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }

        private static char MenuPrincipal()
        {
            Console.Clear();
            AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
            asistenteDeInterfaz.MostrarTitulo("PROGRAMA DE ENCRIPTACIÓN");
            asistenteDeInterfaz.MostrarSubTitulo("MENU PRINCIPAL");

            asistenteDeInterfaz.MostrarListaOpciones(new string[] { "SALIR", "ENCRIPTAR", "DESENCRIPTAR" });
            return asistenteDeInterfaz.SolicitarEntradaTecla("Presione la tecla correspondiente a la opción deseada...");

        }

        /// <summary>
        /// Obtiene la cadena para encriptar o desencriptar
        /// </summary>
        /// <returns>Cadena de caracteres</returns>
        private static string ObtenerCadena()
        {
            Console.Clear();
            AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
            asistenteDeInterfaz.MostrarTitulo("PROGRAMA DE ENCRIPTACIÓN");
            asistenteDeInterfaz.MostrarSubTitulo("INGRESAR CADENA");
            return asistenteDeInterfaz.SolicitarEntradaTexto("Ingrese la cadena que desea operar:");
        }

        /// <summary>
        /// Muestra por patntalla una lista con los algoritmos de encriptación
        /// </summary>
        /// <param name="pOperacion">"Encriptar o Desencritpar"</param>
        /// <returns>Siglas del algoritmo seleccionado</returns>
        private static string ObtenerAlgoritmo(string pOperacion)
        {
            Console.Clear();
            AsistenteDeInterfaz asistenteDeInterfaz = new AsistenteDeInterfaz();
            asistenteDeInterfaz.MostrarTitulo($"PROGRAMA DE ENCRIPTACIÓN > {pOperacion.ToUpper()}");
            asistenteDeInterfaz.MostrarSubTitulo("SELECCIÓN DE ALGORITMO DE ENCRIPTACIÓN");
            Console.WriteLine("Lista de algortimos de encriptación:");
            asistenteDeInterfaz.ImprimirCaracter('*', 10);
            string[] arrayAlgoritmos = new string[] { "AES (Advanced Encription Standar)",
                "CESAR", "NULL (o cualquier otro que no sea una opción)" };
            asistenteDeInterfaz.MostrarLista(arrayAlgoritmos.ToList());
            asistenteDeInterfaz.ImprimirCaracter('*', 10);

            return asistenteDeInterfaz.
                SolicitarEntradaTexto($"Ingrese las siglas del algoritmo que desea usar para la " +
                $"{pOperacion.ToLower()}:");
        }


    }
}
