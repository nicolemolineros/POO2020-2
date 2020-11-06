using System;

namespace Excepciones.CustomExceptions
{
    public class NotValidTeam : Exception
    {
        public NotValidTeam() { }
        public NotValidTeam(string Message) : base(String.Format("El equipo {0} no existe, debe crearlo", Message)) { }

        public string NombreEquipo { get; set; }
    }
}