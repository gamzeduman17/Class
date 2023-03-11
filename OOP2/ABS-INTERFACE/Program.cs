using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_INTERFACE
{
    public  class Program
    {
        static void Main(string[] args)
        {

          Musteri m=new Musteri();
            m.kayitTarih=DateTime.Now;

            Console.WriteLine(m.kayitTarih);

            Console.ReadKey();  


        }
    }
}
