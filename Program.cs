using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_de_mayor_a_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tres números enteros diferentes:");

            Console.Write("Primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                int mayor = num1;

                if (num2 > mayor)
                {
                    mayor = num2;
                }

                if (num3 > mayor)
                {
                    mayor = num3;
                }

                Console.WriteLine($"El mayor número es: {mayor}");
            }
            else
            {
                Console.WriteLine("Los números deben ser diferentes.");
            }
        }
    }
}