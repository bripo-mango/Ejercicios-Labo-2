using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool auxNum;


            Console.WriteLine("Ingrese un numero: ");
            auxNum = int.TryParse(Console.ReadLine(), out numero);

        }

        static bool EsPrimo(int num)
        {
            if (num % 2 == 0)
                return true;

            return false;
            
        }

        static string NumerosPrimos(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if(EsPrimo(i))

            }
        }
    }
}
