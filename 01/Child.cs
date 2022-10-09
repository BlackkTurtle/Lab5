using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age) {
            this.Age = age;
        }
        private int age;
        public new virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}