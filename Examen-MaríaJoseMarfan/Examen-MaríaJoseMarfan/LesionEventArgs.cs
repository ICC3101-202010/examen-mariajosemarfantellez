using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public class LesionEventArgs : EventArgs
    {
        private int numeroJugador;

        public int NumeroJugador { get => numeroJugador; set => numeroJugador = value; }
    }
}
