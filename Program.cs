using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdaptador
{

    class Program
    {
        static void Main(string[] args)
        {

            IGeneradorEnteroComoString origen = new GeneradorEnteroComoString();
            IConvertidorDecimal destino = new ConvertidorDecimal(origen);

            Console.WriteLine($"Total: \"{origen.GenerarEnteroComoString()}\" convertido a {destino.ConvertirADecimal().ToString("0.00")}");
            Console.ReadKey();

        }
    }
}
