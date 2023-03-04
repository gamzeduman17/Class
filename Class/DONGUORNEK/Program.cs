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

            //Random random = new Random();
            //int number = random.Next(1, 10);
            //int tahminAdedi = 1;

            //while (true)
            //{
            //    Console.WriteLine("LÜTFEN TAHMİN ETTİĞİNİZ SAYIYI GİRİNİZ:");
            //    int tahminSayisi = Convert.ToInt32(Console.ReadLine());

            //    if (tahminSayisi == number)
            //    {

            //        Console.WriteLine("TEBRİKLER!!!SAYIYI {0}. DENEMEDE BİLDİNİZ.", tahminAdedi);
            //        tahminAdedi++;
            //        break;

            //    }
            //    else
            //    {

            //        Console.WriteLine("ÜZGÜNÜZ!!! SAYIYI {0}.DENEMEDE BİLEMEDİNİZ.", tahminAdedi);
            //        tahminAdedi++;
            //    }
            //}



            string name = string.Empty;
            string pass = string.Empty;
            int counter = 0;
            do
            {
                if (counter > 0)

                Console.WriteLine("{0}.TRY! NAME OR PASSWORD IS WRONG! PLEASE TRY AGAIN...", counter);
                Console.WriteLine("USER NAME:");
                name = Console.ReadLine();
                Console.WriteLine("PASSWORD:");
                pass = Console.ReadLine();


                counter++;


            } while (name.ToLower() != "demo" || pass.ToLower() != "demo");
            Console.WriteLine("LOGGING SUCCESSFULLY! {0}.TRY", counter);






            Console.ReadLine();
        }
    }
}
