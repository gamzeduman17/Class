using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
   public static class sanalDatabase

    {
        private static ArrayList db=new ArrayList();
        public static void yeniurunEkle(baseClass data)//baseclass'tan türeyenleri eklemek için
        { if(data!=null && string.IsNullOrEmpty(data.barkod))
            {

                db.Add(data);
            }


        }
        static bool markaKontrolEkle(string _marka)
        {
            bool kontrol = false;
            for (int i = 0; i < db.Count; i++)
            {
                Urun urun = (Urun)db[i];
                if (urun.marka == _marka)
                {

                    Console.WriteLine("BU MARKA ZATEN SİSTEMDE MEVCUT");
                }
                else
                {

                    db.Add(_marka);

                }


            }
            return kontrol;
        }

    }

}
