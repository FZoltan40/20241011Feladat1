using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Feladat1
{
    internal class Program
    {
        public static List<int> lista = new List<int>();
        public static void feltolt()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) 
            { 
                lista.Add(rnd.Next(1,101));

            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]+",");
            }
        }

        public static int minimum()
        {
            int min = lista[0];

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < min)
                {
                    min = lista[i];
                }
            }

            return min;
        }

        public static int maximum()
        {
            int max = lista[0];

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > max)
                {
                    max = lista[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            feltolt();
            Console.WriteLine();
            Console.WriteLine(minimum());
            Console.WriteLine();
            Console.WriteLine(maximum());
        }
    }
}
