using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadLine();
        }
    }
}
