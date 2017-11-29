using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Box
    {
        private string _name;
        private List<string> _categoryList;
        private double _price;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public List<string> CategoryList
        {
            get => _categoryList;
            set => _categoryList = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public Box(string name, List<string> categoryList, double price)
        {
            AddItemToCategory();
            _name = name;
            _categoryList = categoryList;
            _price = price;
            
        }

        public Box()
        {
            
        }

        public void AddItemToCategory()
        {
            _categoryList.Add("Beauty");
            _categoryList.Add("Health");
            _categoryList.Add("Games");
            _categoryList.Add("Eras");
        }
    }
}
