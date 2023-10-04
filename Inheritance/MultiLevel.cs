using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent Class");
            Console.ReadLine();
        }
    }
    public class Child1 : Parent { 
        public void show1()
        {
            Console.WriteLine("Child1");
            Console.ReadLine();
        }
    }
    public class Child2 : Child1 {
       public void show2()
        {
            Console.WriteLine("Child2");
            Console.ReadLine();
        }
    }
    internal class MultiLevel
    {
        public static void Main(string[] args) {
        
            Child1 c1 = new Child1();
            c1.show();
            Child2 c2 = new Child2();
            c2.show1();
            c2.show2();
            c2.show();
        }
    }
}
