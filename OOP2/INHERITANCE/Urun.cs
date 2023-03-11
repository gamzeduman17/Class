using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class Urun : baseClass
    {
        private decimal _alisFiyati;
        public decimal alisFiyat
        {
            get { return alisFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ALIŞ FİYATI SIFIRDAN KÜÇÜK OLAMAZ!");
                }
                else
                {

                    alisFiyat = value;
                }

            }
        }

        //0 dan küçük olmamalı >>ENCAPSULATION
    private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get { return satisFiyat; }
            set
            {
                if (value <satisFiyat)
                {
                    Console.WriteLine("SATIŞ FİYATI ALIŞ FİYATINDAN KÜÇÜK OLAMAZ!");
                }
                else { satisFiyat = value; }


            }
        }//satış alıştan küçük olmamalı >>ENCAPSULATION
        public string marka { get; set; }//belirtmiş olduğumuz markalardan alınmasını istiyoruz >>ENCAPSULATION
        public string model { get; set; }
        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return kampanyaFiyat; }
            set
            {
                if (kampanyaFiyat <= 0)
                {
                    Console.WriteLine("KAMPANYA FİYATI O VE O'DAN KÜÇÜK OLAMAZ!");

                }

                else
                {

                    kampanyaFiyat = value;

                }
            }
        }//kampanya 0'dan küçük olamaz. >>ENCAPSULATION


      

    }
}
