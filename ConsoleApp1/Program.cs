using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Listas ob = new Listas();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("   DIGITE PALABRA A INVERTIR: \n--------------------------------");
                Console.ForegroundColor= ConsoleColor.White;
                string ss = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.Write(" ");
                foreach (string s in ob.Listado(ss))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(s);
                    Console.ForegroundColor= ConsoleColor.White;
                }
                Console.WriteLine("\n");
                ob.Inverso(ob.Listado(ss));
                Console.WriteLine("\n--------------------------------");
            }
            
        }
    }
}
