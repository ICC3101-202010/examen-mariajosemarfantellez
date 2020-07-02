using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public class Equipo
    {
        private List<Jugadores> jugadores = new List<Jugadores>();
        private Entrenador entrenador;
        private Medico medico;
        private string name;
        private string tipo;
        public Equipo(string name, string tipo, List<Jugadores> jugadores, Entrenador entrenador, Medico medico)
        {
            this.name = name;
            this.tipo = tipo; //nacional o de liga
            this.jugadores = jugadores;
            this.entrenador = entrenador;
            this.medico = medico;
        }
        public List<Jugadores> Jugadoress { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenadorr { get => entrenador; set => entrenador = value; }
        public Medico Medicoo { get => medico; set => medico = value; }
        public string Name { get => name; set => name = value; }
        public string Tipo { get => tipo; set => tipo = value; } //si es nacional debe corroborar que todos los jugadores sean de la misma nacion

        public bool CorroborarNacionalidad(string nacion) //si retorna falso hay un jugador con distinta nacionalidad
        {
            foreach(Jugadores i in Jugadoress)
            {
                if (i.Nacional != nacion)
                {
                    return false;
                } 
            }
            return true;
        }
        public List<Jugadores> InformacionJugadores() //retorna al jugador que se le quiere saber la informacion
        {
            return this.Jugadoress;
        }

    }
}
