using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Item
    {
        
        private string _name;
       

        public string ItemId
        {
            get => _itemId;
            set => _itemId = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        

        public Item(string itemId, string name, string brand, bool expensive,bool average, bool affordable)
        {
            
            _name = name;
            _brand = brand;
            _expensive = expensive;
            _average = average;
            _affordable = affordable;
            
        }

        public Item()
        {
            
        }
    }
}
