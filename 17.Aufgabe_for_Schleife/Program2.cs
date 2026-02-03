using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _17.Aufgabe_for_Schleife
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Text eingeben: ");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

        }
    }
}
