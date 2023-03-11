using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL
{
    public class Musteri
    { 
        public string isim
        { get; set; }
        public string soyisim { get; set; }

        public int musteriID { get; set; }



        public override string ToString()
        {
            //return base.ToString();//base yeri(base olmayabilir) önceki kalıtılmış kısmı gösterir.
            return isim + " " + soyisim;
        
        }
    }
}
