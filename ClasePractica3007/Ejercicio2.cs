using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int opcion;
            double a, b;

            Console.WriteLine("Escriba el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor de b: ");
            b = double.Parse(Console.ReadLine());

            //Preguntar opcion a usuario
            Console.WriteLine("Seleccione la operacion a realizar: 1-Suma, 2-Resta, 3-Multiplicacion");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
            }
            

            Console.ReadKey();


              

        }
    }
}
