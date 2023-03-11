using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //temelTip T1= new temelTip();
            //T1.TemelTipMetot1();


            //Egitmen E1= new Egitmen();
            //E1.TemelTipMetot1();
            ////BOXING UNBOXING

            //object O1 = E1;
            //E1=(Egitmen)O1; 

            Bilgisayar B1= new Bilgisayar();
            //B1._id = 1;    //BUNU BEN GİRMEK İSTEMİYORUM,SET EDİLEBİLSİN İSTEMİYORUM.//baseClass'da private yaptık
            //ilk oluşunda 1 değeri alsın 
            B1.marka = "LENOVO";
            B1.model = "12";
            B1.islemci = "I5";
            B1.alisFiyat =1500M;
            B1.satisFiyat = 1400M;
            B1.kampanyaFiyat = 1500M;
            B1.barkod = "KDJGASFK";
            B1.ram = "12";
            B1.ekranKarti = "DASF";
            B1.marka = "Q";

            sanalDatabase.yeniurunEkle(B1);

            Console.WriteLine(B1);
          


            Console.ReadKey();  
        }
    }
}
