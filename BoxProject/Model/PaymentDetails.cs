using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.DateTimeFormatting;
using Windows.UI.Popups;
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



        public PaymentDetails(string cardNumber, string cardName, string expiryDate, string securityNumber)
        {
            CardNumber = cardNumber;
            CardName = cardName;
            ExpiryDate = expiryDate;
            SecurityNumber = securityNumber;

        }


        public async void PaymentDetailCard()
        {
          
                if (CardNumber == "300" || CardNumber == "301" || CardNumber == "302" || CardNumber == "303" || CardNumber == "304" || CardNumber == "305")
                {
                   ShowDialogBox("Diners Club - Carte Blanche");
                }
                else if (CardNumber == "34" || CardNumber == "37")
                {
                    ShowDialogBox("American Express");
                }
                else if (CardNumber == "36")
                {
                    ShowDialogBox("Diners Club - International");
                }
                else if (CardNumber == "54")
                {
                    ShowDialogBox("Diners Club - USA & Canada");
                }
                else if (CardNumber == "6011" || CardNumber == "  " || CardNumber == "644" || CardNumber == "645" || CardNumber == "646" || CardNumber == "647" || CardNumber == "648" || CardNumber == "649" || CardNumber == "65")
                {
                    ShowDialogBox("Discover");
                }
                else if (CardNumber == "637" || CardNumber == "638" || CardNumber == "639")
                {
                    ShowDialogBox("InstaPayment");
                }
                else if ()
                {
                    ShowDialogBox("JCB");
                }
            



            //if ((SecurityNumber.Length > 3 && SecurityNumber.Length < 4) && (CardNumber.Length == 13 || CardNumber.Length < 14 && CardNumber.Length > 17 || CardNumber.Length == 19))
            // {
            //     MsgBox("Payment Accepted");
            // }


            
            int currentmonth = DateTime.Now.Month;
            int currentyear = DateTime.Now.Year;
            if (currentmonth > ExpiryMonth && ExpiryYear > currentyear)
            {
                MsgBox("Sorry. Card is invalid");
            }
        }

    }

