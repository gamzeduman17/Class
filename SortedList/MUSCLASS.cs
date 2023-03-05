using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class MUSCLASS
    {
        public string AddNew (Program.Customer _customer)//BU MET PROGRAM.CS'DE BULUNUNAN CUSTOMER CLASS'INDAN 
            //PARAMETRE BEKLİYOR //PROGRAMDAKİ CUSTOMER NESNESİ TÜRÜNDE PARAMTRE BEKLER//_customer o kişiyi bekler o kişi 
            //ekleyeceğimiz yani kontrol etmemiz gereken kişi
            //bu metot string yazdığımız iççin string dönderir
            //
        {
            string result = "";

            foreach (var item in Program.list)
            {
                if (item.Name == _customer.Name)
                {
                    result = "BU KULLANICI SİSTEMDE MEVCUT!";
                    break;
                    
                }
            }
            if (result=="")
            {
                Program.list.Add(_customer);
                result = "KULLANICI EKLENDİ ve YENİ KAYIT PUANINIZ HESABINIZA EKLENDİ. \n PUAN=100";
            }
           
            
            return result;

        }
        public string MailKontrol(Program.Customer _mail)


        {
            int mailK = Program.list.IndexOf(_mail);
            Program.list[mailK].mail = _mail.mail;

            return "GÜNCELLEME BAŞARIYLA GERÇEKLEŞTİ.";
            
 





        }
        public string AdresKontrol(Program.Customer _adres)


        {
            int adresK = Program.list.IndexOf(_adres);
            Program.list[adresK].Address = _adres.Address;

            return "GÜNCELLEME BAŞARIYLA GERÇEKLEŞTİ.";







        }

    }
}
