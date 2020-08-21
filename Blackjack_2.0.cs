using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
           Random aleatorio = new Random();
            int win = 21, carta1 = 0, carta2 = 0, total = 0, cartaP = 0, juga = 0;
            int max = 0, max2 = 0, residuo = 0;
            string jugador = " ", jugador2 = " ";
            string[] granja = { " ", " ", " ", " ", " " };
            int[] puntajes = { 0, 0, 0, 0, 0 };


            Console.WriteLine("¡¡Hola jugadores, espero esten listos!!");
            Console.WriteLine("Ingrese el número de jugadores, maximo 5 minimo 2");
            juga = int.Parse(Console.ReadLine());

            for (int i = 0; i < juga; i++)
            {
                Console.WriteLine("Nombre: ");
                granja[i] = Console.ReadLine();

                Console.WriteLine(granja[i] + " Es tu turno...");
                carta1 = aleatorio.Next(1, 10);
                carta2 = aleatorio.Next(1, 10);
                total = carta1 + carta2;
                Console.WriteLine("Carta 1: " + carta1 + " Carta 2: " + carta2);

                while (true)
                {

                    if (total > win)
                    {
                        Console.WriteLine("PIERDES!!");
                        break;
                    }
                    else if (total == win)
                    {
                        Console.WriteLine("BLACKJACK!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Desea pedir una carta (s) o (n) ?");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "s")
                        {
                            cartaP = aleatorio.Next(1, 10);
                            Console.WriteLine("Carta pedida: " + cartaP);
                            total = total + cartaP;

                        }
                        else
                        {
                            break;
                        }
                    }
                }

                puntajes[i] = total;
                

                if (total > max) 
                {
                    max = total;
                    jugador = granja[i];

                }
                if (total > max2 && total != max)
                {
                    max2 = total;
                    jugador2 = granja[i];
                }

                Console.WriteLine("Jugador " + (i+1) + " Su total fue: " + total);


            }
            if (max == max2)
            {
                Console.WriteLine("EMPATE - " + jugador + " Y " + jugador2 + " tienen un puntaje de: " + max);
            }
            else
            {
                Console.WriteLine("El puntaje mas alto fue el de " + jugador + ": " + max);
                Console.WriteLine("El segundo puntaje mas alto fue el de " + jugador2 + ": " + max2);

            }



        }
    }
}
