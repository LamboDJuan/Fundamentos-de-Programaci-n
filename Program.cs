using System;

namespace Tutpria_30Jul
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string namemax = " ", namemin = " ";

            while (i < n)
            {
                Console.WriteLine("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su nómbre: ");
                string name;
                name = Console.ReadLine();

                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    namemax = name;
                    namemin = name;
                }
                if (edad > max)
                {
                    max = edad;
                    namemax = name;

                }
                if (edad < min)
                {
                    min = edad;
                    namemin = name;
                }
                total += edad;
                i++;
            }
            double promedio = (double)total / n;
            Console.WriteLine("Promedio =  " + promedio);
            Console.WriteLine("Mayor = " + namemax + ": " + max + " años");
            Console.WriteLine("Menor = " + namemin + ": " + min + " años");
        }
    }
}
