using System;
using System.Collections.Generic;
using System.Linq;
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
        }
        static void Main(string[] args)
        {
            feltolt();
        }
    }
}
