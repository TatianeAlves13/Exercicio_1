using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nTabuada do {numero: D3}:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"\n{numero:D3} x {i:D3} = {(numero * i):D3}");
            }

            Console.ReadLine();


        }





    }
}