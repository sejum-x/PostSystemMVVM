using System.Runtime.Serialization;

namespace PostSystemMVVM.Model;

[DataContract]
public enum WorkerPosition
{
    [EnumMember]
    Operator,
    [EnumMember]
    Manager,
    [EnumMember]
    Supervisor
}