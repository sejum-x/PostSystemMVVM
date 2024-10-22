using PostSystemMVVM.ViewModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PostSystemMVVM.Model
{
    [DataContract]
    public class Order : BaseViewModel
    {
        [DataMember]
        public string TrackNumber { get; set; }

        [DataMember]
        public string Sender { get; set; }

        [DataMember]
        public string Receiver { get; set; }

        [DataMember]
        public string ReceiverAdress { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentStatus PaymentStatus { get; set; }

        [DataMember]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OrderStatus OrderStatus { get; set; }
    }
}