using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Human
    {
        public Human(string[] arraystr)
        {
            Name = arraystr[0];
            LastName = arraystr[1];
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (Char.IsUpper(value,0)&&value.Length>3)
                {
                    this.name = value;
                }else if(value.Length>3){
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
            }
        }
        public string lastname;
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (char.IsUpper(value, 0) && value.Length > 2)
                {
                    this.lastname = value;
                }
                else if (value.Length > 2)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
            }
        }
    }
}
