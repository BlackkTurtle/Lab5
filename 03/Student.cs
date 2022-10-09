using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Student : Human
    {
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"First Name: {this.Name}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty Number: {this.FacultyNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
        public Student(string[] arraystr) : base(arraystr)
        {
            FacultyNumber=arraystr[2];
        }
        private string facultynumber;
        public string FacultyNumber
        {
            get
            {
                return this.facultynumber;
            }
            set
            {
                if (value.Length>10||value.Length<5)
                {
                     throw new ArgumentException("Invalid faculty number!");
                }
                else
                {
                    this.facultynumber = value;
                }
            }
        }
    }
}
