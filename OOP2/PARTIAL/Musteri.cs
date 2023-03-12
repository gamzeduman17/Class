using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL
{
    public class Musteri
    {
        public int id { get; set; }
        public string ad { get; set; }
       public string soyad { get; set; }
       public string emailAdres { get; set; }

        public int yeniKayit(Musteri m)
        {
            Console.WriteLine("DB YE KAYIT İŞLEMİ YAPILDI.");
            return 1;
        }

        public int kayitGuncelle(Musteri m)
        {

            Console.WriteLine("MÜŞTERİ GÜNCELLENDİ.");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("KAYIT SİLİNDİ.");
            return 1;
        }
    }
}
