using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica1208
{
    class Program
    {
        static void Main(string[] args)
        {

            //llamado al metodo loops
            loops();

            Console.ReadLine();

        }

        //bucles

        public static void loops()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //ciclo whiLe
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++

            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;

            }while(inc < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR");
            for (int j =0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARREGLO ORDENADO");
            //Llamado a las clase array y al metodo sort
            Array.Sort(numbers); //el metodo sort permite ordenar los valores dentro de un array
                for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARREGLO INVERTIDO");
            Array.Reverse(numbers); //reverse permite inventir los valores dentro del array
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

    }
}
