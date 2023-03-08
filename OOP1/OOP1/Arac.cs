using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Arac
    {

        public string marka;
        public string model;
        public int model_yil;
        public decimal km;
        public int yakit_tipi;
        public int vites_tipi;
        public int alis_fiyati;
        public decimal satis_fiyati;
        public decimal maxIndirim_tutari;
        public int fiyat;


        public Arac() { }//yapıcı metot


        public Arac(string marka, string model, int model_yil,decimal km)
        {
            this.marka= marka;
            this.model= model;  
            this.model_yil= model_yil;
            this.km= km;
     
        }
        public void BilgileriGoruntule()
        {
            Console.WriteLine("ARAÇ MARKASI:" +marka);
            Console.WriteLine("ARAÇ MODEL:" + model);
            Console.WriteLine("ARAÇ MODEL YILI:" + model_yil);

        }

        public void FiyatAta(int _fiyat)
        {

            int FiyatHesabi = satis_fiyati - maxIndirim_tutari;
            if(_fiyat<FiyatHesabi)
            {
                Console.WriteLine("GEÇERSİZ FİYAT GİRDİNİZ!");



            }

            else
            {
                this.fiyat = _fiyat;//yeni fiyat ata
                Console.WriteLine("FİYATINIZ GÜNCELLENDİ.");

            }
        }
           
    }
}
