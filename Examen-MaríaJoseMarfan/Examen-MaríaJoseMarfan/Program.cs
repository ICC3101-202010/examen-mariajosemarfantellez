using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Examen_MaríaJoseMarfan
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo();
            Jugadores jug = new Jugadores();
            //Jugadores.Lesioned += Entrenador.OnLesioned;
            bool exec = true;
            while (exec)
            {
                // Pedimos al usuario una de las opciones
                string chosen = ShowOptions(new List<string>() { "Crear equipo", "Corroborar nacionalidad","Información de un jugador","Salir" });
                switch (chosen)
                {
                    case "Crear equipo":
                        Console.Clear();
                        equipo = Partido.CrearEquipo();
                        break;
                    case "Corroborar nacionalidad":
                        Console.Clear();
                        if (equipo.CorroborarNacionalidad(equipo.Tipo, equipo))
                        {
                            Console.WriteLine("Todos los jugadores cumplen");
                        }
                        else
                        {
                            Console.WriteLine("No todos los jugadores cumplen con la nacionalidad");
                        }
                        Thread.Sleep(1000);
                        break;
                    case "Información de un jugador":
                        Console.Clear();
                        Console.WriteLine("Diga el numero de la camiseta del jugador");
                        int num = -1;
                        while (num == -1)
                        {
                            try
                            {
                                num = int.Parse(Console.ReadLine());
                                if (num < 0)
                                {
                                    Console.WriteLine("Ingrese un numero valido");
                                    num = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un numero como numero de camiseta");
                            }
                        }
                        jug = equipo.InformacionJugadores(num, equipo);
                        Console.WriteLine("\nNombre: " + jug.Nombre + "\nEdad: " + jug.Edad + "\nNacionalidad: " + jug.Nacional + "\nDefensa: " + jug.Defensa + "\nPuntos de ataque: " + jug.PuntosAtaque + "\nSueldo: " + jug.Sueldo + "\nNumero de camiseta: " + jug.NumeroCamiseta);
                        Thread.Sleep(3000);
                        break;
                    case "Salir":
                        exec = false;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }
    }
}
