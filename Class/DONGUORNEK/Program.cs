using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DONGUORNEK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random random = new Random();
            //int number = random.Next(1, 20);
            //int tahminAdedi = 1;

            //while (true)
            //{
            //    Console.WriteLine("LÜTFEN TAHMİN ETTİĞİNİZ SAYIYI GİRİNİZ:");
            //    int tahminSayisi = Convert.ToInt32(Console.ReadLine());

            //    if (tahminSayisi == number)
            //    {

            //        Console.WriteLine("TEBRİKLER!!!SAYIYI {0}. DENEMEDE BİLDİNİZ.", tahminAdedi);
            //        tahminAdedi++;
            //        break;

            //    }
            //    else
            //    {

            //        Console.WriteLine("ÜZGÜNÜZ!!! SAYIYI {0}.DENEMEDE BİLEMEDİNİZ.", tahminAdedi);
            //        tahminAdedi++;
            //    }
            //}



            //string name = string.Empty;
            //string pass = string.Empty;
            //int counter = 0;
            //do
            //{
            //    if (counter > 0)

            //        Console.WriteLine("{0}.TRY! NAME OR PASSWORD IS WRONG! PLEASE TRY AGAIN...", counter);
            //    Console.WriteLine("USER NAME:");
            //    name = Console.ReadLine();
            //    Console.WriteLine("PASSWORD:");
            //    pass = Console.ReadLine();


            //    counter++;


            //} while (name.ToLower() != "demo" || pass.ToLower() != "demo");
            //Console.WriteLine("LOGGING SUCCESSFULLY! {0}.TRY", counter);

            //int guess;
            //int counter = 0;
            //Random rand = new Random();
            //int number = rand.Next(1, 10);
            //Console.WriteLine("PLEASE WRITE A NUMBER:");
            //guess = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    if (counter > 0)
            //        counter++;
            //    Console.WriteLine("{0}.TRY! PLEASE TRY AGAIN", counter);

            //    break;

            //} while (number == guess);

            //Console.WriteLine("CONGRATS! {0}. TRY ", counter);


            Console.WriteLine("PLEASE SELECT A PROCESS");
            Console.WriteLine("1.ADD A VALUE \n 2.VALUE LIST \n 3.SEARCH A VALUE \n 4.EDIT VALUES \n 5.DELETE A VALUE \n 6.EXIT");
            ArrayList valueList = new ArrayList();
            int chose = Convert.ToInt32(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    Console.WriteLine("PLEASE WRITE THE VALUE THAT YOU WANT TO ADD:");
                    string value1 = Convert.ToString(Console.ReadLine());
                    valueList.Add(value1);
                    Console.WriteLine("ITEM ADDED SUCCESSFULLY!");
                    break;
                case 2:
                    valueList.Sort();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("PLEASE WRITE THE VALUE THAT YOU WANT TO SEARCH:");
                    string value2 = Convert.ToString(Console.ReadLine());
                    int indexValue = valueList.IndexOf(value2);
                    Console.WriteLine(indexValue);
                    break;

                case 4:
                    Console.WriteLine("PLEASE WRITE THE VALUE THAT YOU WANT TO RECHANGE:");
                    string value3 = Convert.ToString(Console.ReadLine());
                    bool control = valueList.Contains(value3);
                    if (control == true)
                    {

                        valueList.Remove(value3);
                        Console.WriteLine("VALUE REMOVED SUCCESSFULLY");
                        break;
                    }
                    else
                        Console.WriteLine("SYSTEM COULD NOT FIND THE VALUE THAT YOU WANTED TO CHAGE");
                    break;
                case 5:
                    Console.WriteLine("PLEASE WRITE THE VALUE THAT YOU WANT TO DELETE:");
                    string value4 = Convert.ToString(Console.ReadLine());
                    valueList.Remove(value4); Console.WriteLine("VALUE REMOVED SUCCESSFULLY");
                    break;

                case 6:
                    Console.WriteLine("GOODBYE!!!");
                    
                    break;
                    System.Threading.Thread.Sleep(3000);



            }







            Console.ReadLine();
        }
    }
}
