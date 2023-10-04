using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Pa
    {
        public string name;
       public Pa(string name) {
            this.name = name;
            Console.WriteLine(name);
        }
    }
    class Ch : Pa
    {
        public string lastName;
       public Ch(string lastName) : base("Kanika")
        {
            Console.WriteLine(lastName);
        }
    }
    internal class ConstructorInheritance
    {
        public static void Main(string[]args) {
            Ch c = new Ch("Sabharwal");
            Console.ReadLine();
        }
    }
}
