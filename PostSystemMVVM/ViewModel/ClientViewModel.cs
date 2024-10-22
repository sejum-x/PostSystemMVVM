using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSystemMVVM.ViewModel
{
    public class ClientViewModel : BaseViewModel
    {
        private int _id;
        private string _fullName;
        private string _email;
        private string _contactNumber;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string ContactNumber
        {
            get => _contactNumber;
            set
            {
                _contactNumber = value;
                OnPropertyChanged(nameof(ContactNumber));
            }
        }
    }
}