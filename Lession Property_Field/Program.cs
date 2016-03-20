using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_Property_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Field1 = 1; //Is is wrong ,because Field1 is private 
            myClass.Field2 = 2;
            myClass.Property3 = 3;
            myClass.Property4 = 4;
        }
    }

    class MyClass
    {
        private int Field1;
        public int Field2;

        public int Property3 { get; set; }


        private int _Property4;

        public int Property4
        {
            get { return _Property4; }
            set { _Property4 = value; }
        }
    }
}
