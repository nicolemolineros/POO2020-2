using Parcial.Salones;
using System;
using System.Collections.Generic;

namespace Parcial.Edificio
{
    public class Edificio
    {
        public static List<Salon> listSalones = new List<Salon>();
        //list<Salones> listSalones = new List<Salones>();
        public int TiempoAbierto { get; set; }

        public int TiempoLuzOn { get; set; }

        public int TiempoLuzOff { get; set; }

        public int TemperaturaAc { get; set; }

        public Salon Sal = null; // Propiedad para la agregacion

        public Edificio(List<Salon> listSalones, int _tiempoAbierto, int _tiempoLuzOn, int _tiempoLuzOff, int _temperaturaAc)
        {
            TiempoAbierto = _tiempoAbierto = 5;
            TiempoLuzOn = _tiempoLuzOn = 5;
            TiempoLuzOff = _tiempoLuzOff = 10;
            TemperaturaAc = 23; //Los grados a los que se debe mantener el sistema
        }
    }
}

