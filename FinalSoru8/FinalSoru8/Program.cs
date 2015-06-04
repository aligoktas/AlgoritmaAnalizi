using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSoru8
{
    class Program
    {
        public static void resize (ref long[] array, int n)
        { 
            int newsize = array.Length * n;
            Array.Resize(ref array, newsize);
            
      }

        static void Main(string[] args)
        {
            int a = 0;
            long[] dizi = new long[1];

            Console.WriteLine("Dizi Kaç elemanlı olsun.");
            a = Convert.ToInt32(Console.ReadLine());
          
            resize(ref dizi, a);

            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                dizi[i] = rnd.Next(100);
            
            }
            
            for (int i = a-1; i >= 0; i--)
            {
                Console.WriteLine(i + " . eleman =" + dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
