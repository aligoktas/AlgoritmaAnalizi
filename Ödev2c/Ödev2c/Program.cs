using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2c
{
    class Program
    {
        public static int Sort(int[] dizi, int k)
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
            int[] a = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int sayi = rnd.Next(1, 1000);
                a[i] = sayi;
            }

            int istenenEleman;
            Console.WriteLine("Sıralanmamış Dizi :" );
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
            
            Console.WriteLine(" ");

            Console.Write("Kaçıncı Eleman : ");
            istenenEleman = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sort(a, istenenEleman));
            

         
        }
       
     
    }
}
