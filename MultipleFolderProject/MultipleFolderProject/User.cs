using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultipleFolderProject
{
    public class User
    {
        private string name = "";
        private string email = "";
        private string password = "";
        public User(string name, string email, string password) 
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setemail(string email)
        {
            this.email = email;
        }
        public string geteamil()
        {
            return this.email;
        }
        public void setpassword(string password) 
        {
            this.password = password;
        }
        public string getpassword()
        {
            return this.password;
        }
        
    }
}
