using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Examen_MaríaJoseMarfan
{
    public class Entrenador : Personas
    {
        private int puntosTactica;
        Random rnd = new Random();
        public Entrenador(string nombre, int edad, int sueldo, string nacion, int puntosTactica) : base()
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacional = nacion;
            this.Sueldo = sueldo;
            this.puntosTactica = puntosTactica;
        }
        public int CambiarJugador() //retorna el numero de la posicion de la lista de jugadores que entra al juego.
        {
            int numero = rnd.Next(0, 15);
            return numero;
        }
        public int PuntosTactica { get => puntosTactica; set => puntosTactica = value; }

        public void OnLesioned(object source, LesionEventArgs e) //le avisamos que hay un jugador lesionado por su numero de camiseta
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nEl jugador con la camiseta {e.NumeroJugador} está lesionado!\n");
            Thread.Sleep(2000);
        }

        //Evento que avise a Partido que debemos hacer un cambio y realizar ese cambio

        public delegate void LesionEntrenadorEventHandler(object source, LesionEntrenadorEventArgs args);
        public event LesionEntrenadorEventHandler LesionEntrenadored;
        protected virtual void OnLesionEntrenadored()
        {
            if (LesionEntrenadored != null)
            {
                LesionEntrenadored(this, new LesionEntrenadorEventArgs() { });
            }
        }
        public void LesionEntrenador()
        {
            OnLesionEntrenadored();
            CambiarJugador();
        }

}
}
