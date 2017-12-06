using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxProject.Model;

namespace BoxProject.ViewModel
{
    class MainPageVm
    {
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
            set => _selectedCategory = value;
        }

        public MainPageVm()
        {
            SelectedCategory = new Category();

            Categories = new ObservableCollection<Category>()
            {
                new Category("Make up"),
                new Category("Health"),
                new Category("Era"),
                new Category("Game")

            };
        }

    }
}
