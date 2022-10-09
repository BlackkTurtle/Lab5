using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class SongLength:SongName
    {
        public SongLength(string[] arraystr) : base(arraystr)
        {
            Songlength = SplitString(arraystr[2]);
        }
        private int[] SplitString(string str)
        {
            string[] split = str.Split(':');
            int[] result = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                result[i] = Convert.ToInt32(split[i]);
            }
            return result;
        }
        private int[] songlength;
        public int[] Songlength
        {
            get { 
                return songlength; }
            set {
                if (value.Length == 2)
                {
                    if(value[0]>= 0 && value[0] < 15)
                    {
                        if (value[1] >= 0 && value[1] < 60)
                        {
                            songlength = value;
                        }
                        else
                        {
                            throw new ArgumentException("Song seconds should be between 0 and 59.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Song minutes should be between 0 and 14.");
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid song length.");
                }
            }
        }
        public static void PrintLength(ref int[] array)
        {
            while (true)
            {
                if (array[2] > 59)
                {
                    array[1]++;
                    array[2] = array[2]-60;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                if (array[1] > 59)
                {
                    array[0]++;
                    array[1] = array[1] - 60;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Playlist Length: {0}h {1}m {2}s", array[0], array[1], array[2]);
        }
    }
}
