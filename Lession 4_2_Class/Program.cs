using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4_2_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass();
            myNameSpace.MyClass class2=new myNameSpace.MyClass();
        }
    }

    class MyClass
    {
        public MyClass()        //Init Class,a special method ,if you don't do this,complier will do default
        {

        }
        
        ~MyClass()  //Dispose class,but it is not necessary
        {
           
        }
    }
}
namespace myNameSpace
{
    class MyClass {

    }
}