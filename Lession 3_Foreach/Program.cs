using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_3_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach是for迴圈的進階版，可以將陣列或集合裡的每一個值取出

            string[] names = new string[] {"andy","bob","carol","daniel" };

            foreach (string name in names)  //name是一個我們在迴圈裡用的變數,型別是集合(names)裡的元素
            {
                Console.WriteLine("我的名字是"+name);
            }
            Console.ReadLine();
        }
    }
}
