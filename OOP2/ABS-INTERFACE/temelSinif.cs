using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_INTERFACE
{
    public abstract class temelSinif//ben kurallara 
        //uyulamsını bu class'ın şablon olarak kullanılmasını istiyorum demek ABSTRACT eklemek
    {//program.cs de kullanamayız demek
         public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get;}
        public temelSinif()
        {
            kayitTarih= DateTime.Now;
            guncellemeTarih= DateTime.Now;
        }
    }
}
