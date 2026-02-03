
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Aufgabe_StringReverse
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Text eingeben: ");
                string text = Console.ReadLine();

                string text_neu = "";
                    
                    for(int i = text.Length -1; i >= 0; i--)
            {
                text_neu += text[i]; 
            }
            Console.WriteLine(text_neu);




                /*char[] zeichen = text.ToCharArray();
                Array.Reverse(zeichen);

                Console.WriteLine(new string(zeichen));*/
            }
        }
    }

