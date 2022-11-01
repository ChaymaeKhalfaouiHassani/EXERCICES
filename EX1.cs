using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class exercices
    {
        static void Main(String[] args)
        {
            //------------ex1------------//
            int n;
            Console.WriteLine("entrez un nombre entier :");
            n = int.Parse(Console.ReadLine());
            IsPrime(n);
           

        }
        public static void IsPrime(int n)
        {
            int D = 1;
            int Racine = (int)Math.Sqrt(n);
            for (int i = 0; i < Racine; i++)
            {
                D = 0;
                break;
            }
            if (D == 0)
            {
                Console.WriteLine("Pas Premier");
            }
            else
                Console.WriteLine("Premier");
        }
       
    }
}
