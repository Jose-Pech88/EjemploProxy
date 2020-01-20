using Proxy.Services.Interface;
using System;

namespace Proxy.Services
{
    public class Coche : ICoche
    {
        public bool ArrancarCoche()
        {
            Console.WriteLine("Vehiculo encendido, Motor encendido");
            return true;
        }
    }
}
