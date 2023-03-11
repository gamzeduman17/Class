using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNERTYPE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri m= new Musteri();
            m.isim = "GAMZE";
            m.soyisim = "DUMAN";
            m.musteriID = 1;
            m.olusturmaTarih=DateTime.Now;
            m.tcKimlikNumarasi = "46293748237";
            m.musteriAdresListe[0] = new MusteriAdres()
            {

                il = "İstanbul",
                ilce = "Kartal",
                Adres = "akjdhgsıjkal",
                adresTip="ev"

            };
            m.musteriSiparisiBilgileri[0] = new MusteriSiparisBilgisi()
            { musteriSiparisBilgisi="HEDİYE"

            };
            m.musteriİletisimBilgileri[0] = new MusteriIletişimBilgisi()
            {
                alankodu = "1",
                aktifPasif = true,
                numara = "232",
                iletisimTip = 3
            };





            Console.WriteLine(m.musteriID);
            Console.WriteLine(m.kullaniciId);
            Console.WriteLine(m.olusturmaTarih);
            Console.WriteLine(m.isim);
            Console.WriteLine(m.soyisim);
            Console.WriteLine(m.musteriAdresListe);
            Console.WriteLine(m.musteriSiparisiBilgileri);
            Console.WriteLine(m.musteriİletisimBilgileri);

            Console.ReadKey();
           

        }
    }
}
