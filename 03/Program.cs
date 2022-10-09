using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string studentstr = Console.ReadLine();
                string[] arraystudent=studentstr.Split(' ');
                string workerstr = Console.ReadLine();
                string[] arrayworker=workerstr.Split(' ');
                Student student = new Student(arraystudent);
                Worker worker = new Worker(arrayworker);
                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadLine();
        }
    }
}
