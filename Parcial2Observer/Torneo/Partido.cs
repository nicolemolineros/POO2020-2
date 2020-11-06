using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Partido
    {
        #region Properties  
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public string Ganador { get; set; }

        #endregion Properties

        #region Initialize
        public Partido(Seleccion EquipoLocal, Seleccion EquipoVisitante) 
        {
            this.EquipoLocal = new Equipo(EquipoLocal);
            this.EquipoVisitante = new Equipo(EquipoVisitante);
            this.Ganador = "";
        }
        #endregion Initialize
        #region Methods
        private void CalcularExpulsiones(){   
            
            int i, j; 
            i = 0;
            Random random2 = new Random();
            j = random2.Next(5);
            while(i < j){

                Random random = new Random();
                List<string> jugadoresVacios = Enumerable.Repeat(string.Empty, 50).ToList();
                List<String> JugadoresLocales = EquipoLocal.Seleccion.Jugadores.Select(j => j.Nombre).ToList();//.Concat(jugadoresVacios).ToList();
                List<String> JugadoresVisitantes = EquipoVisitante.Seleccion.Jugadores.Select(j => j.Nombre).ToList();
                int position = random.Next(JugadoresLocales.Count);
                String expulsadoLocal = JugadoresLocales[position];
                position = random.Next(JugadoresVisitantes.Count);
                String expulsadoVisitante = JugadoresVisitantes[position];
                EquipoLocal.ExpulsarJugador(expulsadoLocal);
                EquipoVisitante.ExpulsarJugador(expulsadoVisitante);
                i++;
          }
        }
        // NUEVOOOOO
        private void CalcularAmarillas()
        {
            int i, j; 
            i = 0;
            Random random2 = new Random();
            j = random2.Next(8);
            while(i < j){

                Random random = new Random();
                List<string> jugadoresVacios = Enumerable.Repeat(string.Empty, 50).ToList();
                List<String> JugadoresLocales = EquipoLocal.Seleccion.Jugadores.Select(j => j.Nombre).ToList();
                List<String> JugadoresVisitantes = EquipoVisitante.Seleccion.Jugadores.Select(j => j.Nombre).ToList();
                int position = random.Next(JugadoresLocales.Count);
                String amarillaLocal = JugadoresLocales[position];
                position = random.Next(JugadoresVisitantes.Count);
                String amarillaVisitante = JugadoresVisitantes[position];

                EquipoLocal.AmarillaJugador(amarillaLocal);
                EquipoVisitante.AmarillaJugador(amarillaVisitante);
                i++;
            }
        }

        private void CalcularResultado()
        {
            Random random = new Random();
            EquipoLocal.Goles = random.Next(0,6);
            EquipoVisitante.Goles = random.Next(0,6);
        }

        public string Resultado()
        {
            string resultado = "0 - 0";
            try
            {
                CalcularAmarillas();
                CalcularExpulsiones();
                CalcularResultado();
                if(EquipoLocal.Goles > EquipoVisitante.Goles){
                    Ganador = EquipoLocal.Seleccion.Nombre;
                }else if( EquipoLocal.Goles < EquipoVisitante.Goles){
                    Ganador = EquipoVisitante.Seleccion.Nombre;
                }else{
                    Ganador = "";
                }

                resultado = EquipoLocal.Goles.ToString() + " - " + EquipoVisitante.Goles.ToString();
            }
            catch(LoseForWException ex)
            {
                Console.WriteLine(ex.Message);
                EquipoLocal.Goles -= EquipoLocal.Goles;
                EquipoVisitante.Goles -= EquipoVisitante.Goles;
                if (ex.NombreEquipo == EquipoLocal.Seleccion.Nombre)
                {
                    EquipoVisitante.Goles += 3;
                    resultado = "0 - 3";
                }
                else
                {
                    EquipoLocal.Goles += 3;
                    resultado = "3 - 0";
                }
            }
            
            return resultado;
        }
        #endregion Methods

    }
}