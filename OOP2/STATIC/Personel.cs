using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    internal class Personel
    {
        public static string domainAdres = "firmam.com";
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        private string _emailadres;
        public string Emailadres
        {
            get { return this._emailadres; } set { _emailadres = value.ToLower() + "@" +Personel.domainAdres; }
        }

        public int Cinsiyet { get; set; }
    }
}
