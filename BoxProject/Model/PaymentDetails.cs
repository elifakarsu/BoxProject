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

       

        public PaymentDetails(string cardNumber, string cardName,string expiryDate, string securityNumber)
        {
            CardNumber = cardNumber;
            CardName = cardName;
            ExpiryDate = expiryDate;
            SecurityNumber = securityNumber;
            
        }
        

        public async void PaymentDetailCard()
        {
          
                if (CardNumber.StartsWith("300") || CardNumber.StartsWith("301") || CardNumber.StartsWith("302") || CardNumber.StartsWith("303") || CardNumber.StartsWith("304") || CardNumber.StartsWith("305"))
                {
                   ShowDialogBox("Diners Club - Carte Blanche");
                }
                else if (CardNumber.StartsWith("34") || CardNumber.StartsWith("37"))
                {
                    ShowDialogBox("American Express");
                }
                else if (CardNumber.StartsWith("36"))
                {
                    ShowDialogBox("Diners Club - International");
                }
                else if (CardNumber.StartsWith("54"))
                {
                    ShowDialogBox("Diners Club - USA & Canada");
                }
                else if (CardNumber.StartsWith("6011") || CardNumber.StartsWith("644") || CardNumber.StartsWith("645") || CardNumber.StartsWith("646") || CardNumber.StartsWith("647") || CardNumber.StartsWith("648") || CardNumber.StartsWith("649") || CardNumber.StartsWith("65"))
                {
                    ShowDialogBox("Discover");
                }
                else if (CardNumber.StartsWith("637") || CardNumber.StartsWith("638") || CardNumber.StartsWith("639"))
                {
                    ShowDialogBox("InstaPayment");
                }
                else if (CardNumber.StartsWith())
                {
                    ShowDialogBox("JCB");
                }
                else if (CardNumber.StartsWith("5018") || CardNumber.StartsWith("5020") || CardNumber.StartsWith("5038") || CardNumber.StartsWith("5893") || CardNumber.StartsWith("6304") || CardNumber.StartsWith("6759") || CardNumber.StartsWith("6761") || CardNumber.StartsWith("6762") || CardNumber.StartsWith("6763"))
                {
                    ShowDialogBox("Maestro");
                }
                else if (CardNumber.StartsWith("51") || CardNumber.StartsWith("52") || CardNumber.StartsWith("53") || CardNumber.StartsWith("54")  || CardNumber.StartsWith("55")) // || (272099 <= Convert.ToInt32(CardNumber)  && Convert.ToInt32(CardNumber) <= 222100))
                {
                    ShowDialogBox("MasterCard");
                }
                else if (CardNumber.StartsWith("4") && !CardNumber.StartsWith("4026") && CardNumber != "417500" && CardNumber != "4508" && CardNumber != "4844" && CardNumber != "4913" && CardNumber != "4917")
                {
                    ShowDialogBox("Visa");
                }
                else if (CardNumber.StartsWith("4026") || CardNumber.StartsWith("417500") || CardNumber.StartsWith("4508") || CardNumber.StartsWith("4844") || CardNumber.StartsWith("4913") || CardNumber.StartsWith("4917"))
                {
                    ShowDialogBox("Visa Electron");
                }
            

                
           
           //if ((SecurityNumber.Length > 3 && SecurityNumber.Length < 4) && (CardNumber.Length == 13 || CardNumber.Length < 14 && CardNumber.Length > 17 || CardNumber.Length == 19))
           // {
           //     MsgBox("Payment Accepted");
           // }


            
            int currentmonth = DateTime.Now.Month;
            int currentyear = DateTime.Now.Year;
            if (currentmonth > ExpiryMonth && ExpiryYear > currentyear)
            {
                ShowDialogBox ("Sorry. Card is invalid");
            }
        }

        public static  async  void ShowDialogBox(string message)
        {
            var msg = new MessageDialog(message);
            await msg.ShowAsync();
        }

    }
}
