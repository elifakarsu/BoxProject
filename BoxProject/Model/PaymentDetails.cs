using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.DateTimeFormatting;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace BoxProject.Model
{
    class PaymentDetails
    {
        private string _cardNumber;
        private string _cardName;
        private string _expiryDate;
        private int _expirymonth;
        private int _expiryyear;
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

        public int ExpiryMonth
        {
            get => _expirymonth;
            set => _expirymonth = value;
        }

        public int ExpiryYear
        {
            get => _expiryyear;
            set => _expiryyear = value;
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

        public bool Startswith(string tocheck)
        {
            var numbers = new []{"300", "301", "302", "303", "304", "305"};
            return !string.IsNullOrEmpty(tocheck) && numbers.Any(number => tocheck.StartsWith(number));
        }

        public PaymentDetails()
        {
            if (CardNumber.StartsWith ("300" , "301" , "302" , "303" , "304" , "305"))
            {
                MsgBox("Your payment will be done with Diners Club - Carte Blanche");
            }

            if ((SecurityNumber.Length > 3 && SecurityNumber.Length < 4) && (CardNumber.Length == 13 || CardNumber.Length < 14 && CardNumber.Length > 17 || CardNumber.Length == 19))
            {
                MsgBox("Payment Accepted");
            }


            
            int currentmonth = DateTime.Now.Month;
            int currentyear = DateTime.Now.Year;
            if (currentmonth > ExpiryMonth && ExpiryYear > currentyear)
            {
                MsgBox("Sorry. Card is invalid");
            }
        }

    }
}
