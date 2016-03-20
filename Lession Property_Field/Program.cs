using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_Property_Field
{
    class Program
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


        static void Main(string[] args)
        {
        }
    }
}
