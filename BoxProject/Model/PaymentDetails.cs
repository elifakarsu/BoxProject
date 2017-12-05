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
   public class PaymentDetails
    {
        public string CardNumber { get; set; }

        public string CardName { get; set; }

        public string ExpiryDate { get; set; }

        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        public string SecurityNumber { get; set; }

        public PaymentDetails(string cardNumber, string cardName,string expiryDate, string securityNumber)
        {
            CardNumber = cardNumber;
            CardName = cardName;
            ExpiryDate = expiryDate;
            SecurityNumber = securityNumber;
            
        }

        public bool Startswith(string tocheck)
        {
            var numbers = new []{"300", "301", "302", "303", "304", "305"};

            string num = String.Join('', numbers);
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
