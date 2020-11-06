using System.Collections.Generic;
using Newtonsoft.Json;

namespace linq.Torneo
{
    public class Seleccion : Observer
    {
        #region Properties  
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("puntos")]
        public int PuntosTotales { get; set; }

        [JsonProperty("goles")]
        public int GolesTotales { get; set; }

        [JsonProperty("asistencias")]
        public int AsistenciasTotales { get; set; }

        [JsonProperty("jugadores")]
        public List<Jugador> Jugadores { get; set; }

        #endregion Properties

        #region Initialize

        #endregion Initialize


        #region Methods
        public void update( Partido p){

            if(p.EquipoLocal.Seleccion.Nombre == Nombre){
                GolesTotales += p.EquipoLocal.Goles;
                AsistenciasTotales += p.EquipoLocal.Asistencias;
                if(Nombre == p.Ganador){
                    PuntosTotales += 3;
                }else if("" == p.Ganador){
                    PuntosTotales += 1;
                }

            }else if(p.EquipoVisitante.Seleccion.Nombre == Nombre){

                GolesTotales += p.EquipoVisitante.Goles;
                AsistenciasTotales += p.EquipoVisitante.Asistencias;
                if(Nombre == p.Ganador){
                    PuntosTotales += 3;
                }else if("" == p.Ganador){
                    PuntosTotales += 1;
                }

            }

        }
        #endregion Methods


    }
}