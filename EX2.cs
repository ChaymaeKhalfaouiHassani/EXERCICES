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
           
            int n;
            int[] tab = { 1, 3, 4, 6, 7, 9 };
            Console.WriteLine("entrer l'element a ranger dans le tableau:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Avant tri:");
            afficher(tab);
            Console.WriteLine("apres tri");
            Inserer(tab, n);
            afficher(tab);

        }
        
        public static void afficher(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        public static void Deplacer(int[] tab, int position)
        {
            int A;
            for (int i = 0; i < tab.Length; i++)
            {
                A = tab[i];
                tab[i] = tab[i + 1];
                tab[i + 1] = A;
            }
        }
        public static void Inserer(int[] tab, int n)
        {
            int position = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] >= n)
                {
                    position = i;
                }
            }
            Deplacer(tab, position);
        }
    }
}
