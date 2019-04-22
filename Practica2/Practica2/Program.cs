using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\A01566180\Documents\lectura.txt");

            Console.WriteLine(text);

            string[] numeros = text.Split();
            int numero1 = Convert.ToInt32(numeros);
            foreach (string numero in numeros)
            {
                Console.WriteLine("Numero: " + numero);
            }
        }
    }
}
