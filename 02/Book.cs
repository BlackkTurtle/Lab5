using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Book
    {
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        private string author;
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                string[] strarray=value.Split(' ');
                int a=10;
                try
                {
                    a=Convert.ToInt32(strarray[1].Substring(0,1));
                }
                catch (Exception)
                {
                    this.author = value;     
                }
                if (a != 10)
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
        }
        public string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        public decimal price;
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }
    }
}
