using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    public class Item
    {

        private string _itemID;
        private string _category;
        private string _name;
        private string _brand;
        private bool _expensive;
        private bool _average;
        private bool _affordable;


        public string ItemID
        {
            get => _itemID;
            set => _itemID = value;
        }


        public string Category
        {
            get => _category;
            set => _category = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
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

        public Item(string itemId, string category, string name, string brand, bool expensive, bool average, bool affordable)
        {
            ItemID = itemId;
            Category = category;
            Name = name;
            Brand = brand;
            Expensive = expensive;
            Average = average;
            Affordable = affordable;

        }


        public Item()
        {

        }
    }
}
