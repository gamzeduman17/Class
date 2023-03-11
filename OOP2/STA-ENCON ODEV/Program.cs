using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STA_ENCON_ODEV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri m1 = new Musteri();
            m1.Isim = "GAMZE";
            m1.Soyisim = "DUMAN";
            m1.emailAdres = "lsdfjskdskg";
            m1.musteriID = 1;
            m1._kullaniciAdi = "GGG";
            m1.sifre = "123";

            Musteri.MusteriEkle(m1);


            Musteri m2 = new Musteri();
            m2.Isim = "RABIA";
            m2.Soyisim = "DUMAN";
            m2.emailAdres = "lsdjskdskg";
            m2.musteriID = 2;
            m2._kullaniciAdi = "RRR";
            m2.sifre = "1234";

            Musteri.MusteriEkle(m2);

            Musteri m3 = new Musteri();
            m3.Isim = "GAMZE";
            m3.Soyisim = "DUMAN";
            m3.emailAdres = "lsdfjskdskg";
            m3.musteriID = 1;
            m3._kullaniciAdi = "GGG";
            m3.sifre = "123";

            Musteri.MusteriEkle(m3);

          

            Console.ReadLine();



        }
    }
}
