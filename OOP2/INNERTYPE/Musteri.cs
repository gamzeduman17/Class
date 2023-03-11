using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNERTYPE
{
   public class Musteri
    {

        //tekil alan,müşteriye ait alan
        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciId { get; set; }


        //inner typeta bir sürü adres,iletişim bilgileri olacağı için onu farklı class'da tanımlamamız daha doğru

        public MusteriAdres[] musteriAdresListe;//adresleri dizi-koleksiyona çevirdik
        public MusteriIletişimBilgisi[] musteriİletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisiBilgileri;

        public Musteri()
        {

            musteriAdresListe = new MusteriAdres[5];
            musteriİletisimBilgileri = new MusteriIletişimBilgisi[10];
            musteriSiparisiBilgileri = new MusteriSiparisBilgisi[10];

        }



    }
}
