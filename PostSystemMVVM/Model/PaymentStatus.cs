using System.Runtime.Serialization;

namespace PostSystemMVVM.Model;

[DataContract]
public enum PaymentStatus
{
    [EnumMember]
    Pending,
    [EnumMember]
    Paid,
    [EnumMember]
    Canceled
}