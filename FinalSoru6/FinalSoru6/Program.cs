using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSoru6
{
    class Program
    {
        public static int[] altdiziBul(int [] array)
        {
            int sayac = 0;
            int ilkindis = 0;
            int sonindis = 0;
            int kontrol = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==0 && array[i+1]==0)
                {
                    sayac++;
                }
                if (sayac >= kontrol && array[i]==1)
                {
                    kontrol = sayac+1;
                 
                    sonindis = i-1;
                    ilkindis = sonindis - sayac;
                    sayac = 0;
                   
                }
            }
            int [] dizi= new int[kontrol]; 
            int j = 0;
            for (int i = ilkindis; i <= sonindis; i++)
            {
                dizi[j] = array[i];
                j++;

            }
            return dizi;
        }
        static void Main(string[] args)
        {
            int[] array = { 0, 0,0,0 ,1, 0, 1, 0, 1,0,0, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }

            Console.WriteLine(" ");

            int[] altdizi = altdiziBul(array);
            for (int i = 0; i < altdizi.Length; i++)
            {
                Console.Write(altdizi[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
