using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {0,1,2,3,4,5,6,7,8,9,10};
            int istenenEleman;
            Console.WriteLine("Kaçıncı Eleman : ");
            istenenEleman = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ElemanBul(istenenEleman, a));
        }
        public static int ElemanBul(int k , int[] dizi)
        {
             return dizi[k];
        }
    }
}
