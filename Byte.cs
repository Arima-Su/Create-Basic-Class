using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Basic_Class
{
    public class Byte
    {
        string name;
        string type;

        public Byte() 
        {
            name = "";
            type = "";
        }

        public Byte(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return name + " - " + type;
        }
    }
}
