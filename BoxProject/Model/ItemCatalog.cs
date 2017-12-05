using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
   public class ItemCatalog
    {
        //private Item _item;
        private ObservableCollection<Item> _myItems;

        //public Item Item
        //{
        //    get => _item;
        //    set => _item = value;
        //}

        public ObservableCollection<Item> MyItems
        {
            get => _myItems;
            set => _myItems = value;
        }

        public ItemCatalog()
        {

        }

        public ItemCatalog(ObservableCollection<Item> items)
        {
            _myItems = items;
        }
    }
}
