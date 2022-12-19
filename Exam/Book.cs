using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Book
    {
        public string Author { get; set; }
        public string Name { get; set;  }

        public Book(string _author, string _name)
        {
            Author = _author;
            Name = _name;
        }
    }
}
