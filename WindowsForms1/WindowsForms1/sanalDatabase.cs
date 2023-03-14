using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms1
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo=new List<kullanici>();
        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id=1,
                isim="GAMZE",
                soyisim="DUMAN",
                KullaniciAdi="gamze.duman",
                sifre="1",
                aciklama="GAMZE DUMAN KULLANICISI PROFİL BİLGİSİ",
                
            });

            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "MURAT",
                soyisim = "DUMAN",
                KullaniciAdi = "gamze.duman",
                sifre = "2",
                aciklama = "MURAT DUMAN KULLANICISI PROFİL BİLGİSİ",

            });


        }
    }
}
