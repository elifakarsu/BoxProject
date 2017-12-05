using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Order
    {
        private ObservableCollection<Box> _boxes;
        private Customer _customer;
        private PaymentDetails _paymentDetails;

        public PaymentDetails PaymentDetails { get => _paymentDetails; set => _paymentDetails = value; }
        public ObservableCollection<Box> Boxes { get => _boxes; set => _boxes = value; }
        public  Customer Customer { get => _customer; set => _customer = value; }

        public Order()
        {
            
        }

        public Order(ObservableCollection<Box> boxes, Customer customer, PaymentDetails paymentdetails)
        {
            _boxes = boxes;
            _customer = customer;
            _paymentDetails = paymentdetails;
        }

        }
    }
}
