using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BoxProject.Model;

namespace BoxProject.ViewModel
{
    class PaymentVM:INotifyPropertyChanged
    {
        
        private PaymentDetails _paymentDetails;
        private string _cardNumber = "Insert Card Number";
        private string _cardName = "Insert Card Name";

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public string CardName
        {
            get { return _cardName; }
            set { _cardName = value; }
        }
        public PaymentVM()
        {
         _paymentDetails = new PaymentDetails(CardNumber, CardName,"", "");   
            _paymentDetails.PaymentDetailCard();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [Annotations.NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
