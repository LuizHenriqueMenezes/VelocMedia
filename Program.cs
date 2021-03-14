using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para calcule a velocidade,digite: ");

            Console.WriteLine("Distância percorrida (metros): ");
            double metros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tempo gasto (segundos): ");
            double segundos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Velocidade média: ");
            double resultado = (metros/segundos);
            Console.WriteLine($"{resultado} m/s.");


        }
    }
}
