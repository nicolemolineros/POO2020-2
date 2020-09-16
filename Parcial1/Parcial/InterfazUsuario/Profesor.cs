using Parcial.Salones;
using Parcial.Edificio;
using Parcial.Reservas;
using System;
using System.Collections.Generic;

namespace Parcial.InterfazUsuario{

public class Profesor{ 
        public string NombreProfesor { get; set; }
        public string ApellidoProfesor { get; set; }
        public string OpcionProfesor { get; set; }
        public int idSalon{ get;}
 
       
        public void SaludarProfesor()
        {
            Console.WriteLine("Bienvenido a la universidad \n Por favor digíte su nombre: \n");
            NombreProfesor = Console.ReadLine();
            Console.WriteLine("Por favor digíte su apellido: ");
            ApellidoProfesor = Console.ReadLine();
            Console.WriteLine("Qué opción desea hacer señor(a) " + NombreProfesor);
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Las opciones son: \n 1) Reservar Salón 2) Buscar salón");
            OpcionProfesor = Console.ReadLine();
            if(OpcionProfesor == "1")
            {
              Console.WriteLine("Digite el nombre del salón\n");
              string idNom = Console.ReadLine();
              Console.WriteLine("Digite la hora de inicio en la que desea hacer uso del salón \n");
              string inicio = Console.ReadLine();
              Console.WriteLine("Digite la hora de finalización de la clase \n");
              string final = Console.ReadLine();

              Reserva reserva1 = new Reserva(){
              NumReserva = idNom, 
              HoraInicial = Convert.ToInt32(inicio),
              HoraFinal = Convert.ToInt32(final),
              
              };
            }
            else
            {
                Console.WriteLine("Buscar Salón");
                Console.WriteLine("Digite el nombre del salón\n");
                string idNom = Console.ReadLine();
                
            
        }  
 }     
}
}

