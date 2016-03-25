using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession_4_Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            People allen = new People();
            People bob = new People();
            allen.Name = "王小明";
            allen.Birthday = new DateTime(1980, 3, 3);
            allen.LoveTaiwan = true;
            bob.Name = "李大同";
            bob.Birthday = new DateTime(1990, 1, 1);
            bob.LoveTaiwan = false;

            Console.WriteLine(allen.Age());
            Console.WriteLine(bob.Age());
            allen.sayLove();
            bob.sayLove();
            Console.ReadLine();

        }
    }

    class People
    {
        public string Name;

        public DateTime Birthday;

        public bool LoveTaiwan;

        public int Age()
        {
            int yearNow = DateTime.Now.Year;
            int RealAge = yearNow - Birthday.Year;
            return RealAge;
        }

        public void sayLove()
        {
            if (LoveTaiwan)
            {
                Console.WriteLine("我愛台灣");
            }else
            {
                Console.WriteLine("喔!你不愛台灣");
            }
        }
    }
}
