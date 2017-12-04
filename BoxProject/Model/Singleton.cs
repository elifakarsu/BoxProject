using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class Singleton
    {
        public static Customer _customer;

        // step 1 : declare the object instance of class Singleton

        private static Singleton Instance { get; set; }

        private Singleton()
        {
            _customer = new Customer();
        }

        // step 2:  this instance property check first if instance is not null ,
        // if its null then create an object instance otherwise return current instance 

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public string GetName()
        {
            return _customer.Name;
        }
        public string GetCountry()
        {
            return _customer.Country;
        }
        public string GetCity()
        {
            return _customer.City;
        }
        public string GetAddress()
        {
            return _customer.Address;
        }
        public string GetPhoneNumber()
        {
            return _customer.PhoneNumber;
        }
        public string GetEMail()
        {
            return _customer.EMail;
        }
        //public string GetPaymentDetails()
        //{
        //    return _customer.PaymentDetails;
        //}
    }








}
