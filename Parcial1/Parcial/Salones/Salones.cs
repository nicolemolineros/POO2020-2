using System;
using System.Collections.Generic;
using Parcial.Edificio;
using Parcial.Reservas;

namespace Parcial.Salones
{
    public class Salon{
        public bool LuzSalon { get; set; }

        public int TempSalon { get; set; }

        public bool Habilitado { get; set; }

        public bool Abierto { get; set; }

        public bool Ac { get; set; }

        public string NombreSalon { get; set; }

        public static List<Reserva> listReservas = new List<Reserva>(); // Lista de reservas

        public Reserva reserva1 = null;

       /* public Salon( bool _luzSalon, int _tempSalon, bool _habilitado, bool _abierto, bool _ac, string NombreSalon,  List<Reserva> _listReserva, string _nombreSalon){
            this.LuzSalon = _luzSalon;
            this.TempSalon =_tempSalon;
            this.Habilitado = _habilitado;
            this.Abierto = _abierto;
            this.Ac = _ac;
            this.NombreSalon = _nombreSalon;
            listReservas = _listReserva;
        }
*/
        void MostrarReservados(){

            System.Collections.IList list = listReservas;
            for (int i = 0; i < list.Count; i++)
        {
                int reserva = (int)list[i];
                Console.Write($"{reserva} ");
        }
        Console.WriteLine();
        }

    }
}