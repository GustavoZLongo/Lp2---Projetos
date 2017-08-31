using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int x = int.Parse(Console.ReadLine());

            int[] vetor = { 1, 3, 5, 7, 4 };

            //imprimir o vetor
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            foreach (int i in vetor)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("A tabuada é:");

            for (int i = 0; i <= 10; i++)
            {
                //Console.WriteLine(x +"x" + i + "=" + (x*i));
                Console.WriteLine($"{x} x {i} = {x * i}");

            }

            Console.WriteLine("\rA tabuada dos pares é:");

            for (int i = 0; i <= 10; i++)
            {
                if ((x * i) % 2 == 0)
                {
                    Console.WriteLine($"{x} x {i} = {x * i}");

                }

            }

            //imprime se um numero é positivo ou negativo
            string resultado = x >= 0 ? "Positivo" : "Negativo";
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
