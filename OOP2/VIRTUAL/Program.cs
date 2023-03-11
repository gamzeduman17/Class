using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL
{
   public class Program
    {
        static void Main(string[] args)
        {

            Musteri m=new Musteri();
            m.isim = "GAMZE";
            m.soyisim = "DUMAN";
            string toStringMesaj = m.ToString();
            Console.WriteLine(toStringMesaj);



            Console.ReadKey ();
        }
    }
}
