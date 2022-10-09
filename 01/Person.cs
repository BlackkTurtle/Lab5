using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Person
    {
        private int age;
        private string name;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                else { name = value; }
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
            this.Name,
           this.Age));
            return stringBuilder.ToString();
        }


    }
}
