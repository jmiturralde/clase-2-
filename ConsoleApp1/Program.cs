using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hola");
            //int i = 0;
            ////python while i<10:
            //while (i<10)
            //// i++ = i+=1 
            //{  if (i < 3)
            //   {
            //        Console.WriteLine("soy menor que 3");
            //   }
            //    else if (i >= 3 && i <= 7) { Console.WriteLine("estoy entre 3 y 7"); }
            //    else { Console.WriteLine("estoy entrer 8 y 9"); }
            //Console.WriteLine(i);
            //i++;
            //}
            List<int> myIntList;
            myIntList = new List<int>() { 1, 2, 5, -10 };

            //for (int j = 0; j < myIntList.Count; j++)
            //{
            //    Console.WriteLine(myIntList[j]);
            //}

            int caseSwitch = 1;
            //switch es en vez de un if
            switch(caseSwitch){
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
            }
        }
    }
}
