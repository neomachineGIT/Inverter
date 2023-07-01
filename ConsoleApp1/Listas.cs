using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Listas
    {
        public string[] Listado(string palab)
        {
            int cont = 0;
            string[] lis = new string[palab.Count()];
            foreach (char e in palab)
            {
                lis[cont] = e.ToString().ToLower();
                cont++;
            }
            return lis;
        }
        public string[] Inverso(string[] lis)
        {
            int cont = 0;
            string[] sil = new string[lis.Count()];
            for (int i = lis.Count() - 1; i > -1; i--)
            {
                sil[cont] = lis[i].ToString().ToLower();
                cont++;
            }
            Console.Write(" ");
            foreach (string s in sil)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
            return sil;
        }

    }
}
