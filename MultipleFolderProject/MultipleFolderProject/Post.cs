using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFolderProject
{
    internal class Post
    {
        string title = "";
        string text = "";
        string author = "";
        public Post(string title, string text, string author) 
        {
            this.title = title;
            this.text = text;
            this.author = author;
        }
        public void settitle(string title)
        {
            this.title = title;
        }
        public string getTitle()
        {
            return this.title;
        }
        public void settext(string text) 
        {
            this.text = text;
        }
        public string getText()
        {
            return this.text;
        }
        public void setauthor(string author)
        {
            this.author = author;
        }
        public string getauthor() 
        {
            return this.author;
        }
    }
    
}
