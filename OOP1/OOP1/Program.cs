using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Arac a1 = new Arac("OPEL", "CORSA", 2010, 560000);
            a1.alis_fiyati = 280000;
            a1.satis_fiyati = 350000;
            a1.maxIndirim_tutari = 1500;
            a1.fiyat =//FİYATI DEĞİŞEMİYORUZ CAPSULLEME KONUSUUU!!!!

            a1.FiyatAta(30000);
            a1.BilgileriGoruntule();
            Console.ReadKey();


        }
    }
}
