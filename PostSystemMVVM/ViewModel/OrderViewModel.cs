using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PostSystemMVVM.Model;

namespace PostSystemMVVM.ViewModel
{
    public class OrderViewModel : BaseViewModel
    {
        private string _trackNumber;
        private string _sender;
        private string _receiver;
        private string _receiverAdress;
        private double _price;
        private PaymentStatus _paymentStatus;
        private OrderStatus _orderStatus;

        public string TrackNumber
        {
            get => _trackNumber;
            set { _trackNumber = value; OnPropertyChanged(nameof(TrackNumber)); }
        }

        public string Sender
        {
            get => _sender;
            set { _sender = value; OnPropertyChanged(nameof(Sender)); }
        }

        public string Receiver
        {
            get => _receiver;
            set { _receiver = value; OnPropertyChanged(nameof(Receiver)); }
        }

        public string ReceiverAdress
        {
            get => _receiverAdress;
            set { _receiverAdress = value; OnPropertyChanged(nameof(ReceiverAdress)); }
        }

        public double Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(nameof(Price)); }
        }

        public PaymentStatus PaymentStatus
        {
            get => _paymentStatus;
            set { _paymentStatus = value; OnPropertyChanged(nameof(PaymentStatus)); }
        }

        public OrderStatus OrderStatus
        {
            get => _orderStatus;
            set { _orderStatus = value; OnPropertyChanged(nameof(OrderStatus)); }
        }
    }
}
