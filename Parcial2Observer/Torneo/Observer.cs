using System;
using System.Collections.Generic;
using System.Linq;

namespace linq.Torneo
{
    public interface Observer 
    {
        #region Methods
        public void update(Partido p);
        #endregion Methods
    }
}