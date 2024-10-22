using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    public class Package : BaseViewModel
    {
        private int _id;
        private string _description;
        private double _weight;
        private double _height;
        private double _width;
        private double _length;
        private PackageType _type;

        public Package()
        {
            this._id = 0;
            this._description = "";
            this._weight = 0;
            this._height = 0;
            this._width = 0;
            this._length = 0;
            this._type = new PackageType();
        }

        public Package(int id, string description, double weight, double height, double width, double length, PackageType type)
        {
            this._id = id;
            this._description = description;
            this._weight = weight;
            this._height = height;
            this._width = width;
            this._length = length;
            this._type = type;
        }

        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public double Weight
        {
            get => _weight;
            set { _weight = value; OnPropertyChanged(nameof(Weight)); }
        }

        public double Height
        {
            get => _height;
            set { _height = value; OnPropertyChanged(nameof(Height)); }
        }

        public double Width
        {
            get => _width;
            set { _width = value; OnPropertyChanged(nameof(Width)); }
        }

        public double Length
        {
            get => _length;
            set { _length = value; OnPropertyChanged(nameof(Length)); }
        }

        public PackageType Type
        {
            get => _type;
            set { _type = value; OnPropertyChanged(nameof(Type)); }
        }
    }
}
