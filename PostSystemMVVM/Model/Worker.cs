using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    public class Worker : BaseViewModel
    {
        private int _id;
        private string _fullName;
        private string _email;
        private string _contactNumber;
        private WorkerPosition _position;

        public Worker()
        {
            this._id = 0;
            this._fullName = "";
            this._email = "";
            this._contactNumber = "";
            this._position = WorkerPosition.Operator;
        }

        public Worker(int id, string fullName, string email, string contactNumber, WorkerPosition position)
        {
            this._id = id;
            this._fullName = fullName;
            this._email = email;
            this._contactNumber = contactNumber;
            this._position = position;
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

        public WorkerPosition Position
        {
            get => _position;
            set { _position = value; OnPropertyChanged(nameof(Position)); }
        }
    }
}