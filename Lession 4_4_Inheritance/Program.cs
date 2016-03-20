using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_4_4_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();    
            cat.Name = "cat";
            cat.Years = 1;
            Console.WriteLine(cat.Shut);


            Dog dog = new Dog();
            Console.WriteLine(dog.Shut);
            Console.ReadLine();

        }
    }

    public class Animals    //Father Class
    {
        public int Years { get; set; }
        public string Name { get; set; }

    }

    public class Cat:Animals    //son Class
    {
        public string Shut { get; set; }

        public Cat()
        {
            Shut = "meow";
        }
    }

    public class Dog : Animals  //son Class
    {
        public string Shut { get; set; }
        public Dog()
        {
            this.Name = "dog";  
            this.Years = 2;
            Shut = "Wow";
        }
    }

}
