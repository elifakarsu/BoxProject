using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    public class Category
    {
        private string _name;

        public string Name
        {
            get => _name; set => _name = value;
        }

        public Category(string name)
        {
            _name = name;
        }

        public Category()
        {
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
