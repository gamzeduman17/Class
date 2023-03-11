using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Musteri
    {
        int id;
        public string ad;
        private string emailAdres;
        private string _tckimliknumarasi;

        public string tckimliknumarasi
        {
           get { return _tckimliknumarasi.Substring(0,3); }
            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        { }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("TC KİMLİK NUMARASI SAYISAL DEĞER OLMALIDIR.");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }

                }
                else
                {
                    Console.WriteLine("TC NUMARANIZ 11 HANELİ OLMAK ZORUNDADIR!");
                }



            }
        }
        public Musteri()
        {
            this.id = IDUret();
        }

        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }



        }

        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }
    }
}
