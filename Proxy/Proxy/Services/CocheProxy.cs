using Proxy.Services.Interface;
using System;

namespace Proxy.Services
{
    public class CocheProxy : ICoche
    {
        private readonly ICoche Coche;
        public readonly IKey Llave;
        public CocheProxy(ICoche _coche, IKey _llave)
        {
            this.Coche = _coche ?? throw new ArgumentNullException(nameof(_coche));
            this.Llave = _llave ?? throw new ArgumentNullException(nameof(_llave));
        }

        public bool ArrancarCoche()
        {
            bool lEncendido = false;
            if (Llave.cKey == "22541")
            {
                lEncendido=Coche.ArrancarCoche();
            }
            return lEncendido;
        }
    }
}
