using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    internal class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public Article()
        {
            this.Title = "n/a";
            this.Content = "n/a";
            this.Author = "n/a";
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChnageAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public void Print()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}
