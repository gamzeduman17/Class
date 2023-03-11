﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class temelTip
    {

        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("TEMEL TİP NESNESİNE YAPICI METOT UYGULANDI.");
            IdAtamaIslemi();
        }
        private void IdAtamaIslemi()
        {
            Random rnd=new Random();
            this.id= rnd.Next(10000,90000);
        }
        public void TemelTipMetot1()
        {
            Console.WriteLine("TEMEL TİP => METOT 1");
        }
    }
}
