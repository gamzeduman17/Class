using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class baseClass

        
    {
        public int sayac = 1;

        private int _id
        {
            get { return _id; }
             set
            {
                //_id = sayac;
                //sayac = sayac + 1;//bir sayaç içerisindeki değerden faydalanmak istiyorum.
                //burda sayac artmadı çünkü private içinde o yüzden aşağıdaki baseClass kullandık
            }


        }


        public baseClass()
        {
            _id = sayac;
            sayac = sayac + 1;

        }
       
        public string barkod { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }

      
        

       
    }
}
