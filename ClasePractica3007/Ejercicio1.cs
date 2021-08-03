using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Ejercicio1
    {
       //declaracion de Enum 

        public enum Dias
        {
            Lunes,
            Martes,
            Miercoles, 
            Jueves,
            Viernes,
            Sabado,
            Domingo,
        }

        static void Main(string[] args)
        {

            //ENUM
            //clase especial, representa un conjunto de constantes
            Console.WriteLine("Escriba el numero correspondiente al dia de la semana: ");
            //int dia = Convert.ToInt32(Console.ReadLine()); //Convert. se utiliza para convertir tipos de datos
            int dia = int.Parse(Console.ReadLine()); //realiza un tipo de conversion

            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.Lunes);
                    break;

                case 2:
                    Console.WriteLine(Dias.Martes);
                    break;
            }

            Console.ReadKey();
        }
    }
}
