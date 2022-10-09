using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class FactoryBase
    {
        public FactoryBase(string[] arraystr,int strlength)
        {
            StrLength = strlength;
        }
        private int StrLength
        {
            set
            {
                if (value <= 1000)
                {
                    return;
                }
                else
                {
                    throw new ArgumentException("The characters in the input string will be no more than: 1000.");
                }
            }
        }
    }
}
