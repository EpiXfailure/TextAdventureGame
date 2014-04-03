using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Named_object
    {
        private string name;
        private string description;
        public Named_object(string i_name, string i_desc)
        {
            name = i_name;
            description = i_desc;
        }
        public string getname()
        {
            return name;
        }
        public string getdesc()
        {
            return description;
        }
    }
}
