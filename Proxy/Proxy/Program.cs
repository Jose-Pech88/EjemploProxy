using Proxy.Services;
using Proxy.Services.Interface;
using System;

namespace Proxy
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void InicializarAplicacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            ICoche Coche = new Coche();
            IKey Llave = new Key();
            ICoche CocheProxy = new CocheProxy(Coche, Llave);
            string cKey = string.Empty;
            do
            {
                Console.Write("Capturar llave\r\n");
                cKey = Console.ReadLine();
                Llave.cKey = cKey;
                if(!CocheProxy.ArrancarCoche())
                    Console.WriteLine("Clave Incorrecta.");
            }
            while (cKey != "22541");
        }
    }
}
