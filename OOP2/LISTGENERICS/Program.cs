using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTGENERICS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);
            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 1;
            eklenecekData1[1] = 2;
            eklenecekData1[2] = 3;
            eklenecekData1[3] = 4;//1.yol ama uzun yol
            //for(int i=0;i<eklenecekData1.Length;i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            //2.yol 
            sayilarim.AddRange(eklenecekData1);
            int capacity=sayilarim.Count;
            int count = sayilarim.Count;

            int max = sayilarim.Max();
            Console.WriteLine(max);


            Console.ReadLine();





        }
    }
}
