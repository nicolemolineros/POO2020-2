using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using linq.Torneo;
using Newtonsoft.Json;
using Excepciones.CustomExceptions;

namespace linq.Torneo
{
    public class Liga : Subject
    {
        #region Properties  
  
        public List<Seleccion> Selecciones { get; set; }
        public List<Partido> Partidos { get; set; }

        #endregion Properties

        #region Methods

        public void registerObserver(Seleccion o) { 
            Selecciones.Add(o); 
        } 
      
        public void unregisterObserver(Seleccion o) { 
            Selecciones.Remove(o); 
        }


        public void notifyObservers() { 
            foreach(var element in Selecciones){
                element.update( Partidos.LastOrDefault() );
            }
        }

        public void JugarPartido(){


            Console.WriteLine("Ingrese Equipo 1: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Ingrese Equipo 2: ");
            string name2 = Console.ReadLine();

            bool existe;

            try
            {
                Seleccion Equipo2, Equipo1;
                existe =  Selecciones.Any(s => s.Nombre == name1);
                if(existe){
                    Equipo1 = Selecciones.First(s => s.Nombre == name1) as Seleccion;
                }else{
                    NotValidTeam ex = new NotValidTeam(name1);
                    throw ex;
                }
                
                existe = Selecciones.Any(s => s.Nombre == name1);
                
                if(existe){
                    Equipo2 = Selecciones.First(s => s.Nombre == name2) as Seleccion;
                }else{
                    NotValidTeam ex = new NotValidTeam(name1);
                    throw ex;
                }
                RepositorioDatos Datos = new RepositorioDatos();
                List<Seleccion> Selecciones2 = Datos.Selecciones;
                Seleccion Francia = Selecciones2.First(s => s.Nombre == "Francia") as Seleccion;
                Seleccion Argentina = Selecciones2.FirstOrDefault(s => s.Nombre == "Argentina") as Seleccion;
                Partido partido1 = new Partido(Francia, Argentina);
                Partido partido = new Partido(Equipo1, Equipo2);
                this.Partidos.Add(partido1);


                //notifyObservers();

                Console.WriteLine(partido.Resultado());
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No se pudo simular el partido, existe un error");
            }



            
        }


        public void CrearSeleccion(){
            Console.WriteLine("Ingrese el nombre del archivo json para crear la seleccion: \nTiene que ser un archivo que este en la misma carpeta.");
            string nameArchivo = Console.ReadLine();

            try{
                Seleccion Equipo1 = JsonConvert.DeserializeObject<Seleccion>(File.ReadAllText("./" + nameArchivo));
                Selecciones.Add(Equipo1);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("No se pudo encontrar el archivo json especificado.");
            }

            Console.WriteLine("El equipo fue creado satisfactoriamente ");   
        }

        #endregion Methods
    }
}