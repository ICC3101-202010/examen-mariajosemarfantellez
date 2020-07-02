using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public class Medico : Personas
    {
        private int puntosExperiencia;
        public Medico(string nombre, int edad, int sueldo, string nacion, int puntosExperiencia) : base()
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacional = nacion;
            this.Sueldo = sueldo;
            this.puntosExperiencia = puntosExperiencia;
        }
        public void Evaluar() //evalua al jugador lesionado
        {
            Console.WriteLine("El jugador tiene una grave lesion");
        }
        public void Curar() //cura al jugador lesionado
        {
            Console.WriteLine("El jugador ha sido curado");
        }
        public int PuntosExperiencia { get => puntosExperiencia; set => puntosExperiencia = value; }
    }
}
