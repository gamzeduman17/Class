using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class MUSTERILER
    {
        public string kullanici_ad;
        public string mail;
        public int tel_no;
        public int sifre;
        public int dogum_yili;
        public string sehir;
        public int satinAlmaAdedi;
        public MUSTERILER(string kullanici_ad, string mail, int tel_no, int sifre, int dogum_yili, string sehir, int satinAlmaAdedi)
        {
            this.kullanici_ad = kullanici_ad;
            this.mail = mail;
            this.tel_no = tel_no;
            this.sifre = sifre;
            this.tel_no = tel_no;
            this.dogum_yili = dogum_yili;
            this.satinAlmaAdedi = satinAlmaAdedi;
        }



        public double MusteriPuanHesabi()
        {
            int satinAlmaAdedi;
           double puan = satinAlmaAdedi * (10 / 100);// kırmızı nedeğğğğğnn :(((
            return satinAlmaAdedi;

        }

    }
}
