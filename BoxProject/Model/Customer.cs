using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Customer
    {
        private string _name;
        private string _country;
        private string _city;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private PaymentDetails _paymentDetails;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public PaymentDetails PaymentDetails
        {
            get => _paymentDetails;
            set => _paymentDetails = value;
        }
        

        public Customer(string name,string country, string city, string address,string phoneNumber, string email, PaymentDetails paymentDetails)
        {
            _name = name;
            _country = country;
            _city = city;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;
            _paymentDetails = paymentDetails;
        }


    }
}
