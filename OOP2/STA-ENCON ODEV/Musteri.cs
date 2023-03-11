using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace STA_ENCON_ODEV
{
  public class Musteri
    {
        static ArrayList musteriDatabase;//aşağıda array kullanmak için tanımlamam lazımdı
                                     //static yapıcı metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        //sadece içeride kullanacağım metot (static çünkü)

        public int musteriID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string emailAdres { get; set; }
        public string _kullaniciAdi;
       public string sifre { get; set; }

        //encapsulation
        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; } set 
            {

                bool KullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if(KullaniciAdiKontrol)
                {
                    Console.WriteLine("BÖYLE BİR KULLANICI MEVCUT!");
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }

    
        static bool musteriKullaniciAdiKontrol(string _kullaniciadi)
        {
            //static arraylist içinde dönmem dönünce buldum diye söylemem lazım!!!!
            bool kontrol = false;

            for(int i=0;i<musteriDatabase.Count;i++)
            {
                //arraylistte object olarak saklı UNBOXING yapmam lazım ,NESNE oluşturmam lazım.
                Musteri Temp = (Musteri)musteriDatabase[i];
                if(Temp.KullaniciAdi==_kullaniciadi)
                {
                    kontrol = true; break;
                }


            }

            return kontrol;
        }
        public static void MusteriEkle(Musteri m)
        {

            //parametre kontrolü

            if(m!=null && !string.IsNullOrEmpty(m.KullaniciAdi) && !string.IsNullOrEmpty(m.emailAdres))
            { bool emailAdresKontrol=musteriEmailAdresKontrol(m.KullaniciAdi);
                if(emailAdresKontrol)
                {
                    Console.WriteLine("EKLEMEK İSTEDİĞİNİZ KULLANICI SİSTEMDE KAYITLI.");
                }
                else
                {
                    musteriDatabase.Add(m);
                    Console.WriteLine("KULLANICI BAŞARIYLA EKLENDİR.");
                }

            }
        }
        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool kontrol = false;
            for(int i=0;i<musteriDatabase.Count;i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if(Temp.emailAdres==_emailAdres);
                {
                    kontrol = true;
                    break;
                }

            }
            return kontrol; 
        }
    }
}
