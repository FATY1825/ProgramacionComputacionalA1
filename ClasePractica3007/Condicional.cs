using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Condicional
    {
        static void Main(string[] args)
        {
            //instruccion switch
            int a = 10;

            switch (a)
            {
                case 5:
                    Console.WriteLine("El valor de a es 5");
                    break;
                case 10:
                    Console.WriteLine("El valor de a es 10");
                    break;
                default:
                    Console.WriteLine("El valor no es conocido");
                    break;
            }
               
            //Declaracion anidada utilizando switch

            switch (a)
            {
                case 5:
                    Console.WriteLine("El valor de a es 5");
                    switch (a - 1)
                    {
                        case 4:
                            Console.WriteLine("El valor de a es 4");
                            switch (a - 2)
                            {
                                case 3:
                                    Console.WriteLine("El valor de a es 3");
                                    break;

                            }
                            break;
                    }
                    break;

            }
        }
    }
}
