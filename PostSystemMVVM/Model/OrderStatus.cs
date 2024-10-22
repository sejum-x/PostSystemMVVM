using System.Runtime.Serialization;

namespace PostSystemMVVM.Model;

[DataContract]
public enum OrderStatus
{
    [EnumMember]
    Pending,
    [EnumMember]
    InProgress,
    [EnumMember]
    Delivered,
    [EnumMember]
    Canceled
}