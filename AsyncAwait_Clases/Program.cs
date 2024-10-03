using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_Clases
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Cocinero cocinero = new Cocinero();

            await cocinero.Entrada();

            Task principal = cocinero.PlatoPrincipal();

            await cocinero.Bebida();

            await principal;

            await cocinero.Postre();

            Console.WriteLine("\nTodas la comidas han sido preparadas y servidas.");

            Console.ReadKey();
        }

        public class Cocinero
        {
            public async Task Entrada()
            {
                Console.WriteLine("Empieza a Preparar la Entrada");
                await Task.Delay(5000);
                Console.WriteLine("La entrada esta Lista");
            }
            public async Task PlatoPrincipal()
            {
                Console.WriteLine("Comienza a preparar el plato principal");
                await Task.Delay(10000);
                Console.WriteLine("El plato principal esta listo");
            }
            public async Task Bebida()
            {
                Console.WriteLine("Se prepara la bebida");
                await Task.Delay(4000);
                Console.WriteLine("La bebida esta Lista");
            }
            public async Task Postre()
            {
                Console.WriteLine("Comienza a preparar el postre");
                await Task.Delay(3000);
                Console.WriteLine("El postre esta listo");
            }

        }
    }
}
