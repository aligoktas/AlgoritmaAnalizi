using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2c
{
    class Program
    {
        public static int DiziSırala(int[] dizi, long k)
        {
            int gecici = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < k + 1; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;

                    }
                }

            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine(" ");
            return dizi[k];

        }
        static void Main(string[] args)
        {
            long diziSize = 0;
            int sayi = 0;

            Console.WriteLine("Dizi kaç elemanlı olsun :  ");
            diziSize = Convert.ToInt64(Console.ReadLine());
            int[] a = new int[diziSize];

            Random rnd = new Random();
            for (int i = 0; i < diziSize; i++)
            {
                sayi = rnd.Next(1, 1000);
                a[i] = sayi;

            }
            Console.WriteLine("Sıralanmamış Dizi :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");


            }
            long k=0;//istenilen eleman
         
            
            Console.WriteLine(" ");

            Console.Write("Kaçıncı Eleman : ");
            k = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(DiziSırala(a, k));
            

         
        }
       
     
    }
}
