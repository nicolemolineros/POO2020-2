using System;
using Parcial.Edificio;
using Parcial.Salones;
using System.Collections.Generic;

namespace Parcial.Reservas
{
    public class Reserva{
        public string NumReserva { get; set; }
        public int HoraInicial { get; set; }
        public int HoraFinal { get; set; }
        public Reserva reserva1 = null;

    }
}
