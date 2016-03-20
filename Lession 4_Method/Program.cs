using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();

            Program p = new Program();
            p.Method2();       
            p.Method3();
            Console.WriteLine(Method4());
            Console.WriteLine(Method5("Method5"));
            Console.ReadLine();
        }

        static void Method1()
        {
            Console.WriteLine("I am Method 1");
        }

        private void Method2()
        {
            Console.WriteLine("I am Method 2");

        }

        public void Method3() {
            Console.WriteLine("I am Method 3");

        }

        static string Method4()
        {
            return "I am Method 4";
        }

        static string Method5(string msg)
        {
            return msg+",I am additional msg";
        }
    }


}
