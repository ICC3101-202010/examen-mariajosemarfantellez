using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public static class Partido
    {
        static Random rnd = new Random();
        static List<Equipo> equipos = new List<Equipo>();
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
            return "ganador"; //aun no se hacerlo
        }
        public static string NoL() //me entrega si es nacional o de liga
        {
            //al azar nacional o liga y seleccionar 2 equipos nacional o 2 de liga
            CorroborarNacional();
            return "nacional"; //aun no se hacerlo
        }
        public static bool CorroborarNacional() //ve si los 2 equipos son nacionales o los 2 son de liga
        {
            foreach(Equipo a in equipos)
            {
                if(a.Tipo != "nacional")
                {
                    return false;
                }
            }
            return true; //seleccionar 2 iguales, aun no se hacerlo
        }
        
    }
}
