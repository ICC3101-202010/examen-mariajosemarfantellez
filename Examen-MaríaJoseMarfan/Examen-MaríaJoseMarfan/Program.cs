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
                string chosen = ShowOptions(new List<string>() { "Crear equipo", "Corroborar nacionalidad","Información del equipo","Salir" });
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
                    case "Información del equipo":
                        Console.Clear();
                        equipo.InformacionJugadores(equipo);
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
