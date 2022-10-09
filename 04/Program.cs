using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0,n=int.Parse(Console.ReadLine());
            int[] songtotallength=new int[3] {0,0,0};
            for (int i=0; i<n; i++)
            {
                try
                {
                    string songstr = Console.ReadLine();
                    string[] arraysong = songstr.Split(';');
                    SongLength song = new SongLength(arraysong);
                    int[] songlength = song.Songlength;
                    for (int j=0; j<songlength.Length; j++)
                    {
                        songtotallength[j+1]+=songlength[j];
                    }
                    Console.WriteLine("Song added.");
                    a++;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine("Songs added : "+a);
            SongLength.PrintLength(ref songtotallength);
            Console.ReadLine();
        }
    }
    /*
3
ABBA;Mamma Mia;3:35
Nasko Mentata;Shopskata salata;4:123
Nasko Mentata;Shopskata salata;4:12
    */
}
