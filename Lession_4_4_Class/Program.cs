using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession_4_4_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveTime time = new SaveTime();
            time.today = DateTime.Now;
            Console.WriteLine("被儲存起來的時間:"+ time.today);
            People Kevin = new People();
            People Wilber = new People();
            Kevin.Job = "老板";
            Kevin.Car = "BMW";

            Wilber.Job = "攻城獅";
            Wilber.Car = "March";

            Console.WriteLine("Kevin的職業是" + Kevin.Job + ",開的車是" + Kevin.Car);
            Console.WriteLine("Wilber的職業是" + Wilber.Job + ",開的車是" + Wilber.Car);
            Console.WriteLine("剛剛被儲起來的時間是" +time.today);
            Console.WriteLine("現在的時間是" + DateTime.Now);

        }
    }

    public class SaveTime
    {
        public DateTime today;
    }

    public class People
    {
        public string Job;
        public string Car;
    }
}
