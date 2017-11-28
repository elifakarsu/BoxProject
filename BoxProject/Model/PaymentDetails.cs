using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProject.Model
{
    class PaymentDetails
    {
        private string _cardNumber;
        private string _cardName;
        private string _expiryDate;
        private string _securityNumber;

        public string CardNumber
        {
            get => _cardNumber;
            set => _cardNumber = value;
        }

        public string CardName
        {
            get => _cardName;
            set => _cardName = value;
        }

        public string ExpiryDate
        {
            get => _expiryDate;
            set => _expiryDate = value;
        }

        public string SecurityNumber
        {
            get => _securityNumber;
            set => _securityNumber = value;
        }

        public PaymentDetails(string cardNumber, string cardName,string expiryDate, string securityNumber)
        {
            _cardNumber = cardNumber;
            _cardName = cardName;
            _expiryDate = expiryDate;
            _securityNumber = securityNumber;
            
        }

        public PaymentDetails()
        {
            
        }

    }
}
