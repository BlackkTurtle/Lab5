using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class MoodFactory:FoodFactory
    {
        public MoodFactory(string[]strarray,int strlength) : base(strarray, strlength)
        {
            Moodget = MoodGet(Moodcountget);
        }
        public string Moodget { get; }
        private string MoodGet(int moodcount)
        {
            if (moodcount < -5)
            {
                return "Angry";
            }else if (moodcount >= -5 && moodcount <= 0)
            {
                return "Sad";
            }else if (moodcount>=1&&moodcount <= 15)
            {
                return "Happy";
            }
            else
            {
                return "JavaScript";
            }
        }
    }
}
