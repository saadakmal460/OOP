using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Muser
    {
        private string name;
        private string password;
        private string id;

        public Muser(string name, string password, string id)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Id { get => id; set => id = value; }
    }
}
