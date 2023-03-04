using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONGUORNEK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int number = random.Next(1, 10);
            int tahminAdedi = 1;

            while (true)
            {
                Console.WriteLine("LÜTFEN TAHMİN ETTİĞİNİZ SAYIYI GİRİNİZ:");
                int tahminSayisi = Convert.ToInt32(Console.ReadLine());

                if (tahminSayisi == number)
                {

                    Console.WriteLine("TEBRİKLER!!!SAYIYI {0}. DENEMEDE BİLDİNİZ.", tahminAdedi);
                    tahminAdedi++;
                    break;

                }
                else
                {

                    Console.WriteLine("ÜZGÜNÜZ!!! SAYIYI {0}.DENEMEDE BİLEMEDİNİZ.", tahminAdedi);
                    tahminAdedi++;
                }
            }
            Console.ReadLine();
        }
    }
}
