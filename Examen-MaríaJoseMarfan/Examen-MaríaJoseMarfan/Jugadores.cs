﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public class Jugadores : Personas
    {
        private int puntosAtaque;
        private int defensa;
        private int numeroCamiseta;
        public Jugadores()
        {

        }
        public Jugadores(string nombre, int edad, int sueldo, string nacion, int puntosAtaque, int defensa, int numeroCamiseta) : base()
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacional = nacion;
            this.Sueldo = sueldo;
            this.puntosAtaque = puntosAtaque;
            this.defensa = defensa;
            this.numeroCamiseta = numeroCamiseta;
        }

        public int PuntosAtaque { get => puntosAtaque; set => puntosAtaque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int NumeroCamiseta { get => numeroCamiseta; set => numeroCamiseta = value; }


        //creamos el evento para avisarle al entrenador que hay un jugador lesionado por su numero de camiseta

        public delegate void LesionEventHandler(object source, LesionEventArgs args);
        public event LesionEventHandler Lesioned;
        protected virtual void OnLesioned(int NumeroJugador)
        {
            if (Lesioned != null)
            {
                Lesioned(this, new LesionEventArgs() { NumeroJugador = numeroCamiseta});
            }
        }
        public void Lesion(int lesionado)
        {
            OnLesioned(lesionado);
        }
    }
}
