using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoRaio
{
    class Program
    {

        //  Mostra valor de volume, circunferência e Pi a partir do raio.



        static void Main(string[] args)
        {

        



            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("circunferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));

            double vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume:" + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

     
    }
}
