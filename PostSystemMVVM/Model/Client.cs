using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    public class Client : BaseViewModel
    {
        private int _id;
        private string _fullName;
        private string _email;
        private string _contactNumber;

        public Client()
        {
            this._id = 0;
            this._fullName = "";
            this._email = "";
            this._contactNumber = "";
        }

        public Client(int id, string fullName, string email, string contactNumber)
        {
            this._id = id;
            this._fullName = fullName;
            this._email = email;
            this._contactNumber = contactNumber;
        }

        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string ContactNumber
        {
            get => _contactNumber;
            set { _contactNumber = value; OnPropertyChanged(nameof(ContactNumber)); }
        }
    }
}
