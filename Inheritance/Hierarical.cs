using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Father {
        public string Rakesh { get; private set; }

        public string name()
        {
            return "Rakesh Kumar.";
        }
    }
    class Son : Father
    {
        public string name1()
        {
            return "Vanshu";
        }
    }
    class Daughter: Father
    {
        public string name2()
        {
            return "Kannu";
        }
    }

    internal class Hierarical
    {
        public static void Main(string[] args)
        {
            Son s = new Son();
            Console.WriteLine("I'am " + s.name1() + " son of " + s.name());
            Daughter d = new Daughter();
            Console.WriteLine("I'am " + d.name2()+ " daughter of "+ d.name());
            Console.ReadLine();
        }
    }
}
