using Parcial.Salones;
using Parcial.Edificio;
using Parcial.Reservas;
using System;

namespace InterfazAdmin.Edificio.Salones
{

    public class Admin{
        public string NombreAdmin{ get; set; }
        public string ApellidoAdmin { get; set; }
        public string OpcionAdmin{ get; set; }
        public int idSalon{ get;}
 
       
        public void SaludarAdmin()
        {
            Console.WriteLine("Bienvenido a la universidad \n Por favor digíte su nombre: \n");
            NombreAdmin = Console.ReadLine();
            Console.WriteLine("Por favor digíte su apellido: ");
            ApellidoAdmin = Console.ReadLine();
            Console.WriteLine("Qué opción desea hacer señor(a) " + NombreAdmin);
            Menu();
        }
           public void Menu()
        {
            Console.WriteLine("Las opciones son: \n");
            Console.WriteLine("1) Agregar Salón \n");
            Console.WriteLine("2) Deshabilitar salón \n");   
            Console.WriteLine("3) Encender Luz \n");
            Console.WriteLine("4) Apagar Luz \n");
            Console.WriteLine("5) Modificar Tiempo Salon \n ");
            Console.WriteLine("6) Apagar AC \n");
            Console.WriteLine("7) Encender AC \n");
            Console.WriteLine("8) Cambiar Temperatura Salon \n");
            OpcionAdmin = Console.ReadLine();

            if(OpcionAdmin== "1"){

              Console.WriteLine("Digite el nombre del salón\n");
              string idNom = Console.ReadLine();
              Salon salon1 = new Salon(){

            };
              if(OpcionAdmin == "2"){
                    Console.WriteLine("Para Deshabilitar, ingrese el nombre del salon: ");
                    string v = Console.ReadLine();
                    string nomSalon = v;
            };
              if(OpcionAdmin == "3"){
                    Console.WriteLine("Ingrese el numero de minutos antes para que se encienda la luz de los salones: ");
                    string v = Console.ReadLine();
                    string TiempoLuzOn = v;
            };
              if(OpcionAdmin == "4"){
                    Console.WriteLine("Ingrese el numero de minutos despues para que se apague la luz de los salones: ");
                    string v = Console.ReadLine();
                    string TiempoLuzOff= v;
                  
            };
            if(OpcionAdmin == "5"){
                    Console.WriteLine("Ingrese el numero de minutos antes para que se abran los salones: ");
                    string v = Console.ReadLine();
                    string TiempoSalon= v;
                  
            };
            if(OpcionAdmin == "6"){
                    Console.WriteLine("Ingrese el numero de minutos antes para que se encienda el AC de los salones: ");
                    string v = Console.ReadLine();
                    string TiempoACOn = v;
            };
              if(OpcionAdmin == "7"){
                    Console.WriteLine("Ingrese el numero de minutos despues para que se apague el AC de los salones: ");
                    string v = Console.ReadLine();
                    string TiempoACOff= v;
                  
            };
            if(OpcionAdmin == "5"){
                    Console.WriteLine("Ingrese la temperatura deseada: ");
                    string v = Console.ReadLine();
                    string TempNueva= v;
            };
  }  


}

    }
}