using System;
using System.Collections.Generic;
using System.Linq;

namespace linq.Torneo
{
    public interface Subject 
    {
        #region Methods
        public void registerObserver(Seleccion o); 
        public void unregisterObserver(Seleccion o); 
        public void notifyObservers(); 
        #endregion Methods
    }
}