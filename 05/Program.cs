using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string foodstr = Console.ReadLine();
                string[] arrayfood = foodstr.Split(' ');
                MoodFactory moodFactory = new MoodFactory(arrayfood,foodstr.Length);
                Console.WriteLine(moodFactory.Moodcountget);
                Console.WriteLine(moodFactory.Moodget);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadLine();
        }
    }
}
