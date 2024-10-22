using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    [DataContract]
    public class Worker
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ContactNumber { get; set; }
        [DataMember]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WorkerPosition Position { get; set; }
    }
}