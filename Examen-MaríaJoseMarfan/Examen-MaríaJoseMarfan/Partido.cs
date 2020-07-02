using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Examen_MaríaJoseMarfan
{
    public static class Partido
    {
        
        static Random rnd = new Random();
        static List<Equipo> equipos = new List<Equipo>();
        public static List<Jugadores> jugadores = new List<Jugadores>();
        
        public static Equipo Enfrentar() //me entrega que equipos se enfrentan
        {
            int a = equipos.Count();
            return equipos[a];
        }
        public static int Duracion() //me entrega la cantidad de minutos que dura el partido (entre 30 y 90 minutos)
        {
            int dura = rnd.Next(30,90);
            return dura;
        }
        public static string Resultado() //me entrega el resultado final
        {
            return "ganador"; 
        }
        public static string NoL() //me entrega si es nacional o de liga
        {
            //al azar nacional o liga y seleccionar 2 equipos nacional o 2 de liga
            CorroborarNacionalEquipo();
            return "nacional"; 
        }
        public static bool CorroborarNacionalEquipo() //ve si los 2 equipos son nacionales o los 2 son de liga
        {
            foreach(Equipo a in equipos)
            {
                if(a.Tipo != "nacional")
                {
                    return false;
                }
            }
            return true; //seleccionar 2 iguales
        }

        public static Equipo CrearEquipo()
        {
            Console.WriteLine("Nombre del equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Diga la nacionalidad del equipo, si es un equipo de liga ponga liga");
            string nacion = Console.ReadLine();
            Console.WriteLine("Diga el nombre del medico");
            string nombremedico = Console.ReadLine();
            Console.WriteLine("Diga la edad del medico");
            int edad = -1;
            while (edad == -1)
            {
                try
                {
                    edad = int.Parse(Console.ReadLine());
                    if (edad < 1)
                    {
                        Console.WriteLine("Ingrese una edad valida");
                        edad = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                }
            }
            Console.WriteLine("Diga el sueldo del medico (solo el valor)");
            int sueldo = -1;
            while (sueldo == -1)
            {
                try
                {
                    sueldo = int.Parse(Console.ReadLine());
                    if (sueldo < 1)
                    {
                        Console.WriteLine("Ingrese un sueldo valido");
                        sueldo = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                }
            }
            Console.WriteLine("Diga la nacion del medico");
            string naciion = Console.ReadLine();
            Console.WriteLine("Diga los puntos de experiencia del medico");
            int pexp = -1;
            while (pexp == -1)
            {
                try
                {
                    pexp = int.Parse(Console.ReadLine());
                    if (pexp < 1)
                    {
                        Console.WriteLine("Ingrese puntos de experiencia valido");
                        pexp = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como puntos de experiencia");
                }
            }
            Medico medico = new Medico(nombremedico,edad,sueldo,naciion,pexp);

            Console.WriteLine("Diga el nombre del entrenador");
            string nombreentre = Console.ReadLine();
            Console.WriteLine("Diga la edad del entrenador");
            int edadentre = -1;
            while (edadentre == -1)
            {
                try
                {
                    edadentre = int.Parse(Console.ReadLine());
                    if (edadentre < 1)
                    {
                        Console.WriteLine("Ingrese una edad valida");
                        edadentre = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                }
            }
            Console.WriteLine("Diga el sueldo del entrenador (solo el valor)");
            int sueldoentre = -1;
            while (sueldoentre == -1)
            {
                try
                {
                    sueldoentre = int.Parse(Console.ReadLine());
                    if (sueldoentre < 1)
                    {
                        Console.WriteLine("Ingrese un sueldo valido");
                        sueldoentre = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                }
            }
            Console.WriteLine("Diga la nacion del entrenador");
            string naciionentre = Console.ReadLine();
            Console.WriteLine("Diga los puntos de tactica del entrenador");

            int ptac = -1;
            while (ptac == -1)
            {
                try
                {
                    ptac = int.Parse(Console.ReadLine());
                    if (ptac < 1)
                    {
                        Console.WriteLine("Ingrese puntos de tactica valido");
                        ptac = -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato invalido\nIngrese un numero como puntos de tactica");
                }
            }
            Entrenador entrenador = new Entrenador(nombreentre, edadentre, sueldoentre, naciionentre, ptac);
            int o = 1;
            while(o<3)
            {
                Console.WriteLine("Jugador " + o);
                Console.WriteLine("Diga el nombre del jugador");
                string nombrejug = Console.ReadLine();
                Console.WriteLine("Diga la edad del jugador");
                int edadjug = -1;
                while (edadjug == -1)
                {
                    try
                    {
                        edadjug = int.Parse(Console.ReadLine());
                        if (edadjug < 1)
                        {
                            Console.WriteLine("Ingrese una edad valida");
                            edadjug = -1;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                    }
                }
                Console.WriteLine("Diga el sueldo del jugador (solo el valor)");
                int sueldojug = -1;
                while (sueldojug == -1)
                {
                    try
                    {
                        sueldojug = int.Parse(Console.ReadLine());
                        if (sueldojug < 1)
                        {
                            Console.WriteLine("Ingrese un sueldo valido");
                            sueldojug = -1;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                    }
                }

                Console.WriteLine("Diga la nacion del jugador (luego podrá corroborar que los jugadores sean de la misma nacionalidad)");
                string naciionjug = Console.ReadLine();

                Console.WriteLine("Diga los puntos de ataque del jugador");
                int patac = -1;
                while (patac == -1)
                {
                    try
                    {
                        patac = int.Parse(Console.ReadLine());
                        if (patac < 1)
                        {
                            Console.WriteLine("Ingrese puntos de ataque valido");
                            patac = -1;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato invalido\nIngrese un numero como puntos de ataque");
                    }
                }
                Console.WriteLine("Diga los puntos de defensa del jugador");
                int pdef = -1;
                while (pdef == -1)
                {
                    try
                    { 
                        pdef = int.Parse(Console.ReadLine());
                        if (pdef < 1)
                        {
                            Console.WriteLine("Ingrese puntos de defensa valido");
                            pdef = -1;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato invalido\nIngrese un numero como puntos de defensa");
                    }
                }
                Console.WriteLine("Diga el numero de camiseta del jugador (entre 0 y 99)");
                int nc = -1;
                while (nc == -1)
                {
                    try
                    {
                        nc = int.Parse(Console.ReadLine());
                        if (nc < 0)
                        {
                            Console.WriteLine("Ingrese numero de camiseta valido");
                            nc = -1;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato invalido\nIngrese un numero como numero de camiseta");
                    }
                }
                Jugadores jugador = new Jugadores(nombrejug, edadjug, sueldojug, naciionjug, patac, pdef,nc);
                jugadores.Add(jugador);
                o++;
            }
            Equipo e1 = new Equipo(nombre,nacion,jugadores,entrenador,medico);
            return e1;


        }

        public static void OnLesionEntrenadored(object source, LesionEntrenadorEventArgs e) //le avisamos que hay un jugador lesionado por su numero de camiseta
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nNecesito hacer un cambio!\n");
            Thread.Sleep(2000);
        }
    }
}
