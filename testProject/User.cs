using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    internal class User
    {

        public int id { get; set; }
        private string username;


        public string Username
        {
            get { return username; }
            set { username = value; }

        }

        public User() { }

        public User(string username)
        {
            this.username = username;

        }

    }
}
