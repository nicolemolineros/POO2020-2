using Parcial.Salones;
using System;
using System.Collections.Generic;

namespace Parcial.Edificio.Admin

{
    public class Edificio
    {
        #region Propiedades
        public static List<Salon> listSalones = new List<Salon>();
        //list<Salones> listSalones = new List<Salones>();
        public int TiempoAbierto{ get; set; }

        public int TiempoLuzOn{ get; set; }
        public int TiempoLuzOff{ get; set; }

        public int TemperaturaAc{ get; set; }
        public bool Habilitado { get; private set; }
        public int TempSalon{get; set;}
        #endregion Propiedades
        public Salon Sal = null; // Propiedad para la agregacion
        private int t1;

        public Edificio(List<Salon> listSalones, int _tiempoAbierto, int _tiempoLuzOn, int _tiempoLuzOff, int _temperaturaAc)
        {
            TiempoAbierto = _tiempoAbierto = 5;
            TiempoLuzOn = _tiempoLuzOn = 5;
            TiempoLuzOff = _tiempoLuzOff = 10;
            TemperaturaAc = 23; //Los grados a los que se debe mantener el sistema
        }
        public int CambiarTempAc(){

            if(TempSalon < 30 && TempSalon > 16){
                this.TemperaturaAc = TempSalon;
            }else{
                throw new Exception("Temperatura Invalida!");
            }
        }
         public int ModTiempoLuzOn(){
            if(t1 < 60 && t1 > 0){
                this.TiempoLuzOn = t1;
            }else{
                throw new Exception("Tiempo Invalido!");
            }
        }
        public int ModTiempoLuzOff(){
            if(t1 < 60 && t1 > 0){
                this.TiempoLuzOff = t1;
            }else{
                throw new Exception("Tiempo Invalido!");
            }
        }
        public int ModTiempoAbierto(){
            if(t1 < 60 && t1 > 0){
                this.TiempoAbierto = t1;
            }else{
                throw new Exception("Tiempo Invalido!");
            }
        }
       
    }
    }
    

