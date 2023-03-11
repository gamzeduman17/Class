using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL2
{
  public class Program
    {
        static void Main(string[] args)
        {
            urun U1= new urun();
            U1.ekranaYaz("URUN NESNESİNDEN BU METOT ÇAĞRILDI.");
            baseClass B1= new baseClass();
            B1.ekranaYaz("baseCLASS NESNESİNDEN BU METOT ÇAĞRILDI.");

            Console.ReadLine(); 
        }
    }
}
