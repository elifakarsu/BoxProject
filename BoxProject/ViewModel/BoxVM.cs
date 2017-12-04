using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxProject.Model;

namespace BoxProject.ViewModel
{
    class BoxVM
    {
        public ItemCatalog _myItems { get; set; }
        private Serialization _Serialize;
        private Box _myBox;
        private ObservableCollection<Category> _categories;
        private ObservableCollection<Item> _myItemCollection;
        private Category _selectedCategory;


        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set => _categories = value;
        }

        public Category SelectedCategory
        {
            get => _selectedCategory;
            set =>  _selectedCategory = value;
        }

        public ObservableCollection<Item> MyItemCollection
        {
            get => _myItemCollection;
            set => _myItemCollection = value;
        }

        public BoxVM()
        {
            _myItems = new ItemCatalog();

            _Serialize = new Serialization();

            _myBox = new Box();

            SelectedCategory = new Category();

            Categories = new ObservableCollection<Category>()
            {
                new Category("Make up"),
                new Category("Health"),
                new Category("Era"),
                new Category("Game")

            };

            ReadMyItems();


        }

        public void CreateBoxes()
        {
            

            if (SelectedCategory.Name == "Make up")
            {
                foreach (var item in MyItemCollection)
                {
                    

                }
                
            }
            else if (SelectedCategory.Name == "Health")
            {

            }
            else if (SelectedCategory.Name == "Era")
            {

            }
            else if (SelectedCategory.Name == "Game")
            {

            }
            
        }

        public async void ReadMyItems()
        {
            MyItemCollection  = await _Serialize.LoadFromJson();
            _myItems.MyItems = MyItemCollection;
        }
        


    }
}
