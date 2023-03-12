using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_ONCESI
{
    public class sanalDatabase
    {
        private ArrayList listem;
        public sanalDatabase()
        {
            listem = new ArrayList();

        }

        public void yeniKayit(int data)
        {
            listem.Add(data);
        }
    }
}
