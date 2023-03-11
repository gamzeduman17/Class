using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL2
{
    public class baseClass
    {

        public virtual void ekranaYaz(string data)//virtual ekleyince sanal olur
            //metot body'e eklenerek ezmeye çalışıyoruz.
        {

            Console.WriteLine(data);
        }
    }
}
