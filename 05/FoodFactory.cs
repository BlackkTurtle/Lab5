using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class FoodFactory:FactoryBase
    {
        private class Food{
            public string Name;
            public int count;
        }
        public FoodFactory(string[]strarray,int strlength) : base(strarray, strlength)
        {
            FoodLength = strarray;
            Moodcountget = MoodCountGet(strarray);
        }
        public int Moodcountget { get; }
        private int MoodCountGet(string[]strarray)
        {
            var foods = new List<Food>()
            {
                new Food() { Name = "Cram",count = 2},
                new Food() { Name="Lembas",count=3},
                new Food() { Name="Apple",count = 1},
                new Food(){Name="Melon",count=1},
                new Food(){Name="HoneyCake",count=5},
                new Food(){Name="Mushrooms",count=-10}
            };
            int result=0;
            for (int i = 0; i < strarray.Length; i++)
            {
                int a = 0;
                for (int j=0; j < foods.Count; j++)
                {
                    if (foods[j].Name == strarray[i])
                    {
                        result += foods[j].count;
                        a++;
                        break;
                    }
                }
                if (a == 0)
                {
                    result += -1;
                }
            }
            return result;
        }
        private string[] FoodLength
        {
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException(" The food count would be in the range [1…100].");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
