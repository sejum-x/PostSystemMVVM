using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    public class Order : BaseViewModel
    {
        private int _id;
        private string _senderPhone;
        private string _receiverPhone;
        private double _packageWeight;
        private string _senderBranch;
        private string _receiverBranch;
        private string _worker;
        private double _price;
        private DateTime _orderDate;
        private PaymentType _paymentType;
        private PaymentStatus _paymentStatus;
        private OrderStatus _orderStatus;

        public Order()
        {
            this._id = 0;
            this._senderPhone = "";
            this._receiverPhone = "";
            this._packageWeight = 0;
            this._senderBranch = "";
            this._receiverBranch = "";
            this._worker = "";
            this._price = 0;
            this._orderDate = DateTime.Now;
            this._paymentType = PaymentType.Cash;
            this._paymentStatus = PaymentStatus.Pending;
            this._orderStatus = OrderStatus.Pending;
        }

        public Order(int id, string sender, string receiver, double packageWeight, string senderBranch, string receiverBranch, string worker, double price, DateTime orderDate, PaymentType paymentType, PaymentStatus paymentStatus, OrderStatus orderStatus)
        {
            this._id = id;
            this._senderPhone = sender;
            this._receiverPhone = receiver;
            this._packageWeight = packageWeight;
            this._senderBranch = senderBranch;
            this._receiverBranch = receiverBranch;
            this._worker = worker;
            this._price = price;
            this._orderDate = orderDate;
            this._paymentType = paymentType;
            this._paymentStatus = paymentStatus;
            this._orderStatus = orderStatus;
        }

        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string Sender
        {
            get => _senderPhone;
            set { _senderPhone = value; OnPropertyChanged(nameof(Sender)); }
        }

        public string Receiver
        {
            get => _receiverPhone;
            set { _receiverPhone = value; OnPropertyChanged(nameof(Receiver)); }
        }

        public double PackageWeight
        {
            get => _packageWeight;
            set { _packageWeight = value; OnPropertyChanged(nameof(PackageWeight)); }
        }

        public string SenderBranch
        {
            get => _senderBranch;
            set { _senderBranch = value; OnPropertyChanged(nameof(SenderBranch)); }
        }

        public string ReceiverBranch
        {
            get => _receiverBranch;
            set { _receiverBranch = value; OnPropertyChanged(nameof(ReceiverBranch)); }
        }

        public string Worker
        {
            get => _worker;
            set { _worker = value; OnPropertyChanged(nameof(Worker)); }
        }

        public double Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(nameof(Price)); }
        }

        public DateTime OrderDate
        {
            get => _orderDate;
            set { _orderDate = value; OnPropertyChanged(nameof(OrderDate)); }
        }

        public PaymentType PaymentType
        {
            get => _paymentType;
            set { _paymentType = value; OnPropertyChanged(nameof(PaymentType)); }
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