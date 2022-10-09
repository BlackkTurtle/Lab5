using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Worker:Human
    {
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"First Name: {this.Name}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours Per Day: {this.HoursPerDay:f2}")
            .AppendLine($"Salary Per Hour: {this.SalaryPerHour:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
        public Worker(string[] arraystr) : base(arraystr)
        {
            WeekSalary = Convert.ToDouble(arraystr[2]);
            HoursPerDay = Convert.ToDouble(arraystr[3]);
            SalaryPerHour = CreateSalaryPerHour(arraystr[2], arraystr[3]);
        }
        private double SalaryPerHour;
        private double CreateSalaryPerHour(string str1,string str2)
        {
            double a=Convert.ToDouble(str1);
            double b=Convert.ToDouble(str2);
            return a / (b * 5);
        }
        private double weeksalary;
        public double WeekSalary { 
            get
            {
                return this.weeksalary;
            }
            set
            {
                if (value > 10)
                {
                    this.weeksalary = value;
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
            }
        }
        private double hoursperday;
        public double HoursPerDay
        {
            get
            {
                return this.hoursperday;
            }
            set
            {
                if (value > 12||value<1)
                {
                     throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                else
                {
                    this.hoursperday = value;
                }
            }
        }
    }
}
