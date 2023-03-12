using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTIAL
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Musteri m1= new Musteri();  
            m1.id= 1;
            m1.ad = "gamze";
            m1.soyad = "duman";
            m1.emailAdres = "alsfhkdf";
            m1.yeniKayit(m1);


            ogrenci o= new ogrenci();
            o.id = 1;
            o.yeniKayit(o);

            Console.ReadLine();

        }
    }
}
