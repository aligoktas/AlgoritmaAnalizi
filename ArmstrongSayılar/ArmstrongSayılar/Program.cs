using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            int birler = 0;
            int onlar = 0;
            int yuzler = 0;
            int sayi = 0;

            int armstrong_sayi = 0;
            System.Console.WriteLine("100-1000 arasındaki Armstrong Sayıları");

            for (int i = 100; i <= 999; i++)
            {

                sayi = i;

                birler = sayi % 10;
                sayi = sayi / 10;

                onlar = sayi % 10;
                sayi = sayi / 10;

                yuzler = sayi % 10;

                armstrong_sayi = birler * birler * birler + onlar * onlar * onlar + yuzler * yuzler * yuzler;

                if (i == armstrong_sayi)
                {
                    System.Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
