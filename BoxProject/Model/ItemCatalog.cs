using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class ItemCatalog
    {
        private string _itemID;
        private Item _item;
        private string _brand;
        private bool _expensive;
        

        public string ItemID
        {
            get => _itemID;
            set => _itemID = value;
        }

        public Item Item
        {
            get => _item;
            set => _item = value; 
        }


        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        public bool Expensive
        {
            get => _expensive;
            set => _expensive = value;
        }

        public bool Average
        {
            get => _average;
            set => _average = value;
        }

        public bool Affordable
        {
            get => _affordable;
            set => _affordable = value;
        }
        
    }
}
