﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MaríaJoseMarfan
{
    public class JugadorNormal : Jugadores
    {
        private string posicion;

        public string Posicion { get => posicion; set => posicion = value; }
    }
}
