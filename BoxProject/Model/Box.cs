using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Box
    {
        private string _image;
        private string _name;
        private string _description;
        private double _price;
        private ObservableCollection<Item> _itemsInMyBox;

        public string Image
        {
            get => _image;
            set => _image = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public ObservableCollection<Item> ItemsInMyBox
        {
            get => _itemsInMyBox;
            set => _itemsInMyBox = value;
        }

        public Box(string image, string name, string description, double price)
        {
            _image = image;
            _name = name;
            _description = description;
            _price = price;
            
        }

        public Box()
        {

        }

       
    }
}
