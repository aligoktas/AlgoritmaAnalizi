using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2a
{
    class Program
    {
        public static int DiziMaxEleman(int[] dizi)
        {
            int maxEleman = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > maxEleman)
                {
                    maxEleman = dizi[i];
                }

            }
            return maxEleman;
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
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] +" ");
               

            }
            Console.WriteLine("Dizinin Maximum elemanı =  " + DiziMaxEleman(a));


        }
    }
}
