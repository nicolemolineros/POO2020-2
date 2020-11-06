using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Equipo
    {
        #region Properties  
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Faltas { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public Seleccion Seleccion { get; set; }
        public bool EsLocal { get; set; }
        public List<Jugador> conAmarillas { get; set; }

        #endregion Properties

        #region Initialize
        public Equipo(Seleccion seleccion)
        {
            this.Seleccion = seleccion;
            this.conAmarillas = new List<Jugador>();
        }
        #endregion Initialize

        #region Methods
        public void ExpulsarJugador(string name)
        {
            try
            {
                Jugador jugadorExpulsado = Seleccion.Jugadores.First(j => j.Nombre == name);
                TarjetasRojas++;
                if (Seleccion.Jugadores.Count < 2)
                {
                    LoseForWException ex = new LoseForWException(Seleccion.Nombre);
                    ex.NombreEquipo = Seleccion.Nombre;
                    throw ex;
                }
                Console.WriteLine("Se expulsó el jugador: " + name);
                Seleccion.Jugadores.Remove(jugadorExpulsado);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No existe ese jugador para expulsarlo del equipo " + Seleccion.Nombre);
            }
            
        }
        //NUEVO
        public void AmarillaJugador(string name)
        {
            try
            {
                Jugador jugadorAmarilla = Seleccion.Jugadores.First(j => j.Nombre == name);

                // Busca al Jugador en el arreglo donde estan los jugadores con amarillas y devuelve un bool si lo encuentra
                bool yaTieneAmarilla = conAmarillas.Any(item => item == jugadorAmarilla);
                
                Console.WriteLine("Se le sacó una tarjeta amarilla al jugador: " + name);
                TarjetasAmarillas++;
                //Si ya tiene amarilla, entonces lo quita de la lista de Amarillas, y lo expulsa del partido.
                // Si no, lo agrega a la lista de amarillas.
                if (yaTieneAmarilla)
                {
                    this.conAmarillas.Remove(jugadorAmarilla);
                    ExpulsarJugador(name);
                }else{

                    this.conAmarillas.Add(jugadorAmarilla);
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No existe ese jugador para sacarle Amarilla " + Seleccion.Nombre);
            }
            
        }
        #endregion Methods
    }
}