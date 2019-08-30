using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double sumando1 = 10;
            double sumando2 = 43;
            double resultado = Matematicas.sumar(sumando1, sumando2);

            Console.WriteLine(sumando1.ToString() + " + " + sumando2.ToString() + " = " + resultado.ToString());

            Console.WriteLine("Pi: " + Matematicas.PI);

            double radio = 4.7;
            Console.WriteLine("Radio: " + radio.ToString() +",  Area = " + Matematicas.areaCirculo(radio));

            Console.ReadLine();
        }
    }
}
