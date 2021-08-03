//referencias hacia los espacios de nombre del .NET Framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnTeorica2907 //nombre del espacio de nombres
{
    class TiposDatos
    {
        static void Main(string [] args) //metodo principal 
        {
            /* Console.WriteLine("Esta es la clase Variables");
             Console.ReadKey();*/

            //VARIABLES
            //tipos de datos

            //almacena 1 byte
            byte num1 = 255;

            //variante de byte
            //solo soporta numeros negativos
            sbyte num2 = -127;

            //int, soporta numeros negativos y positivos, 4 bytes
            int num3 = 20;
            int num4 = -20;

            //uint, solamente admite numeros positivos
            uint num5 = 28;

            //long permite almacenar mas datos 
            //para procesar millones de datos 
            long num6 = -158;
            long num7 = 2000;

            ulong num8 = 2222222222; //Solo admite numeros positivos 

            //Procesamiento de decimales
            //float, se debe especificar con una f, 4 byte
            float num9 = 100.9f;

            //double, tiene mas alcance, 8 bytes
            double num10 = 100.9d;

            //decimal, 16 bytes
            decimal num11 = 100.9m;

            //guardar cadena de caracter, solo permite 2 bytes
            //los 2 bytes se usan para representar la letra
            char caracter = 'A'; //se encierra en comillas simples

            //string
            string texto = "Programacion Computacional I";

            //Variables de tipo implicito
            //var, para declarar cualquier tipo de dato integrado o un tipo definido
            Console.WriteLine("Cual es su nombre: ");
            var nombre = Console.ReadLine(); //Captura lo que el usuario escribe por teclado
            var cantidad = 100.50d;


            Console.WriteLine("El tipo de dato de la variable nombre es {0}", nombre.GetType());
            Console.WriteLine("El tipo de dato de la variable cantidad es {0}", cantidad.GetType());
            Console.ReadKey();



        }
    }
}
