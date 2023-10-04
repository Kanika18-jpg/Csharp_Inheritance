using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
        public class Base
        {
            public string name;
            public int salary;
            public int age;

            public void info(string name, int salary, int age) { 
            this.name = name;
            this.salary = salary;
            this.age = age;
            Console.WriteLine(name);
            Console.WriteLine(salary);
            Console.WriteLine(age);
            Console.ReadLine();
        }
        }
        class Derived : Base
        {
            public Derived()
            {
                Console.WriteLine("Hello Derived Class Here!");
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.info("A", 1000, 22);
        }
    }
}
