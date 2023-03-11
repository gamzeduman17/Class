using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Personel p1= new Personel();
            p1.Isim = "GAMZE";
            p1.Soyisim = "DUMAN";
            p1.Cinsiyet = 3712434;
            p1.Emailadres = "GAMZEDUMAN";



            Console.WriteLine(p1.Isim);
            Console.WriteLine(p1.Soyisim);
            Console.WriteLine(p1.Cinsiyet);
            Console.WriteLine(p1.Emailadres);

            Helper.emailGonder("ik.firmam@gmail.com", "yeni alım", "hatırlatma"+p1.Isim +p1.Soyisim);

            Console.ReadKey();

        }
    }
}
