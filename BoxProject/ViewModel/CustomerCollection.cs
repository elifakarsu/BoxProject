using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxProject.Model;

namespace BoxProject.ViewModel
{
    class CustomerCollection : NotifyChangePropertyClass
    {
        private readonly FrameNavigate _frameNavigate;
        // source property : for selected item
        private Customer _selectedItem;
        private readonly Singleton _userSingleton;

        public ObservableCollection<Customer> Student { get; set; }

        public Customer AddNewCustomer { get; set; }

        public CustomerCollection()
        {
            AddNewCustomer = new Customer();

            // Frame Navigate Object instance
            _frameNavigate = new FrameNavigate();

            // User singelton 
            _userSingleton = Singleton.GetInstance();
        }
    }
}
