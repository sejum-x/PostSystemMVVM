using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ContactNumber { get; set; }
    }
}
