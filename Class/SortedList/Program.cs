using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList musteri1= new ArrayList();
            musteri1.Add("GAMZE DUMAN \n ");
          
            Console.WriteLine("HOŞGELDİNİZ");
           Console.WriteLine("GİRİŞ YAPMAK İÇİN 1'E BASINIZ.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("KAYITLI KULLANICI DEĞİLSENİZ KAYIT OLMAK İSTER MİSİNİZ??? \n EVET için E \n HAYIR için H");
           
            string secim=Convert.ToString(Console.ReadLine());
            if(secim=="1")
            { Console.WriteLine("LÜTFEN KULLANICI ADI VE ŞİFRE GİRİNİZ. \n Kullanıcı Adı: \n Şifre:"); 
                string kullanici_adi=Convert.ToString(Console.ReadLine());  
                int sifre=Convert.ToInt32(Console.ReadLine());

                if(kullanici_adi=="GAMZE" && sifre==1234)
                {

                    Console.WriteLine("BAŞARILI BİR ŞEKİLDE GİRİŞ YAPTINIZ. \n ŞİMDİ HANGİ İŞLEMİ YAPMAK İSTİYORSUNUZ? ");
                    Console.WriteLine("1.MAIL ADRESİ GÜNCELLEME \n 2.SIFRE GUNCELLEME \n 3.TEL NO" +
                        " GÜNCELLEME \n 4.ADRES GÜNCELLEME \n 5.MUSTERI PUANI HESAPLAMA");
                    int secim1=Convert.ToInt32(Console.ReadLine());
                    switch(secim1)
                    {
                        case 1: //ascjkvhjzkxvczhj








                    }







                }
            
             else if(secim.ToLower()=="E")

                {
                    Console.WriteLine("LÜTFEN KULLANICI ADI VE ŞİFRE BELİRLEYİNİZ. \n Kullanıcı Adı: \n Şifre:");
                    string kullanici_adi1 = Convert.ToString(Console.ReadLine());
                    int sifre1 = Convert.ToInt32(Console.ReadLine());

                    musteri1.Add(kullanici_adi1);
                    musteri2.Add(sifre);//bu ikisini ve diğer bilgileri nasıl aynı listeye atabilirim????



                }

                else
                {
                    Console.WriteLine("HOŞÇAKALIN:)");
                    System.Threading.Thread.Sleep(2000);
                    
                }
            
            }



        }
    }
}
