using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortedList
{

    internal class Program
    {

        public static List<Customer> list = new List<Customer>();//en dışa tanımladığımıozda diğer class lardan hemen 
        //erişilebilir PUBLIC OLMAK ZORUNLULUĞLA
        public class Customer
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Address { get; set; }
            public int tel { get; set; }

            public string mail { get; set; }

            public int puan { get; set; } = 0;

        }
        static void Main(string[] args)
        {








            list.Add(new Customer { Name = "AYŞE", Surname = "DUMAN", Address = "İST", mail = "a@gmail.com", puan = 0 });
            list.Add(new Customer { Name = "GAMZE", Surname = "DUMAN", Address = "İST", mail = "g@gmail.com", puan = 0 });
            list.Add(new Customer { Name = "OYA", Surname = "MANDUZ", Address = "SİVAS", mail = "o@gmail.com", puan = 0 });
            list.Add(new Customer { Name = "KÜBRA", Surname = "GÜL", Address = "ORDU", mail = "k@gmail.com", puan = 0 });





            Console.WriteLine("SİSTEME HOŞGELDİNİZ:)");
            Console.WriteLine("KAYIT OLMAK İÇİN 1'E BASINIZ.");
            Console.WriteLine("KAYITLI KULLANICI İSENİZ 2'YE BASINIZ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("LÜTFEN AŞAĞIDA İSTENEN BİLGİLERİ EKSİKSİZ GİRİNİZ:");
                    Thread.Sleep(1000);
                    Console.Write("ADINIZ:");
                    Customer newuser = new Customer();
                    newuser.Name = Console.ReadLine();

                    Console.Write("SOYADINIZ:");
                    newuser.Surname = Console.ReadLine();


                    Console.Write("ADRES GİRİNİZ:");

                    newuser.Address = Console.ReadLine();
                    Console.Write("MAIL ADRESİ GİRİNİZ:");
                    newuser.Address = Console.ReadLine();
                    MUSCLASS newuser1 = new MUSCLASS();

                    Console.WriteLine(newuser1.AddNew(newuser));//geri dönüş tipi string oldupu için direkt yazacak
                    break;

                    
                case 2:

                    Console.WriteLine("KULLANICI ADI GİRİNİZ:");
                    string ad = Console.ReadLine().ToLower();
                    Console.WriteLine("KULLANICI ŞİFRE GİRİNİZ");
                    string sifre = Console.ReadLine();

                    Console.WriteLine("BAŞARILI BİR ŞEKİLDE GİRİŞ YAPTINIZ. \n ŞİMDİ HANGİ İŞLEMİ YAPMAK İSTİYORSUNUZ? ");
                    Console.WriteLine("1.MAIL ADRESİ GÜNCELLEME \n 2.ADRES GUNCELLEME \n 3.ÇIKIŞ YAP");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            Console.WriteLine("ÖNCE ESKİ MAİL ADRESİNİ GİRİNİZ");
                            Customer newmail = new Customer();//bunu customer türünde aldık çünkü metot onu bekliyor...
                            newmail.mail = Console.ReadLine();
                            MUSCLASS newmail1 = new MUSCLASS();

                            Console.WriteLine(newmail1.MailKontrol(newmail));

                            break;

                        case 2:
                            Console.WriteLine("ÖNCE ESKİ ADRESİNİZİ GİRİNİZ");
                            Customer newadres = new Customer();
                            newadres.Address = Console.ReadLine();
                            MUSCLASS newadres1 = new MUSCLASS();

                            Console.WriteLine(newadres1.AdresKontrol(newadres));
                            break;


                        case 3:
                            Console.WriteLine("GÜLE GÜLE :)");

                            Thread.Sleep(2000);

                            Environment.Exit(0);

                            break;
                        default:
                            break;
                            
                    }
                    break;
            }







            Console.ReadLine();


        }
    }
}
