using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class SingletonOrder
    {
        private static Order _order;

        private static SingletonOrder Instance { get; set; }

        private SingletonOrder()
        {
            _order = new Order();
        }

        public static SingletonOrder GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonOrder();              
            }
            return Instance;
        }

        public void SetBox(ObservableCollection<Box> boxes)
        {
            _order.Boxes = boxes;
        }

        public void SetCustomer(Customer customer)
        {
            _order.Customer  = customer ;
        }

        public void SetPaymentDetails(PaymentDetails  paymentDetails )
        {
            _order.PaymentDetails  = paymentDetails ;
        }



    }
}
