using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexWPF
{
    public class Pokemon
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _type;
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }        

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
