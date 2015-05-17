using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if (baslangic < bitis)
            {
                i = partition(dizi, baslangic, bitis);
                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);
            }

        }
        public static int partition(int[] A, int baslangic, int bitis)
        {
            int gecici;
            int x = A[bitis];
            int i = baslangic - 1;

            for (int j = baslangic; j <= bitis - 1; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    gecici = A[i];
                    A[i] = A[j];
                    A[j] = gecici;
                }
            }
            gecici = A[i + 1];
            A[i + 1] = A[bitis];
            A[bitis] = gecici;
            return i + 1;
        }


        static void Main(string[] args)
        {
            Random sayi = new Random();
            int[] n1 = new int[10];

            Console.WriteLine("---------n1 dizisi sıralanmamış hali---------");
            for (int i = 0; i < n1.Length; i++)
            {
                n1[i] = sayi.Next(0, 100);
                Console.Write(n1[i]+"-");
            }
            Console.WriteLine();
            QuickSort(n1, 0, 9);
            Console.WriteLine("---------n dizisi sıralanmış hali---------");
            for (int i = 0; i < n1.Length; i++)
            {

                Console.Write(n1[i] + "-");
            }
            QuickSort(n1, 0, 9);
        
        }
    }
}
