using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    public class sanalDatabase
    {

        ArrayList sanalDB = new ArrayList();
        public musteriReturnValue musteriYeniKayit(Musteri m)
        {
            sanalDB.Add(m);
            return musteriReturnValue.kayitBasarili;
        }
    }
}