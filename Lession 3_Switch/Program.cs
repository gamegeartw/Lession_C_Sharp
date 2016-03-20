using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_3_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else 雖然很好用，但如果判斷的項目一多，就會顯的很雜亂
            //switch 是if else 的擴充版

            int switchCase = 1;

            switch (switchCase)
            {
                case 1:
                    Console.WriteLine("我是選項1");
                    break;
                case 2:
                    Console.WriteLine("我是選項2");
                    break;
                case 3:
                    Console.WriteLine("我是選項3");
                    break;
                case 4:
                    Console.WriteLine("我是選項4");
                    break;
                default:
                    Console.WriteLine("我是預設的選項");

                    break;
            }
            Console.ReadLine();

        }
    }
}
