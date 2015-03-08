using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2a
{
    class Program
    {
        public static int EnBuyukEleman(int[] dizi)
        {
            int enbuyukEleman = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enbuyukEleman)
                {
                    enbuyukEleman = dizi[i];
                }

            }
            return enbuyukEleman;
        }
        static void Main(string[] args)
        {

            int[] a = { 10, 5, 12, -1, 7, 13, 9, 0 };
            Console.WriteLine("En büyük eleman: " + EnBuyukEleman(a));


        }
    }
}
