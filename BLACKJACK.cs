using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int win = 21, carta1 = 0, carta2 = 0, total = 0, cartaP = 0;

            Console.WriteLine("¡¡Hola jugador, espero este usted listo!!");
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
            Console.WriteLine("Su total fue: " + total);
        }
    }
}
