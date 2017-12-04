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

        private Box _myBox;
        private ObservableCollection<Category> _categories;
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

        public BoxVM()
        {
            _myBox = new Box();

            SelectedCategory = new Category();

            Categories = new ObservableCollection<Category>()
            {
                new Category("Make up"),
                new Category("Health"),
                new Category("Era"),
                new Category("Game")

            };
        }

        public void CreateBoxes()
        {
            

            if (SelectedCategory.Name == "Make up")
            {
                
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



    }
}
