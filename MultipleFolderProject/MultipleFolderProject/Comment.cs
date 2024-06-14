using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFolderProject
{
    internal class Comment
    {
        List<string> comments;
        private string name = "";
        private string text = "";
        private short rating = 0;
        public Comment(string text, short rating, string name)
        {
            this.text = text;
            this.rating = rating;
            this.name = name;
        }
        public void settext(string text) 
        {
            this.text = text;
        }
        public string gettext() 
        {
            return this.text;
        }
        public void setrating(short rating) 
        {
            this.rating = rating;
        }
        public int getrating() 
        {
            return this.rating;
        }
    }
}
