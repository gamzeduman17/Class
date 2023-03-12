using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
public class Program
    {
        static void Main(string[] args)
        {

            Musteri m= new Musteri();
            m.id = 1;
            m.isim = "g";
            m.soyisim = "d";
            m.musteriNumara = 11232;
            m.emailAdres = "lskjd";

            sanalDatabase s= new sanalDatabase();


          musteriReturnValue musteriKayitSonuc=s.musteriYeniKayit(m);
            if(musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }



            Console.ReadLine(); 

        }
    }
}
