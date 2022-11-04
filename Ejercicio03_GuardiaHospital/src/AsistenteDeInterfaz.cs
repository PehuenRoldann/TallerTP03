using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    /// <summary>
    /// Clase auxiliar para el diseño de la interfaz de usuario.
    /// </summary>
    public class AsistenteDeInterfaz
    {
        /// <summary>
        /// Muestra una lista de opciones enumerada, empezando por 0.
        /// </summary>
        /// <param name="pListaOpciones">Array de opciones para el usuario</param>
        public void MostrarListaOpciones( string[] pListaOpciones)
        { 

            //Listamos los objetos en pantalla
            for (int numOpcion = 0; numOpcion < pListaOpciones.Length; numOpcion++)
            {
                Console.WriteLine($"[{numOpcion}] {pListaOpciones[numOpcion]}");
            }
        }

        /// <summary>
        /// Muestra una lista de cadenas por pantalla.
        /// </summary>
        /// <param name="lista">Lista de cadenas a mostrar</param>
        public void MostrarLista (List<string> lista)
        {
            foreach (string cadena in lista)
            {
                Console.WriteLine(cadena);
            }
        }

        /// <summary>
        /// Muestra una cadena de caracteres estilizada como un "titulo"
        /// </summary>
        /// <param name="pTitulo">Titulo para mostrar</param>
        /// <param name="pColorFondo">Color del fondo (azul por defecto)</param>
        /// <param name ="pColorFuente">Color de la fuente (blanco por defecto)</param>
        public void MostrarTitulo(string pTitulo, ConsoleColor pColorFuente = ConsoleColor.White, ConsoleColor pColorFondo = ConsoleColor.Blue)
        {
            Console.BackgroundColor = pColorFondo;
            Console.ForegroundColor = pColorFuente;

            Console.WriteLine($"----------------{pTitulo}----------------");
            this.ResetearColores();
        }

        /// <summary>
        /// Muestra una cadena de caracteres estilizada como un "Sub titulo"
        /// </summary>
        /// <param name="pSubTitulo">Sub titulo para mostrar</param>
        /// <param name="pColorFondo">Color del fondo (blanco por defecto)</param>
        /// <param name ="pColorFuente">Color de la fuente (negro por defecto)</param>
        public void MostrarSubTitulo(string pSubTitulo, ConsoleColor pColorFuente = ConsoleColor.Black, ConsoleColor pColorFondo = ConsoleColor.White)
        {
            Console.BackgroundColor = pColorFondo;
            Console.ForegroundColor = pColorFuente;
            Console.WriteLine($"[{pSubTitulo}]");
            this.ResetearColores();
        }
        
        /// <summary>
        /// Resetea los colores de background y foreground de la consola a los predeterminados.
        /// </summary>
        public void ResetearColores()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Muestra un mensaje de error por consola.
        /// </summary>
        /// <param name="pMensaje"> Mensaje de error </param>
        /// <param name="pContinuar">Mensaje para indicar como continuar continuar (opcional) </param>
        public void MensajeError(string pMensaje, string pContinuar = "")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(pMensaje);

            ResetearColores();

            if (pContinuar != "")
            {
                Console.WriteLine(pContinuar);
            }

        }

        /// <summary>
        /// Muestra un mensaje de exito por consola.
        /// </summary>
        /// <param name="pMensaje"> Mensaje de exito </param>
        /// <param name="pContinuar">Mensaje para indicar como continuar continuar (opcional) </param>
        public void MensajeExito(string pMensaje, string pContinuar = "")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(pMensaje);

            ResetearColores();

            if (pContinuar != "")
            {
                Console.WriteLine(pContinuar);
            }

        }

        /// <summary>
        /// Capta la entrada de una tecla por consola
        /// </summary>
        /// <returns> Caracter asociado a la tecla presionada </returns>
        public char SolicitarEntradaTecla(string pMensaje = "")
        {
            if (pMensaje != "") { Console.WriteLine(pMensaje);}
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("");
            return key.KeyChar;
        }

        /// <summary>
        /// Solicita al usuario la entrada de un dato
        /// </summary>
        /// <param name="pMensaje">Mensaje solicitando el dato</param>
        /// <returns>Cadena de caracteres ingresada por el usuario</returns>
        public string SolicitarEntradaTexto(string pMensaje)
        {
            Console.WriteLine(pMensaje);
            return Console.ReadLine();
        }

        /// <summary>
        /// Imprime en pantalla un caracter un determinado número de veces.
        /// </summary>
        /// <param name="pCaracterSeparador">Caracter a imprimier.</param>
        /// <param name="pCantCaracteres">Cantidad de veces.</param>
        public void ImprimirCaracter(char pCaracterSeparador, int pCantCaracteres)
        {
            string separador = "";

            for (int i = 0; i < pCantCaracteres; i++)
            {
                separador += pCaracterSeparador;
            }
            Console.WriteLine(separador);
        }

        /// <summary>
        /// Imprime un mensaje en pantalla. Pudiendo cambiar el color del fondo y la fuente.
        /// </summary>
        /// <param name="pMensaje">Mensaje</param>
        /// <param name="pColorFuente">Color de la fuente (blanco por defecto)</param>
        /// <param name="pColorFondo">Color del fondo (negro por defecto)</param>
        public void ImprimirMensaje(string pMensaje, ConsoleColor pColorFuente = ConsoleColor.White, ConsoleColor pColorFondo = ConsoleColor.Black)
        {
            Console.BackgroundColor = pColorFondo;
            Console.ForegroundColor = pColorFuente;
            Console.WriteLine(pMensaje);
            ResetearColores();
        }

        /// <summary>
        /// Cambia los colores de la consola
        /// </summary>
        /// <param name="pColorFuente">Color de la fuente (blanco por defecto)</param>
        /// <param name="pColorFondo">Color del fondo (negro por defecto)</param>
        public void CambiarColorConsola (ConsoleColor pColorFuente = ConsoleColor.White, ConsoleColor pColorFondo = ConsoleColor.Black)
        {
            Console.BackgroundColor = pColorFondo;
            Console.ForegroundColor = pColorFuente;
        }
    }
}
