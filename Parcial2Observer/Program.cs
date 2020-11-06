using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using linq.Torneo;
using Newtonsoft.Json;
using Excepciones.CustomExceptions;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Liga LigaEspañola = new Liga();
            
            RepositorioDatos Datos = new RepositorioDatos();
            List<Seleccion> Selecciones = Datos.Selecciones;
            /*Seleccion Francia = Selecciones.First(s => s.Nombre == "Francia") as Seleccion;
            Seleccion Argentina = Selecciones.FirstOrDefault(s => s.Nombre == "Argentina") as Seleccion;
            Partido partido1 = new Partido(Francia, Argentina);*/
            
            //LigaEspañola.Selecciones = Selecciones;
            LigaEspañola.Partidos = new List<Partido>();
            LigaEspañola.Selecciones = new List<Seleccion>();
            //LigaEspañola.JugarPartido();
            // NUEVO
            bool salir = false;
            
            while (!salir)
            {
                Console.WriteLine("Que desea hacer? \n1) Crear Seleccion \n2) Simular Partido \n3) Salir");
                
                string val = Console.ReadLine();

                if( val == "1"){
                    LigaEspañola.CrearSeleccion();

                }else if(val == "2"){
                    LigaEspañola.JugarPartido();

                }else if(val == "3"){
                    salir = true;
                }


            }

        

        }
    }
}
